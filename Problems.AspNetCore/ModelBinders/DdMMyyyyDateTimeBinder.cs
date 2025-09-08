using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace Problems.AspNetCore.ModelBinders
{
    public class DdMMyyyyDateTimeBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (valueProviderResult == ValueProviderResult.None) return Task.CompletedTask;

            var value = valueProviderResult.FirstValue;
            if (string.IsNullOrEmpty(value)) return Task.CompletedTask;

            if (DateTime.TryParseExact(value, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dt))
            {
                bindingContext.Result = ModelBindingResult.Success(dt);
            }
            else
            {
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "Invalid date format. Use dd-MM-yyyy.");
            }
            return Task.CompletedTask;
        }
    }
}
