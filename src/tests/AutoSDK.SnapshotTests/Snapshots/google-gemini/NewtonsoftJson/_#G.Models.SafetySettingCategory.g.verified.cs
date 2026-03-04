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
    public static class SafetySettingCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetySettingCategory value)
        {
            return value switch
            {
                SafetySettingCategory.HarmCategoryUnspecified => "HARM_CATEGORY_UNSPECIFIED",
                SafetySettingCategory.HarmCategoryDerogatory => "HARM_CATEGORY_DEROGATORY",
                SafetySettingCategory.HarmCategoryToxicity => "HARM_CATEGORY_TOXICITY",
                SafetySettingCategory.HarmCategoryViolence => "HARM_CATEGORY_VIOLENCE",
                SafetySettingCategory.HarmCategorySexual => "HARM_CATEGORY_SEXUAL",
                SafetySettingCategory.HarmCategoryMedical => "HARM_CATEGORY_MEDICAL",
                SafetySettingCategory.HarmCategoryDangerous => "HARM_CATEGORY_DANGEROUS",
                SafetySettingCategory.HarmCategoryHarassment => "HARM_CATEGORY_HARASSMENT",
                SafetySettingCategory.HarmCategoryHateSpeech => "HARM_CATEGORY_HATE_SPEECH",
                SafetySettingCategory.HarmCategorySexuallyExplicit => "HARM_CATEGORY_SEXUALLY_EXPLICIT",
                SafetySettingCategory.HarmCategoryDangerousContent => "HARM_CATEGORY_DANGEROUS_CONTENT",
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
                "HARM_CATEGORY_UNSPECIFIED" => SafetySettingCategory.HarmCategoryUnspecified,
                "HARM_CATEGORY_DEROGATORY" => SafetySettingCategory.HarmCategoryDerogatory,
                "HARM_CATEGORY_TOXICITY" => SafetySettingCategory.HarmCategoryToxicity,
                "HARM_CATEGORY_VIOLENCE" => SafetySettingCategory.HarmCategoryViolence,
                "HARM_CATEGORY_SEXUAL" => SafetySettingCategory.HarmCategorySexual,
                "HARM_CATEGORY_MEDICAL" => SafetySettingCategory.HarmCategoryMedical,
                "HARM_CATEGORY_DANGEROUS" => SafetySettingCategory.HarmCategoryDangerous,
                "HARM_CATEGORY_HARASSMENT" => SafetySettingCategory.HarmCategoryHarassment,
                "HARM_CATEGORY_HATE_SPEECH" => SafetySettingCategory.HarmCategoryHateSpeech,
                "HARM_CATEGORY_SEXUALLY_EXPLICIT" => SafetySettingCategory.HarmCategorySexuallyExplicit,
                "HARM_CATEGORY_DANGEROUS_CONTENT" => SafetySettingCategory.HarmCategoryDangerousContent,
                _ => null,
            };
        }
    }
}