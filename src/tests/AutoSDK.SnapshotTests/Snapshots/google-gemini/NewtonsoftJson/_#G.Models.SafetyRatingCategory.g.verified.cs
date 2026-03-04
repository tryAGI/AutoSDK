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
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_UNSPECIFIED")]
        HarmCategoryUnspecified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_DEROGATORY")]
        HarmCategoryDerogatory,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_TOXICITY")]
        HarmCategoryToxicity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_VIOLENCE")]
        HarmCategoryViolence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_SEXUAL")]
        HarmCategorySexual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_MEDICAL")]
        HarmCategoryMedical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_DANGEROUS")]
        HarmCategoryDangerous,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_HARASSMENT")]
        HarmCategoryHarassment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_HATE_SPEECH")]
        HarmCategoryHateSpeech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_SEXUALLY_EXPLICIT")]
        HarmCategorySexuallyExplicit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HARM_CATEGORY_DANGEROUS_CONTENT")]
        HarmCategoryDangerousContent,
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
                SafetyRatingCategory.HarmCategoryUnspecified => "HARM_CATEGORY_UNSPECIFIED",
                SafetyRatingCategory.HarmCategoryDerogatory => "HARM_CATEGORY_DEROGATORY",
                SafetyRatingCategory.HarmCategoryToxicity => "HARM_CATEGORY_TOXICITY",
                SafetyRatingCategory.HarmCategoryViolence => "HARM_CATEGORY_VIOLENCE",
                SafetyRatingCategory.HarmCategorySexual => "HARM_CATEGORY_SEXUAL",
                SafetyRatingCategory.HarmCategoryMedical => "HARM_CATEGORY_MEDICAL",
                SafetyRatingCategory.HarmCategoryDangerous => "HARM_CATEGORY_DANGEROUS",
                SafetyRatingCategory.HarmCategoryHarassment => "HARM_CATEGORY_HARASSMENT",
                SafetyRatingCategory.HarmCategoryHateSpeech => "HARM_CATEGORY_HATE_SPEECH",
                SafetyRatingCategory.HarmCategorySexuallyExplicit => "HARM_CATEGORY_SEXUALLY_EXPLICIT",
                SafetyRatingCategory.HarmCategoryDangerousContent => "HARM_CATEGORY_DANGEROUS_CONTENT",
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
                "HARM_CATEGORY_UNSPECIFIED" => SafetyRatingCategory.HarmCategoryUnspecified,
                "HARM_CATEGORY_DEROGATORY" => SafetyRatingCategory.HarmCategoryDerogatory,
                "HARM_CATEGORY_TOXICITY" => SafetyRatingCategory.HarmCategoryToxicity,
                "HARM_CATEGORY_VIOLENCE" => SafetyRatingCategory.HarmCategoryViolence,
                "HARM_CATEGORY_SEXUAL" => SafetyRatingCategory.HarmCategorySexual,
                "HARM_CATEGORY_MEDICAL" => SafetyRatingCategory.HarmCategoryMedical,
                "HARM_CATEGORY_DANGEROUS" => SafetyRatingCategory.HarmCategoryDangerous,
                "HARM_CATEGORY_HARASSMENT" => SafetyRatingCategory.HarmCategoryHarassment,
                "HARM_CATEGORY_HATE_SPEECH" => SafetyRatingCategory.HarmCategoryHateSpeech,
                "HARM_CATEGORY_SEXUALLY_EXPLICIT" => SafetyRatingCategory.HarmCategorySexuallyExplicit,
                "HARM_CATEGORY_DANGEROUS_CONTENT" => SafetyRatingCategory.HarmCategoryDangerousContent,
                _ => null,
            };
        }
    }
}