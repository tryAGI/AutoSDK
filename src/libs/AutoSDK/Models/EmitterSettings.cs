namespace AutoSDK.Models;

public record struct EmitterSettings(
    string Namespace,
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
    bool UseSystemTextJson)
{
    public static EmitterSettings Default => new(
        Namespace: string.Empty,
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
        UseSystemTextJson: true);
}
