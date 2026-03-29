//HintName: G.Models.StyleRuleLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language that the style rules are applied to.
    /// </summary>
    public enum StyleRuleLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StyleRuleLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StyleRuleLanguage value)
        {
            return value switch
            {
                StyleRuleLanguage.De => "de",
                StyleRuleLanguage.En => "en",
                StyleRuleLanguage.Es => "es",
                StyleRuleLanguage.Fr => "fr",
                StyleRuleLanguage.It => "it",
                StyleRuleLanguage.Ja => "ja",
                StyleRuleLanguage.Ko => "ko",
                StyleRuleLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StyleRuleLanguage? ToEnum(string value)
        {
            return value switch
            {
                "de" => StyleRuleLanguage.De,
                "en" => StyleRuleLanguage.En,
                "es" => StyleRuleLanguage.Es,
                "fr" => StyleRuleLanguage.Fr,
                "it" => StyleRuleLanguage.It,
                "ja" => StyleRuleLanguage.Ja,
                "ko" => StyleRuleLanguage.Ko,
                "zh" => StyleRuleLanguage.Zh,
                _ => null,
            };
        }
    }
}