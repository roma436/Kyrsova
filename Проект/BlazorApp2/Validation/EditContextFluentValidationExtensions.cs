using FluentValidation;
using FluentValidation.Internal;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BlazorApp2.Validation
{
    public static class EditContextFluentValidationExtensions
    {

        //выбор валидации и создание месседжа для текущего editContext
        public static EditContext AddFluentValidation(this EditContext editContext)
        {
            if (editContext == null)
            {
                throw new ArgumentNullException(nameof(editContext));
            }

            var messages = new ValidationMessageStore(editContext);
            //событие срабатывает, когда требуется проверка всей модели
            // event fires when verification of the entire model is required
            editContext.OnValidationRequested +=
                (sender, eventArgs) => ValidateModel((EditContext)sender, messages);
            //событие срабатывает, при изменении значений полей
            // event is triggered when field values ​​change
            editContext.OnFieldChanged +=
                (sender, eventArgs) => ValidateField(editContext, messages, eventArgs.FieldIdentifier);

            return editContext;
        }

        //проверка модели вызывается OnValidationRequested
        private static void ValidateModel(EditContext editContext, ValidationMessageStore messages)
        {
            var validator = GetValidatorForModel(editContext.Model);
            var validationResults = validator.Validate(editContext.Model);

            messages.Clear();//очищай хранилища
            foreach (var validationResult in validationResults.Errors)
            {
                messages.Add(editContext.Field(validationResult.PropertyName), validationResult.ErrorMessage);
            }

            editContext.NotifyValidationStateChanged();// сообщает editContext-у что произовли изменения
        }

        //проверка отдельных полей
        private static void ValidateField(EditContext editContext, ValidationMessageStore messages, in FieldIdentifier fieldIdentifier)
        {
            //ValidationContext позволяет указать поля, которые мы хотим проверить
            var properties = new[] { fieldIdentifier.FieldName };
            var context = new ValidationContext(fieldIdentifier.Model, new PropertyChain(), new MemberNameValidatorSelector(properties));
            //настройка для включения только поля, вызвавшего событие
            var validator = GetValidatorForModel(fieldIdentifier.Model);
            var validationResults = validator.Validate(context);

            messages.Clear(fieldIdentifier);
            //messages.AddRange(fieldIdentifier, validationResults.Errors.Select(error => error.ErrorMessage));
            foreach (var validationResult in validationResults.Errors)
            {
                messages.Add(editContext.Field(validationResult.PropertyName), validationResult.ErrorMessage);
            }

            editContext.NotifyValidationStateChanged();
        }

        private static IValidator GetValidatorForModel(object model)
        {
            var abstractValidatorType = typeof(AbstractValidator<>).MakeGenericType(model.GetType());
            var modelValidatorType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.IsSubclassOf(abstractValidatorType));
            var modelValidatorInstance = (IValidator)Activator.CreateInstance(modelValidatorType);

            return modelValidatorInstance;
        }
    }
}
