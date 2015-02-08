namespace Purevision.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DateGreaterThanAttribute : ValidationAttribute
    {
        private const string DEFAULT_ERROR_MSG_TEMPLATE = "{0} must be greater that {1}";
        
        public DateGreaterThanAttribute()
        {
            if (String.IsNullOrEmpty(ErrorMessage))
            {
                ErrorMessage = DEFAULT_ERROR_MSG_TEMPLATE;
            }
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // hack:  unsure why / how value is losing its Kind property, which should be Utc as set when End setter sets End by call to value.ToUniveralTime
            if (value != null) value = ((DateTime)value).ToUniversalTime();

            DateTime? date = value != null ? (DateTime?)value : null;
            var otherValue = validationContext.ObjectType.GetProperty(OtherField).GetValue(validationContext.ObjectInstance);
            var isAllDay = (bool)validationContext.ObjectType.GetProperty(IsAllDay).GetValue(validationContext.ObjectInstance);
            DateTime? otherDate = otherValue != null ? (DateTime?)otherValue : null;
            if (date.HasValue && otherDate.HasValue && otherDate >= date && !isAllDay)
            {
                return new ValidationResult(String.Format(ErrorMessage, validationContext.DisplayName, OtherField));
            }

            return ValidationResult.Success;

        }

        public string OtherField { get; set; }

        public string IsAllDay { get; set; }
    }
}