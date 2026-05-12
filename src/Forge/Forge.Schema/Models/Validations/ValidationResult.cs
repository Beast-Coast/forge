namespace Forge.Schema.Models.Validations;

using System.Collections.Generic;

public record ValidationResult(IReadOnlyList<ValidationError> ValidationErrors)
{
    public bool IsValid => ValidationErrors.Count == 0;
    
    public static ValidationResult Success => new(Array.Empty<ValidationError>());

    public static ValidationResult Failures(params ValidationError[] errors) => new(errors);
};