﻿//HintName: G.Models.SafetyRatingCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. The category for this rating.
    /// </summary>
    public enum SafetyRatingCategory
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
    public static class SafetyRatingCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetyRatingCategory value)
        {
            return value switch
            {
                SafetyRatingCategory.HARMCATEGORYUNSPECIFIED => "HARM_CATEGORY_UNSPECIFIED",
                SafetyRatingCategory.HARMCATEGORYDEROGATORY => "HARM_CATEGORY_DEROGATORY",
                SafetyRatingCategory.HARMCATEGORYTOXICITY => "HARM_CATEGORY_TOXICITY",
                SafetyRatingCategory.HARMCATEGORYVIOLENCE => "HARM_CATEGORY_VIOLENCE",
                SafetyRatingCategory.HARMCATEGORYSEXUAL => "HARM_CATEGORY_SEXUAL",
                SafetyRatingCategory.HARMCATEGORYMEDICAL => "HARM_CATEGORY_MEDICAL",
                SafetyRatingCategory.HARMCATEGORYDANGEROUS => "HARM_CATEGORY_DANGEROUS",
                SafetyRatingCategory.HARMCATEGORYHARASSMENT => "HARM_CATEGORY_HARASSMENT",
                SafetyRatingCategory.HARMCATEGORYHATESPEECH => "HARM_CATEGORY_HATE_SPEECH",
                SafetyRatingCategory.HARMCATEGORYSEXUALLYEXPLICIT => "HARM_CATEGORY_SEXUALLY_EXPLICIT",
                SafetyRatingCategory.HARMCATEGORYDANGEROUSCONTENT => "HARM_CATEGORY_DANGEROUS_CONTENT",
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
                "HARM_CATEGORY_UNSPECIFIED" => SafetyRatingCategory.HARMCATEGORYUNSPECIFIED,
                "HARM_CATEGORY_DEROGATORY" => SafetyRatingCategory.HARMCATEGORYDEROGATORY,
                "HARM_CATEGORY_TOXICITY" => SafetyRatingCategory.HARMCATEGORYTOXICITY,
                "HARM_CATEGORY_VIOLENCE" => SafetyRatingCategory.HARMCATEGORYVIOLENCE,
                "HARM_CATEGORY_SEXUAL" => SafetyRatingCategory.HARMCATEGORYSEXUAL,
                "HARM_CATEGORY_MEDICAL" => SafetyRatingCategory.HARMCATEGORYMEDICAL,
                "HARM_CATEGORY_DANGEROUS" => SafetyRatingCategory.HARMCATEGORYDANGEROUS,
                "HARM_CATEGORY_HARASSMENT" => SafetyRatingCategory.HARMCATEGORYHARASSMENT,
                "HARM_CATEGORY_HATE_SPEECH" => SafetyRatingCategory.HARMCATEGORYHATESPEECH,
                "HARM_CATEGORY_SEXUALLY_EXPLICIT" => SafetyRatingCategory.HARMCATEGORYSEXUALLYEXPLICIT,
                "HARM_CATEGORY_DANGEROUS_CONTENT" => SafetyRatingCategory.HARMCATEGORYDANGEROUSCONTENT,
                _ => null,
            };
        }
    }
}