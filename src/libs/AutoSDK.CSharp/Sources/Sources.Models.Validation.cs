using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateClassValidationMethods(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return GenerateModelValidationMethods(
            @namespace: modelData.Namespace,
            className: modelData.ClassName,
            settings: modelData.Settings,
            isValueType: false,
            cancellationToken);
    }
    
    public static string GenerateAnyOfValidationMethods(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        var types = $"<{string.Join(", ", Enumerable.Range(1, anyOfData.Count).Select(x => $"T{x}"))}>";
        var className = !anyOfData.IsNamed
            ? $"{anyOfData.SubType}{types}"
            : anyOfData.Name;
        
        return GenerateModelValidationMethods(
            @namespace: anyOfData.Namespace,
            className: className,
            settings: anyOfData.Settings,
            isValueType: true,
            cancellationToken);
    }

    public static string GenerateModelValidationMethods(
        string @namespace,
        string className,
        Settings settings,
        bool isValueType,
        CancellationToken cancellationToken = default)
    {
        var modifiers = isValueType
            ? "readonly partial struct"
            : "sealed partial class";
        
        // MaxTokens (int?) minimum
        // if (MaxTokens < (int?)0)
        // {{
        //     yield return new global::System.ComponentModel.DataAnnotations.ValidationResult(
        //         errorMessage: ""Invalid value for MaxTokens, must be a value greater than or equal to 0."",
        //         memberNames: new[] {{ ""MaxTokens"" }});
        // }}
        
        return @$"#nullable enable

namespace {@namespace}
{{
    public {modifiers} {className} : global::System.ComponentModel.DataAnnotations.IValidatableObject
    {{
        /// <inheritdoc />
        public global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.ValidationResult> Validate(
            global::System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {{
            yield break;
        }}
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}