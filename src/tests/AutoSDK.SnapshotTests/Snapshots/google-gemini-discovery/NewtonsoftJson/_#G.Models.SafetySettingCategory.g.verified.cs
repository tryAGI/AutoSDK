//HintName: G.Models.SafetySettingCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. The category for this setting.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SafetySettingCategory
    {
        /// <summary>
        /// **Gemini** - Content that may be used to harm civic integrity. DEPRECATED: use enable_enhanced_civic_answers instead.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_CIVIC_INTEGRITY")]
        HarmCategoryCivicIntegrity,
        /// <summary>
        /// **PaLM** - Dangerous content that promotes, facilitates, or encourages harmful acts.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_DANGEROUS")]
        HarmCategoryDangerous,
        /// <summary>
        /// **Gemini** - Dangerous content.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_DANGEROUS_CONTENT")]
        HarmCategoryDangerousContent,
        /// <summary>
        /// **PaLM** - Negative or harmful comments targeting identity and/or protected attribute.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_DEROGATORY")]
        HarmCategoryDerogatory,
        /// <summary>
        /// **Gemini** - Harassment content.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_HARASSMENT")]
        HarmCategoryHarassment,
        /// <summary>
        /// **Gemini** - Hate speech and content.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_HATE_SPEECH")]
        HarmCategoryHateSpeech,
        /// <summary>
        /// **PaLM** - Promotes unchecked medical advice.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_MEDICAL")]
        HarmCategoryMedical,
        /// <summary>
        /// **PaLM** - Contains references to sexual acts or other lewd content.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_SEXUAL")]
        HarmCategorySexual,
        /// <summary>
        /// **Gemini** - Sexually explicit content.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_SEXUALLY_EXPLICIT")]
        HarmCategorySexuallyExplicit,
        /// <summary>
        /// **PaLM** - Content that is rude, disrespectful, or profane.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_TOXICITY")]
        HarmCategoryToxicity,
        /// <summary>
        /// Category is unspecified.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_UNSPECIFIED")]
        HarmCategoryUnspecified,
        /// <summary>
        /// **PaLM** - Describes scenarios depicting violence against an individual or group, or general descriptions of gore.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_VIOLENCE")]
        HarmCategoryViolence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SafetySettingCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetySettingCategory value)
        {
            return value switch
            {
                SafetySettingCategory.HarmCategoryCivicIntegrity => "HARM_CATEGORY_CIVIC_INTEGRITY",
                SafetySettingCategory.HarmCategoryDangerous => "HARM_CATEGORY_DANGEROUS",
                SafetySettingCategory.HarmCategoryDangerousContent => "HARM_CATEGORY_DANGEROUS_CONTENT",
                SafetySettingCategory.HarmCategoryDerogatory => "HARM_CATEGORY_DEROGATORY",
                SafetySettingCategory.HarmCategoryHarassment => "HARM_CATEGORY_HARASSMENT",
                SafetySettingCategory.HarmCategoryHateSpeech => "HARM_CATEGORY_HATE_SPEECH",
                SafetySettingCategory.HarmCategoryMedical => "HARM_CATEGORY_MEDICAL",
                SafetySettingCategory.HarmCategorySexual => "HARM_CATEGORY_SEXUAL",
                SafetySettingCategory.HarmCategorySexuallyExplicit => "HARM_CATEGORY_SEXUALLY_EXPLICIT",
                SafetySettingCategory.HarmCategoryToxicity => "HARM_CATEGORY_TOXICITY",
                SafetySettingCategory.HarmCategoryUnspecified => "HARM_CATEGORY_UNSPECIFIED",
                SafetySettingCategory.HarmCategoryViolence => "HARM_CATEGORY_VIOLENCE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetySettingCategory? ToEnum(string value)
        {
            return value switch
            {
                "HARM_CATEGORY_CIVIC_INTEGRITY" => SafetySettingCategory.HarmCategoryCivicIntegrity,
                "HARM_CATEGORY_DANGEROUS" => SafetySettingCategory.HarmCategoryDangerous,
                "HARM_CATEGORY_DANGEROUS_CONTENT" => SafetySettingCategory.HarmCategoryDangerousContent,
                "HARM_CATEGORY_DEROGATORY" => SafetySettingCategory.HarmCategoryDerogatory,
                "HARM_CATEGORY_HARASSMENT" => SafetySettingCategory.HarmCategoryHarassment,
                "HARM_CATEGORY_HATE_SPEECH" => SafetySettingCategory.HarmCategoryHateSpeech,
                "HARM_CATEGORY_MEDICAL" => SafetySettingCategory.HarmCategoryMedical,
                "HARM_CATEGORY_SEXUAL" => SafetySettingCategory.HarmCategorySexual,
                "HARM_CATEGORY_SEXUALLY_EXPLICIT" => SafetySettingCategory.HarmCategorySexuallyExplicit,
                "HARM_CATEGORY_TOXICITY" => SafetySettingCategory.HarmCategoryToxicity,
                "HARM_CATEGORY_UNSPECIFIED" => SafetySettingCategory.HarmCategoryUnspecified,
                "HARM_CATEGORY_VIOLENCE" => SafetySettingCategory.HarmCategoryViolence,
                _ => null,
            };
        }
    }
}