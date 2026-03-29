//HintName: G.Models.SafetyRatingCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. The category for this rating.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SafetyRatingCategory
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
    public static class SafetyRatingCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetyRatingCategory value)
        {
            return value switch
            {
                SafetyRatingCategory.HarmCategoryCivicIntegrity => "HARM_CATEGORY_CIVIC_INTEGRITY",
                SafetyRatingCategory.HarmCategoryDangerous => "HARM_CATEGORY_DANGEROUS",
                SafetyRatingCategory.HarmCategoryDangerousContent => "HARM_CATEGORY_DANGEROUS_CONTENT",
                SafetyRatingCategory.HarmCategoryDerogatory => "HARM_CATEGORY_DEROGATORY",
                SafetyRatingCategory.HarmCategoryHarassment => "HARM_CATEGORY_HARASSMENT",
                SafetyRatingCategory.HarmCategoryHateSpeech => "HARM_CATEGORY_HATE_SPEECH",
                SafetyRatingCategory.HarmCategoryMedical => "HARM_CATEGORY_MEDICAL",
                SafetyRatingCategory.HarmCategorySexual => "HARM_CATEGORY_SEXUAL",
                SafetyRatingCategory.HarmCategorySexuallyExplicit => "HARM_CATEGORY_SEXUALLY_EXPLICIT",
                SafetyRatingCategory.HarmCategoryToxicity => "HARM_CATEGORY_TOXICITY",
                SafetyRatingCategory.HarmCategoryUnspecified => "HARM_CATEGORY_UNSPECIFIED",
                SafetyRatingCategory.HarmCategoryViolence => "HARM_CATEGORY_VIOLENCE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetyRatingCategory? ToEnum(string value)
        {
            return value switch
            {
                "HARM_CATEGORY_CIVIC_INTEGRITY" => SafetyRatingCategory.HarmCategoryCivicIntegrity,
                "HARM_CATEGORY_DANGEROUS" => SafetyRatingCategory.HarmCategoryDangerous,
                "HARM_CATEGORY_DANGEROUS_CONTENT" => SafetyRatingCategory.HarmCategoryDangerousContent,
                "HARM_CATEGORY_DEROGATORY" => SafetyRatingCategory.HarmCategoryDerogatory,
                "HARM_CATEGORY_HARASSMENT" => SafetyRatingCategory.HarmCategoryHarassment,
                "HARM_CATEGORY_HATE_SPEECH" => SafetyRatingCategory.HarmCategoryHateSpeech,
                "HARM_CATEGORY_MEDICAL" => SafetyRatingCategory.HarmCategoryMedical,
                "HARM_CATEGORY_SEXUAL" => SafetyRatingCategory.HarmCategorySexual,
                "HARM_CATEGORY_SEXUALLY_EXPLICIT" => SafetyRatingCategory.HarmCategorySexuallyExplicit,
                "HARM_CATEGORY_TOXICITY" => SafetyRatingCategory.HarmCategoryToxicity,
                "HARM_CATEGORY_UNSPECIFIED" => SafetyRatingCategory.HarmCategoryUnspecified,
                "HARM_CATEGORY_VIOLENCE" => SafetyRatingCategory.HarmCategoryViolence,
                _ => null,
            };
        }
    }
}