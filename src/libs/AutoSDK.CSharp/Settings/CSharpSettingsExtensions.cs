using AutoSDK.Serialization.Json;

namespace AutoSDK.Models;

public static class CSharpSettingsExtensions
{
    public static bool UsesNewtonsoftJson(this Settings settings)
    {
        return settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson;
    }

    public static bool UsesNewtonsoftJson(this EmitterSettings settings)
    {
        return settings.UseNewtonsoftJson;
    }

    public static bool UsesNewtonsoftJson(this SchemaContextSettings settings)
    {
        return settings.UseNewtonsoftJson;
    }

    public static bool UsesSystemTextJson(this Settings settings)
    {
        return settings.JsonSerializerType == JsonSerializerType.SystemTextJson;
    }

    public static bool UsesSystemTextJson(this EmitterSettings settings)
    {
        return settings.UseSystemTextJson;
    }

    public static bool UsesSystemTextJson(this SchemaContextSettings settings)
    {
        return settings.UseSystemTextJson;
    }

    public static bool HasJsonSerializerContext(this Settings settings)
    {
        return !string.IsNullOrWhiteSpace(settings.JsonSerializerContext);
    }

    public static bool HasJsonSerializerContext(this EmitterSettings settings)
    {
        return !string.IsNullOrWhiteSpace(settings.JsonSerializerContext);
    }

    public static bool HasJsonSerializerContext(this SchemaContextSettings settings)
    {
        return !string.IsNullOrWhiteSpace(settings.JsonSerializerContext);
    }

    public static bool UsesSystemTextJsonContext(this Settings settings)
    {
        return settings.UsesSystemTextJson() &&
               (settings.HasJsonSerializerContext() || settings.GenerateJsonSerializerContextTypes);
    }

    public static bool UsesSystemTextJsonContext(this EmitterSettings settings)
    {
        return settings.UsesSystemTextJson() &&
               (settings.HasJsonSerializerContext() || settings.GenerateJsonSerializerContextTypes);
    }

    public static bool UsesSystemTextJsonContext(this SchemaContextSettings settings)
    {
        return settings.UsesSystemTextJson() &&
               (settings.HasJsonSerializerContext() || settings.GenerateJsonSerializerContextTypes);
    }

    public static bool ShouldGenerateJsonSerializerContextTypes(this Settings settings)
    {
        return settings.GenerateJsonSerializerContextTypes && settings.UsesSystemTextJson();
    }

    public static bool ShouldGenerateJsonSerializerContextTypes(this EmitterSettings settings)
    {
        return settings.GenerateJsonSerializerContextTypes && settings.UsesSystemTextJson();
    }

    public static bool UsesNewtonsoftJson(this CSharpSettings settings)
    {
        return settings.JsonSerializerType == CSharpJsonSerializerType.NewtonsoftJson;
    }

    public static bool UsesSystemTextJson(this CSharpSettings settings)
    {
        return settings.JsonSerializerType == CSharpJsonSerializerType.SystemTextJson;
    }

    public static bool HasJsonSerializerContext(this CSharpSettings settings)
    {
        return !string.IsNullOrWhiteSpace(settings.JsonSerializerContext);
    }

    public static bool UsesSystemTextJsonContext(this CSharpSettings settings)
    {
        return settings.UsesSystemTextJson() &&
               (settings.HasJsonSerializerContext() || settings.GenerateJsonSerializerContextTypes);
    }

    public static bool ShouldGenerateJsonSerializerContextTypes(this CSharpSettings settings)
    {
        return settings.GenerateJsonSerializerContextTypes && settings.UsesSystemTextJson();
    }

    public static CoreSettings ToCoreSettings(this CSharpSettings settings)
    {
        return new CoreSettings(
            IgnoreOpenApiErrors: settings.IgnoreOpenApiErrors,
            IgnoreOpenApiWarnings: settings.IgnoreOpenApiWarnings,
            BaseUrl: settings.BaseUrl,
            SecuritySchemes: settings.SecuritySchemes,
            ComputeDiscriminators: settings.ComputeDiscriminators,
            AddMissingPathParameters: settings.AddMissingPathParameters,
            OpenApiOverrides: settings.OpenApiOverrides,
            UseExtensionNaming: settings.UseExtensionNaming);
    }

    public static EmitterSettings ToEmitterSettings(this CSharpSettings settings)
    {
        return new EmitterSettings(
            Namespace: settings.Namespace,
            NamingConvention: settings.NamingConvention,
            TargetFramework: settings.TargetFramework,
            JsonSerializerContext: settings.JsonSerializerContext,
            UseRequiredKeyword: settings.UseRequiredKeyword,
            UseExperimentalAttributes: settings.UseExperimentalAttributes,
            UseSetsRequiredMembersAttributes: settings.UseSetsRequiredMembersAttributes,
            GenerateModelValidationMethods: settings.GenerateModelValidationMethods,
            ValidateAnyOfs: settings.ValidateAnyOfs,
            GenerateJsonSerializerContextTypes: settings.GenerateJsonSerializerContextTypes,
            UseNewtonsoftJson: settings.UsesNewtonsoftJson(),
            UseSystemTextJson: settings.UsesSystemTextJson());
    }

    public static SchemaNamingSettings ToSchemaNamingSettings(this CSharpSettings settings)
    {
        return new SchemaNamingSettings(
            clsCompliantEnumPrefix: settings.ClsCompliantEnumPrefix,
            useExtensionNaming: settings.UseExtensionNaming,
            namespaceDelimiter: settings.NamespaceDelimiter,
            identifierCharacterSet: settings.IdentifierCharacterSet);
    }

    public static SchemaContextSettings ToSchemaContextSettings(this CSharpSettings settings)
    {
        return new SchemaContextSettings(
            Namespace: settings.Namespace,
            ClsCompliantEnumPrefix: settings.ClsCompliantEnumPrefix,
            NamingConvention: settings.NamingConvention,
            TargetFramework: settings.TargetFramework,
            JsonSerializerContext: settings.JsonSerializerContext,
            UseRequiredKeyword: settings.UseRequiredKeyword,
            UseExperimentalAttributes: settings.UseExperimentalAttributes,
            UseSetsRequiredMembersAttributes: settings.UseSetsRequiredMembersAttributes,
            GenerateModelValidationMethods: settings.GenerateModelValidationMethods,
            ValidateAnyOfs: settings.ValidateAnyOfs,
            GenerateJsonSerializerContextTypes: settings.GenerateJsonSerializerContextTypes,
            UseNewtonsoftJson: settings.UsesNewtonsoftJson(),
            UseSystemTextJson: settings.UsesSystemTextJson(),
            UseExtensionNaming: settings.UseExtensionNaming,
            ModelStyle: settings.ModelStyle,
            NamespaceDelimiter: settings.NamespaceDelimiter,
            ExcludedModelNamespaceMode: settings.ExcludedModelNamespaceMode,
            IdentifierCharacterSet: settings.IdentifierCharacterSet);
    }

    public static EnumNamingSettings ToEnumNamingSettings(this CSharpSettings settings)
    {
        return new EnumNamingSettings(
            clsCompliantEnumPrefix: settings.ClsCompliantEnumPrefix,
            identifierCharacterSet: settings.IdentifierCharacterSet);
    }
}
