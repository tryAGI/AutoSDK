//HintName: G.Models.LanguageIdentificationConfigLowConfidenceAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Action to take if all of the predicted languages are below the confidence threshold
    /// </summary>
    public enum LanguageIdentificationConfigLowConfidenceAction
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Reject,
        /// <summary>
        /// 
        /// </summary>
        UseDefaultLanguage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageIdentificationConfigLowConfidenceActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageIdentificationConfigLowConfidenceAction value)
        {
            return value switch
            {
                LanguageIdentificationConfigLowConfidenceAction.Allow => "allow",
                LanguageIdentificationConfigLowConfidenceAction.Reject => "reject",
                LanguageIdentificationConfigLowConfidenceAction.UseDefaultLanguage => "use_default_language",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageIdentificationConfigLowConfidenceAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => LanguageIdentificationConfigLowConfidenceAction.Allow,
                "reject" => LanguageIdentificationConfigLowConfidenceAction.Reject,
                "use_default_language" => LanguageIdentificationConfigLowConfidenceAction.UseDefaultLanguage,
                _ => null,
            };
        }
    }
}