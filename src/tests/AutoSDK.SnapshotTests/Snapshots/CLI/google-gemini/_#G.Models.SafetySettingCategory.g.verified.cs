//HintName: G.Models.SafetySettingCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. The category for this setting.
    /// </summary>
    public enum SafetySettingCategory
    {
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYDEROGATORY,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYTOXICITY,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYVIOLENCE,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYSEXUAL,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYMEDICAL,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYDANGEROUS,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYHARASSMENT,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYHATESPEECH,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYSEXUALLYEXPLICIT,
        /// <summary>
        /// 
        /// </summary>
        HARMCATEGORYDANGEROUSCONTENT,
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
                SafetySettingCategory.HARMCATEGORYUNSPECIFIED => "HARM_CATEGORY_UNSPECIFIED",
                SafetySettingCategory.HARMCATEGORYDEROGATORY => "HARM_CATEGORY_DEROGATORY",
                SafetySettingCategory.HARMCATEGORYTOXICITY => "HARM_CATEGORY_TOXICITY",
                SafetySettingCategory.HARMCATEGORYVIOLENCE => "HARM_CATEGORY_VIOLENCE",
                SafetySettingCategory.HARMCATEGORYSEXUAL => "HARM_CATEGORY_SEXUAL",
                SafetySettingCategory.HARMCATEGORYMEDICAL => "HARM_CATEGORY_MEDICAL",
                SafetySettingCategory.HARMCATEGORYDANGEROUS => "HARM_CATEGORY_DANGEROUS",
                SafetySettingCategory.HARMCATEGORYHARASSMENT => "HARM_CATEGORY_HARASSMENT",
                SafetySettingCategory.HARMCATEGORYHATESPEECH => "HARM_CATEGORY_HATE_SPEECH",
                SafetySettingCategory.HARMCATEGORYSEXUALLYEXPLICIT => "HARM_CATEGORY_SEXUALLY_EXPLICIT",
                SafetySettingCategory.HARMCATEGORYDANGEROUSCONTENT => "HARM_CATEGORY_DANGEROUS_CONTENT",
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
                "HARM_CATEGORY_UNSPECIFIED" => SafetySettingCategory.HARMCATEGORYUNSPECIFIED,
                "HARM_CATEGORY_DEROGATORY" => SafetySettingCategory.HARMCATEGORYDEROGATORY,
                "HARM_CATEGORY_TOXICITY" => SafetySettingCategory.HARMCATEGORYTOXICITY,
                "HARM_CATEGORY_VIOLENCE" => SafetySettingCategory.HARMCATEGORYVIOLENCE,
                "HARM_CATEGORY_SEXUAL" => SafetySettingCategory.HARMCATEGORYSEXUAL,
                "HARM_CATEGORY_MEDICAL" => SafetySettingCategory.HARMCATEGORYMEDICAL,
                "HARM_CATEGORY_DANGEROUS" => SafetySettingCategory.HARMCATEGORYDANGEROUS,
                "HARM_CATEGORY_HARASSMENT" => SafetySettingCategory.HARMCATEGORYHARASSMENT,
                "HARM_CATEGORY_HATE_SPEECH" => SafetySettingCategory.HARMCATEGORYHATESPEECH,
                "HARM_CATEGORY_SEXUALLY_EXPLICIT" => SafetySettingCategory.HARMCATEGORYSEXUALLYEXPLICIT,
                "HARM_CATEGORY_DANGEROUS_CONTENT" => SafetySettingCategory.HARMCATEGORYDANGEROUSCONTENT,
                _ => null,
            };
        }
    }
}