namespace Forge.Schema.Models.Validations;

public interface IConfigurationValidator
{
    ValidationResult Validate(LayoutTemplate layoutTemplate);
}