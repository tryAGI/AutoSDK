using System.CommandLine;
using System.CommandLine.Binding;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;

namespace AutoSDK.CLI.Commands;

internal sealed class SettingsBinder(
    Option<string> targetFramework,
    Option<string> @namespace,
    Option<string> clientClassName,
    Option<MethodNamingConvention> methodNamingConvention,
    Option<bool> excludeDeprecatedOperations,
    Option<string> clsCompliantEnumPrefix,
    Option<bool> ignoreOpenApiErrors,
    Option<bool> ignoreOpenApiWarnings,
    Option<bool> validation
    )
    : BinderBase<Settings>
{
    protected override Settings GetBoundValue(BindingContext bindingContext)
    {
        bindingContext = bindingContext ?? throw new ArgumentNullException(nameof(bindingContext));
        
        var namespaceValue = bindingContext.ParseResult.GetValueForOption(@namespace);
        
        return Settings.Default with
        {
            TargetFramework = bindingContext.ParseResult.GetValueForOption(targetFramework)!,
            Namespace = namespaceValue!,
            ClassName = bindingContext.ParseResult.GetValueForOption(clientClassName)!,
            ClsCompliantEnumPrefix = bindingContext.ParseResult.GetValueForOption(clsCompliantEnumPrefix)!,
            MethodNamingConvention = bindingContext.ParseResult.GetValueForOption(methodNamingConvention),
            ExcludeDeprecatedOperations = bindingContext.ParseResult.GetValueForOption(excludeDeprecatedOperations),
            JsonSerializerContext = $"{namespaceValue}.SourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
            GenerateModelValidationMethods = bindingContext.ParseResult.GetValueForOption(validation),
            IgnoreOpenApiErrors = bindingContext.ParseResult.GetValueForOption(ignoreOpenApiErrors),
            IgnoreOpenApiWarnings = bindingContext.ParseResult.GetValueForOption(ignoreOpenApiWarnings),
            FromCli = true,
        };
    }
}