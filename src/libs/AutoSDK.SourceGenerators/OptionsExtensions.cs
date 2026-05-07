using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;
using AutoSDK.Serialization.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace AutoSDK.SourceGenerators;

public static class OptionsExtensions
{
    public static Settings GetSettings(
        this AnalyzerConfigOptionsProvider options,
        string prefix,
        AdditionalText? additionalText = null)
    {
        return new Settings(
            TargetFramework: options.GetGlobalOption("TargetFramework", prefix) ??
                             options.GetGlobalOption("TargetFramework") ??
                             "netstandard2.0",
            Namespace: GetOptionFromAdditionalText(nameof(Settings.Namespace)) ??
                       options.GetGlobalOption(nameof(Settings.Namespace), prefix) ??
                       options.GetGlobalOption("PackageId") ??
                       options.GetGlobalOption("AssemblyName") ??
                       prefix,
            ClassName: GetOptionFromAdditionalText(nameof(Settings.ClassName)) ??
                       options.GetGlobalOption(nameof(Settings.ClassName), prefix) ??
                       options.GetGlobalOption("PackageId")?.WithPostfix("Api") ??
                       options.GetGlobalOption("AssemblyName")?.WithPostfix("Api") ??
                       "Api",
            ClsCompliantEnumPrefix: options.GetGlobalOption(nameof(Settings.ClsCompliantEnumPrefix), prefix) ??
                                    "x",
            IdentifierCharacterSet: options.GetEnumGlobalOption(
                nameof(Settings.IdentifierCharacterSet),
                prefix,
                defaultValue: Settings.Default.IdentifierCharacterSet),
            NamingConvention: options.GetEnumGlobalOption<NamingConvention>(nameof(Settings.NamingConvention), prefix),
            JsonSerializerType: options.GetEnumGlobalOption<JsonSerializerType>(nameof(Settings.JsonSerializerType), prefix),
            UseRequiredKeyword: options.GetEnumGlobalOption<SdkFeatureUsage>(nameof(Settings.UseRequiredKeyword), prefix),
            UseExperimentalAttributes: options.GetEnumGlobalOption<SdkFeatureUsage>(nameof(Settings.UseExperimentalAttributes), prefix),
            UseSetsRequiredMembersAttributes: options.GetEnumGlobalOption<SdkFeatureUsage>(nameof(Settings.UseSetsRequiredMembersAttributes), prefix),
            
            GenerateConstructors: options.GetBoolGlobalOption(nameof(Settings.GenerateConstructors), prefix, defaultValue: Settings.Default.GenerateConstructors),
            GroupByTags: options.GetBoolGlobalOption(nameof(Settings.GroupByTags), prefix, defaultValue: Settings.Default.GroupByTags),
            GenerateMethods: options.GetBoolGlobalOption(nameof(Settings.GenerateMethods), prefix, defaultValue: Settings.Default.GenerateMethods),
            MethodNamingConvention: options.GetEnumGlobalOption<MethodNamingConvention>(nameof(Settings.MethodNamingConvention), prefix),
            MethodNamingConventionFallback: options.GetEnumGlobalOption(nameof(Settings.MethodNamingConventionFallback), prefix, defaultValue: MethodNamingConvention.MethodAndPath),
            GenerateMethodsAsHttpClientExtensions: options.GetBoolGlobalOption(nameof(Settings.GenerateMethodsAsHttpClientExtensions), prefix, defaultValue: Settings.Default.GenerateMethodsAsHttpClientExtensions),
            GenerateMethodsUsingSystemNetHttpJson: options.GetBoolGlobalOption(nameof(Settings.GenerateMethodsUsingSystemNetHttpJson), prefix, defaultValue: Settings.Default.GenerateMethodsUsingSystemNetHttpJson),
            GenerateDependencyInjection: options.GetBoolGlobalOption(nameof(Settings.GenerateDependencyInjection), prefix, defaultValue: Settings.Default.GenerateDependencyInjection),
            GenerateConfigurationBinding: options.GetBoolGlobalOption(nameof(Settings.GenerateConfigurationBinding), prefix, defaultValue: Settings.Default.GenerateConfigurationBinding),
            GenerateHttpResilienceExtensions: options.GetBoolGlobalOption(nameof(Settings.GenerateHttpResilienceExtensions), prefix, defaultValue: Settings.Default.GenerateHttpResilienceExtensions),
            GenerateWebhookVerifier: options.GetBoolGlobalOption(nameof(Settings.GenerateWebhookVerifier), prefix, defaultValue: Settings.Default.GenerateWebhookVerifier),
            WebhookVerifierClassName: options.GetGlobalOption(nameof(Settings.WebhookVerifierClassName), prefix) ?? Settings.Default.WebhookVerifierClassName,
            WebhookIdHeaderName: options.GetGlobalOption(nameof(Settings.WebhookIdHeaderName), prefix) ?? Settings.Default.WebhookIdHeaderName,
            WebhookTimestampHeaderName: options.GetGlobalOption(nameof(Settings.WebhookTimestampHeaderName), prefix) ?? Settings.Default.WebhookTimestampHeaderName,
            WebhookSignatureHeaderName: options.GetGlobalOption(nameof(Settings.WebhookSignatureHeaderName), prefix) ?? Settings.Default.WebhookSignatureHeaderName,
            WebhookSignatureVersion: options.GetGlobalOption(nameof(Settings.WebhookSignatureVersion), prefix) ?? Settings.Default.WebhookSignatureVersion,
            WebhookTimestampToleranceSeconds: options.GetIntGlobalOption(nameof(Settings.WebhookTimestampToleranceSeconds), prefix, defaultValue: Settings.Default.WebhookTimestampToleranceSeconds),
            GenerateDynamicMultipartHelpers: options.GetBoolGlobalOption(nameof(Settings.GenerateDynamicMultipartHelpers), prefix, defaultValue: Settings.Default.GenerateDynamicMultipartHelpers),
            DynamicMultipartHelperClassName: options.GetGlobalOption(nameof(Settings.DynamicMultipartHelperClassName), prefix) ?? Settings.Default.DynamicMultipartHelperClassName,
            GeneratePromptTemplateHelpers: options.GetBoolGlobalOption(nameof(Settings.GeneratePromptTemplateHelpers), prefix, defaultValue: Settings.Default.GeneratePromptTemplateHelpers),
            PromptTemplateHelperClassName: options.GetGlobalOption(nameof(Settings.PromptTemplateHelperClassName), prefix) ?? Settings.Default.PromptTemplateHelperClassName,
            GenerateObservabilityLifecycleHelpers: options.GetBoolGlobalOption(nameof(Settings.GenerateObservabilityLifecycleHelpers), prefix, defaultValue: Settings.Default.GenerateObservabilityLifecycleHelpers),
            ObservabilityLifecycleHelperClassName: options.GetGlobalOption(nameof(Settings.ObservabilityLifecycleHelperClassName), prefix) ?? Settings.Default.ObservabilityLifecycleHelperClassName,
            GeneratePredictionWorkflowHelpers: options.GetBoolGlobalOption(nameof(Settings.GeneratePredictionWorkflowHelpers), prefix, defaultValue: Settings.Default.GeneratePredictionWorkflowHelpers),
            PredictionWorkflowHelperClassName: options.GetGlobalOption(nameof(Settings.PredictionWorkflowHelperClassName), prefix) ?? Settings.Default.PredictionWorkflowHelperClassName,
            GenerateEvaluationWorkflowHelpers: options.GetBoolGlobalOption(nameof(Settings.GenerateEvaluationWorkflowHelpers), prefix, defaultValue: Settings.Default.GenerateEvaluationWorkflowHelpers),
            EvaluationWorkflowHelperClassName: options.GetGlobalOption(nameof(Settings.EvaluationWorkflowHelperClassName), prefix) ?? Settings.Default.EvaluationWorkflowHelperClassName,
            IncludeOperationIds: (options.GetGlobalOption(nameof(Settings.IncludeOperationIds), prefix)?.Split(';') ??
                                   []).ToImmutableArray(),
            ExcludeOperationIds: (options.GetGlobalOption(nameof(Settings.ExcludeOperationIds), prefix)?.Split(';') ??
                                  []).ToImmutableArray(),
            IncludeTags: (options.GetGlobalOption(nameof(Settings.IncludeTags), prefix)?.Split(';') ??
                                  []).ToImmutableArray(),
            ExcludeTags: (options.GetGlobalOption(nameof(Settings.ExcludeTags), prefix)?.Split(';') ??
                                  []).ToImmutableArray(),
            ExcludeDeprecatedOperations: options.GetBoolGlobalOption(nameof(Settings.ExcludeDeprecatedOperations), prefix, defaultValue: Settings.Default.ExcludeDeprecatedOperations),
            UseExtensionNaming: options.GetBoolGlobalOption(nameof(Settings.UseExtensionNaming), prefix, defaultValue: Settings.Default.UseExtensionNaming),
            JsonSerializerContext: options.GetGlobalOption(nameof(Settings.JsonSerializerContext), prefix) ?? string.Empty,
            GenerateJsonSerializerContextTypes: options.GetBoolGlobalOption(nameof(Settings.GenerateJsonSerializerContextTypes), prefix, defaultValue: Settings.Default.GenerateJsonSerializerContextTypes),
            ComputeDiscriminators: options.GetBoolGlobalOption(nameof(Settings.ComputeDiscriminators), prefix, defaultValue: Settings.Default.ComputeDiscriminators),
            AddMissingPathParameters: options.GetBoolGlobalOption(nameof(Settings.AddMissingPathParameters), prefix, defaultValue: Settings.Default.AddMissingPathParameters),
            
            GenerateModels: options.GetBoolGlobalOption(nameof(Settings.GenerateModels), prefix, defaultValue: Settings.Default.GenerateModels),
            GenerateModelValidationMethods: options.GetBoolGlobalOption(nameof(Settings.GenerateModelValidationMethods), prefix, defaultValue: Settings.Default.GenerateModelValidationMethods),
            ValidateAnyOfs: options.GetBoolGlobalOption(nameof(Settings.ValidateAnyOfs), prefix, defaultValue: Settings.Default.ValidateAnyOfs),
            GenerateRawModelData: options.GetBoolGlobalOption(nameof(Settings.GenerateRawModelData), prefix, defaultValue: Settings.Default.GenerateRawModelData),
            ModelStyle: options.GetEnumGlobalOption<ModelStyle>(nameof(Settings.ModelStyle), prefix),
            IncludeModels: (options.GetGlobalOption(nameof(Settings.IncludeModels), prefix)?.Split(';') ??
                            []).ToImmutableArray(),
            ExcludeModels: (options.GetGlobalOption(nameof(Settings.ExcludeModels), prefix)?.Split(';') ??
                            []).ToImmutableArray(),
            NamespaceDelimiter: options.GetGlobalOption(nameof(Settings.NamespaceDelimiter), prefix) ?? string.Empty,
            ExcludedModelNamespaceMode: options.GetEnumGlobalOption(
                nameof(Settings.ExcludedModelNamespaceMode),
                prefix,
                defaultValue: Settings.Default.ExcludedModelNamespaceMode),
            
            GeneratePolyfills: options.GetBoolGlobalOption(nameof(Settings.GeneratePolyfills), prefix, defaultValue: Settings.Default.GeneratePolyfills),
            GenerateExceptions: options.GetBoolGlobalOption(nameof(Settings.GenerateExceptions), prefix, defaultValue: Settings.Default.GenerateExceptions),
            
            IgnoreOpenApiErrors: options.GetBoolGlobalOption(nameof(Settings.IgnoreOpenApiErrors), prefix, defaultValue: Settings.Default.IgnoreOpenApiErrors),
            IgnoreOpenApiWarnings: options.GetBoolGlobalOption(nameof(Settings.IgnoreOpenApiWarnings), prefix, defaultValue: Settings.Default.IgnoreOpenApiWarnings),
            
            GenerateSdk: options.GetBoolGlobalOption(nameof(Settings.GenerateSdk), prefix, defaultValue: Settings.Default.GenerateSdk),
            FromCli: false,
            GenerateCli: options.GetBoolGlobalOption(nameof(Settings.GenerateCli), prefix, defaultValue: Settings.Default.GenerateCli),
            SecuritySchemes: (options.GetGlobalOption(nameof(Settings.SecuritySchemes), prefix)?.Split(';') ??
                              []).ToImmutableArray(),
            AuthorizationEnvironmentVariables: (options.GetGlobalOption(nameof(Settings.AuthorizationEnvironmentVariables), prefix)?.Split(';') ??
                                                []).Where(static x => !string.IsNullOrWhiteSpace(x)).ToImmutableArray(),
            BaseUrl: options.GetGlobalOption(nameof(Settings.BaseUrl), prefix) ?? string.Empty,
            BaseUrlEnvironmentVariables: (options.GetGlobalOption(nameof(Settings.BaseUrlEnvironmentVariables), prefix)?.Split(';') ??
                                          []).Where(static x => !string.IsNullOrWhiteSpace(x)).ToImmutableArray(),
            OpenApiOverrides: (options.GetGlobalOption(nameof(Settings.OpenApiOverrides), prefix)?.Split(';') ??
                               []).Where(static x => !string.IsNullOrWhiteSpace(x)).ToImmutableArray(),
            GenerateWebSocketClient: options.GetBoolGlobalOption(nameof(Settings.GenerateWebSocketClient), prefix, defaultValue: Settings.Default.GenerateWebSocketClient),
            WebSocketClientClassName: options.GetGlobalOption(nameof(Settings.WebSocketClientClassName), prefix) ?? string.Empty,
            TypesNamespace: options.GetGlobalOption(nameof(Settings.TypesNamespace), prefix) ?? string.Empty);
        
        string? GetOptionFromAdditionalText(string name)
        {
            if (additionalText == null)
            {
                return null;
            }
            
            return options.GetOption(additionalText, name, prefix: prefix);
        }
    }
    
    public static bool GetBoolGlobalOption(
        this AnalyzerConfigOptionsProvider provider,
        string name,
        string? prefix = null,
        bool defaultValue = false)
    {
        provider = provider ?? throw new ArgumentNullException(nameof(provider));
        name = name ?? throw new ArgumentNullException(nameof(name));

        return bool.TryParse(
            provider.GetGlobalOption(name, prefix),
            out var value) ? value : defaultValue;
    }
    
    public static T GetEnumGlobalOption<T>(
        this AnalyzerConfigOptionsProvider provider,
        string name,
        string? prefix = null,
        T defaultValue = default) where T : struct, Enum
    {
        provider = provider ?? throw new ArgumentNullException(nameof(provider));
        name = name ?? throw new ArgumentNullException(nameof(name));

        return Enum.TryParse<T>(
            provider.GetGlobalOption(name, prefix) ??
            $"{defaultValue:G}",
            ignoreCase: true,
            out var value) ? value : default;
    }

    public static int GetIntGlobalOption(
        this AnalyzerConfigOptionsProvider provider,
        string name,
        string? prefix = null,
        int defaultValue = 0)
    {
        provider = provider ?? throw new ArgumentNullException(nameof(provider));
        name = name ?? throw new ArgumentNullException(nameof(name));

        return int.TryParse(
            provider.GetGlobalOption(name, prefix),
            out var value) ? value : defaultValue;
    }

    public static IncrementalValueProvider<Settings> DetectSettings(
        this IncrementalGeneratorInitializationContext context)
    {
        return context.AnalyzerConfigOptionsProvider
            .Select((options, _) => options.GetSettings(prefix: "AutoSDK"));
    }
}
