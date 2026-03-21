using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Properties;

namespace AutoSDK.Naming.Methods;

public class SummaryGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var methodName = operation.Operation.Summary?
            .StripExperimentalStagePrefix()
            .Replace("'", string.Empty)
            .Replace("’", string.Empty)
            .ToPropertyName()
            .UseWordSeparator(StringExtensions.MethodSeparators);

        return CSharpPropertyNameGenerator.SanitizeName(
            methodName,
            operation.Settings.ClsCompliantEnumPrefix,
            skipHandlingWordSeparators: true);
    }
}
