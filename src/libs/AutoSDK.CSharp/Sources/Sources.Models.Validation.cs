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
            validationBody: GenerateValidationBody(modelData),
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
            validationBody: "yield break;",
            isValueType: true,
            cancellationToken);
    }

    public static string GenerateModelValidationMethods(
        string @namespace,
        string className,
        EmitterSettings settings,
        string validationBody,
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
            {validationBody}
        }}
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    internal static string GenerateValidationAttributes(
        ModelData modelData,
        PropertyData property)
    {
        if (!modelData.Settings.GenerateModelValidationMethods)
        {
            return string.Empty;
        }

        var attributes = new List<string>();

        if (property.IsRequired &&
            (!property.Type.IsValueType || property.Type.CSharpTypeNullability))
        {
            attributes.Add("[global::System.ComponentModel.DataAnnotations.Required]");
        }

        if (string.Equals(property.Type.CSharpTypeWithoutNullability, "string", StringComparison.Ordinal))
        {
            if (property.MinLength is { } minLength &&
                property.MaxLength is { } maxLength)
            {
                attributes.Add($"[global::System.ComponentModel.DataAnnotations.StringLength({maxLength}, MinimumLength = {minLength})]");
            }
            else
            {
                if (property.MinLength is { } onlyMinLength)
                {
                    attributes.Add($"[global::System.ComponentModel.DataAnnotations.MinLength({onlyMinLength})]");
                }

                if (property.MaxLength is { } onlyMaxLength)
                {
                    attributes.Add($"[global::System.ComponentModel.DataAnnotations.MaxLength({onlyMaxLength})]");
                }
            }

            if (!string.IsNullOrWhiteSpace(property.Pattern))
            {
                attributes.Add($"[global::System.ComponentModel.DataAnnotations.RegularExpression({property.Pattern.ToCSharpStringLiteral()})]");
            }
        }
        else if (property.Type.IsArray &&
                 !property.Type.IsBinary)
        {
            if (property.MinItems is { } minItems)
            {
                attributes.Add($"[global::System.ComponentModel.DataAnnotations.MinLength({minItems})]");
            }

            if (property.MaxItems is { } maxItems)
            {
                attributes.Add($"[global::System.ComponentModel.DataAnnotations.MaxLength({maxItems})]");
            }
        }

        if (TryGetRangeAttribute(property, out var rangeAttribute))
        {
            attributes.Add(rangeAttribute);
        }

        return attributes.Count == 0
            ? string.Empty
            : string.Join("\n        ", attributes);
    }

    private static string GenerateValidationBody(ModelData modelData)
    {
        var statements = modelData.Properties
            .SelectMany(GenerateValidationStatements)
            .Inject();

        return statements == TrimmedLine
            ? "yield break;"
            : statements;
    }

    private static IEnumerable<string> GenerateValidationStatements(
        PropertyData property)
    {
        if (!TryGetValidationParseExpression(property.Type.CSharpTypeWithoutNullability, out var parseExpressionFactory))
        {
            yield break;
        }

        var hasInclusiveMinimum = !string.IsNullOrWhiteSpace(property.Minimum);
        var hasInclusiveMaximum = !string.IsNullOrWhiteSpace(property.Maximum);
        var hasExclusiveMinimum = !string.IsNullOrWhiteSpace(property.ExclusiveMinimum);
        var hasExclusiveMaximum = !string.IsNullOrWhiteSpace(property.ExclusiveMaximum);

        if (hasInclusiveMinimum &&
            hasInclusiveMaximum &&
            !hasExclusiveMinimum &&
            !hasExclusiveMaximum)
        {
            yield break;
        }

        var (guard, valueExpression) = GetValidationValueExpression(property);

        if (hasInclusiveMinimum)
        {
            yield return GenerateValidationStatement(
                property,
                guard,
                valueExpression,
                "<",
                parseExpressionFactory(property.Minimum),
                $"Invalid value for {property.Name}, must be a value greater than or equal to {property.Minimum}.");
        }

        if (hasInclusiveMaximum)
        {
            yield return GenerateValidationStatement(
                property,
                guard,
                valueExpression,
                ">",
                parseExpressionFactory(property.Maximum),
                $"Invalid value for {property.Name}, must be a value less than or equal to {property.Maximum}.");
        }

        if (hasExclusiveMinimum)
        {
            yield return GenerateValidationStatement(
                property,
                guard,
                valueExpression,
                "<=",
                parseExpressionFactory(property.ExclusiveMinimum),
                $"Invalid value for {property.Name}, must be a value greater than {property.ExclusiveMinimum}.");
        }

        if (hasExclusiveMaximum)
        {
            yield return GenerateValidationStatement(
                property,
                guard,
                valueExpression,
                ">=",
                parseExpressionFactory(property.ExclusiveMaximum),
                $"Invalid value for {property.Name}, must be a value less than {property.ExclusiveMaximum}.");
        }
    }

    private static string GenerateValidationStatement(
        PropertyData property,
        string guard,
        string valueExpression,
        string comparisonOperator,
        string boundExpression,
        string message)
    {
        var condition = string.IsNullOrWhiteSpace(guard)
            ? $"{valueExpression} {comparisonOperator} {boundExpression}"
            : $"{guard}{valueExpression} {comparisonOperator} {boundExpression}";

        return $@"
            if ({condition})
            {{
                yield return new global::System.ComponentModel.DataAnnotations.ValidationResult(
                    errorMessage: {message.ToCSharpStringLiteral()},
                    memberNames: new[] {{ nameof({property.Name}) }});
            }}";
    }

    private static (string Guard, string ValueExpression) GetValidationValueExpression(PropertyData property)
    {
        if (property.Type.CSharpTypeNullability &&
            property.Type.IsValueType)
        {
            return ($"{property.Name}.HasValue && ", $"{property.Name}.Value");
        }

        return (string.Empty, property.Name);
    }

    private static bool TryGetRangeAttribute(
        PropertyData property,
        out string attribute)
    {
        attribute = string.Empty;

        if (string.IsNullOrWhiteSpace(property.Minimum) ||
            string.IsNullOrWhiteSpace(property.Maximum) ||
            !string.IsNullOrWhiteSpace(property.ExclusiveMinimum) ||
            !string.IsNullOrWhiteSpace(property.ExclusiveMaximum) ||
            !TryGetRangeTypeExpression(property.Type.CSharpTypeWithoutNullability, out var typeExpression))
        {
            return false;
        }

        attribute = $"[global::System.ComponentModel.DataAnnotations.Range(typeof({typeExpression}), {property.Minimum.ToCSharpStringLiteral()}, {property.Maximum.ToCSharpStringLiteral()})]";
        return true;
    }

    private static bool TryGetRangeTypeExpression(
        string csharpTypeWithoutNullability,
        out string typeExpression)
    {
        switch (csharpTypeWithoutNullability)
        {
            case "int":
            case "long":
            case "float":
            case "double":
            case "decimal":
                typeExpression = csharpTypeWithoutNullability;
                return true;
            default:
                typeExpression = string.Empty;
                return false;
        }
    }

    private static bool TryGetValidationParseExpression(
        string csharpTypeWithoutNullability,
        out Func<string, string> parseExpressionFactory)
    {
        switch (csharpTypeWithoutNullability)
        {
            case "int":
                parseExpressionFactory = static value => $"global::System.Int32.Parse({value.ToCSharpStringLiteral()}, global::System.Globalization.CultureInfo.InvariantCulture)";
                return true;
            case "long":
                parseExpressionFactory = static value => $"global::System.Int64.Parse({value.ToCSharpStringLiteral()}, global::System.Globalization.CultureInfo.InvariantCulture)";
                return true;
            case "float":
                parseExpressionFactory = static value => $"global::System.Single.Parse({value.ToCSharpStringLiteral()}, global::System.Globalization.CultureInfo.InvariantCulture)";
                return true;
            case "double":
                parseExpressionFactory = static value => $"global::System.Double.Parse({value.ToCSharpStringLiteral()}, global::System.Globalization.CultureInfo.InvariantCulture)";
                return true;
            case "decimal":
                parseExpressionFactory = static value => $"global::System.Decimal.Parse({value.ToCSharpStringLiteral()}, global::System.Globalization.CultureInfo.InvariantCulture)";
                return true;
            default:
                parseExpressionFactory = null!;
                return false;
        }
    }
}
