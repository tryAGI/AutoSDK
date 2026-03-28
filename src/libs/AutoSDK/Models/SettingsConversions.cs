namespace AutoSDK.Models;

public static class SettingsConversions
{
    public static CoreSettings ToCoreSettings(this Settings settings)
    {
        return new CoreSettings(
            IgnoreOpenApiErrors: settings.IgnoreOpenApiErrors,
            IgnoreOpenApiWarnings: settings.IgnoreOpenApiWarnings,
            BaseUrl: settings.BaseUrl,
            SecuritySchemes: settings.SecuritySchemes,
            ComputeDiscriminators: settings.ComputeDiscriminators,
            AddMissingPathParameters: settings.AddMissingPathParameters,
            OpenApiOverrides: settings.OpenApiOverrides);
    }

    public static EmitterSettings ToEmitterSettings(this Settings settings)
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
            UseNewtonsoftJson: settings.JsonSerializerType == Serialization.Json.JsonSerializerType.NewtonsoftJson,
            UseSystemTextJson: settings.JsonSerializerType == Serialization.Json.JsonSerializerType.SystemTextJson);
    }

    public static EnumNamingSettings ToEnumNamingSettings(this Settings settings)
    {
        return new EnumNamingSettings(settings.ClsCompliantEnumPrefix);
    }

    public static EnumNamingSettings ToEnumNamingSettings(this SchemaContextSettings settings)
    {
        return new EnumNamingSettings(settings.ClsCompliantEnumPrefix);
    }

    public static SchemaNamingSettings ToSchemaNamingSettings(this Settings settings)
    {
        return new SchemaNamingSettings(
            clsCompliantEnumPrefix: settings.ClsCompliantEnumPrefix,
            useExtensionNaming: settings.UseExtensionNaming,
            namespaceDelimiter: settings.NamespaceDelimiter);
    }

    public static SchemaNamingSettings ToSchemaNamingSettings(this SchemaContextSettings settings)
    {
        return new SchemaNamingSettings(
            clsCompliantEnumPrefix: settings.ClsCompliantEnumPrefix,
            useExtensionNaming: settings.UseExtensionNaming,
            namespaceDelimiter: settings.NamespaceDelimiter);
    }

    public static SchemaContextSettings ToSchemaContextSettings(this Settings settings)
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
            UseNewtonsoftJson: settings.JsonSerializerType == Serialization.Json.JsonSerializerType.NewtonsoftJson,
            UseSystemTextJson: settings.JsonSerializerType == Serialization.Json.JsonSerializerType.SystemTextJson,
            UseExtensionNaming: settings.UseExtensionNaming,
            ModelStyle: settings.ModelStyle,
            NamespaceDelimiter: settings.NamespaceDelimiter,
            ExcludedModelNamespaceMode: settings.ExcludedModelNamespaceMode);
    }

    public static EmitterSettings ToEmitterSettings(this SchemaContextSettings settings)
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
            UseNewtonsoftJson: settings.UseNewtonsoftJson,
            UseSystemTextJson: settings.UseSystemTextJson);
    }
}
