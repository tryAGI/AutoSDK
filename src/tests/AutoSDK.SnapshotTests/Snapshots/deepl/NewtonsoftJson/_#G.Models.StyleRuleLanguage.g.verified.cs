//HintName: G.Models.StyleRuleLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language that the style rules are applied to.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StyleRuleLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de")]
        De,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en")]
        En,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es")]
        Es,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr")]
        Fr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="it")]
        It,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ja")]
        Ja,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ko")]
        Ko,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh")]
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