using System.CommandLine;
using System.CommandLine.Binding;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;

namespace AutoSDK.CLI.Commands;

public class SettingsBinder(
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
        
        return new Settings(
            TargetFramework: bindingContext.ParseResult.GetValueForOption(targetFramework)!,
            Namespace: namespaceValue!,
            ClassName: bindingContext.ParseResult.GetValueForOption(clientClassName)!,
            ClsCompliantEnumPrefix: bindingContext.ParseResult.GetValueForOption(clsCompliantEnumPrefix)!,
            NamingConvention: default,
            JsonSerializerType: default,
            UseRequiredKeyword: default,
            UseExperimentalAttributes: default,
            GenerateConstructors: false,
            GroupByTags: true,
            GenerateMethods: false,
            MethodNamingConvention: bindingContext.ParseResult.GetValueForOption(methodNamingConvention),
            MethodNamingConventionFallback: MethodNamingConvention.MethodAndPath,
            GenerateMethodsAsHttpClientExtensions: false,
            GenerateMethodsUsingSystemNetHttpJson: false,
            IncludeOperationIds: [],
            ExcludeOperationIds: [],
            IncludeTags: [],
            ExcludeTags: [],
            ExcludeDeprecatedOperations: bindingContext.ParseResult.GetValueForOption(excludeDeprecatedOperations),
            JsonSerializerContext: $"{namespaceValue}.SourceGenerationContext",
            GenerateJsonSerializerContextTypes: true,
            GenerateModels: false,
            GenerateModelValidationMethods: bindingContext.ParseResult.GetValueForOption(validation),
            ValidateAnyOfs: false,
            ModelStyle: default,
            IncludeModels: [],
            ExcludeModels: [],
            GeneratePolyfills: true,
            IgnoreOpenApiErrors: bindingContext.ParseResult.GetValueForOption(ignoreOpenApiErrors),
            IgnoreOpenApiWarnings: bindingContext.ParseResult.GetValueForOption(ignoreOpenApiWarnings),
            GenerateSdk: true,
            FromCli: true
        );
    }
}