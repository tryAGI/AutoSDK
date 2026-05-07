namespace AutoSDK.Models;

public record struct SchemaContextSettings(
    string Namespace,
    string ClsCompliantEnumPrefix,
    NamingConvention NamingConvention,
    string TargetFramework,
    string JsonSerializerContext,
    SdkFeatureUsage UseRequiredKeyword,
    SdkFeatureUsage UseExperimentalAttributes,
    SdkFeatureUsage UseSetsRequiredMembersAttributes,
    bool GenerateModelValidationMethods,
    bool ValidateAnyOfs,
    bool GenerateRawModelData,
    bool GenerateJsonSerializerContextTypes,
    bool UseNewtonsoftJson,
    bool UseSystemTextJson,
    bool UseExtensionNaming,
    ModelStyle ModelStyle,
    string NamespaceDelimiter,
    ExcludedModelNamespaceMode ExcludedModelNamespaceMode,
    IdentifierCharacterSet IdentifierCharacterSet = IdentifierCharacterSet.UnicodeLetters)
{
    public static SchemaContextSettings Default => new(
        Namespace: string.Empty,
        ClsCompliantEnumPrefix: string.Empty,
        NamingConvention: default,
        TargetFramework: string.Empty,
        JsonSerializerContext: string.Empty,
        UseRequiredKeyword: default,
        UseExperimentalAttributes: default,
        UseSetsRequiredMembersAttributes: default,
        GenerateModelValidationMethods: false,
        ValidateAnyOfs: false,
        GenerateRawModelData: false,
        GenerateJsonSerializerContextTypes: false,
        UseNewtonsoftJson: false,
        UseSystemTextJson: true,
        UseExtensionNaming: true,
        ModelStyle: default,
        NamespaceDelimiter: string.Empty,
        ExcludedModelNamespaceMode: ExcludedModelNamespaceMode.External,
        IdentifierCharacterSet: IdentifierCharacterSet.UnicodeLetters);
}
