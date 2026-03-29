//HintName: G.Models.LocalizeTargetLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Target language to localize the voice to.<br/>
    /// Options: English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalizeTargetLanguage
    {
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de")]
        De,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en")]
        En,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es")]
        Es,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr")]
        Fr,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hi")]
        Hi,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="it")]
        It,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ja")]
        Ja,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ko")]
        Ko,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl")]
        Nl,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pl")]
        Pl,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt")]
        Pt,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ru")]
        Ru,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sv")]
        Sv,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tr")]
        Tr,
        /// <summary>
        /// English (en), German (de), Spanish (es), French (fr), Japanese (ja), Portuguese (pt), Chinese (zh), Hindi (hi), Italian (it), Korean (ko), Dutch (nl), Polish (pl), Russian (ru), Swedish (sv), Turkish (tr).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh")]
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalizeTargetLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalizeTargetLanguage value)
        {
            return value switch
            {
                LocalizeTargetLanguage.De => "de",
                LocalizeTargetLanguage.En => "en",
                LocalizeTargetLanguage.Es => "es",
                LocalizeTargetLanguage.Fr => "fr",
                LocalizeTargetLanguage.Hi => "hi",
                LocalizeTargetLanguage.It => "it",
                LocalizeTargetLanguage.Ja => "ja",
                LocalizeTargetLanguage.Ko => "ko",
                LocalizeTargetLanguage.Nl => "nl",
                LocalizeTargetLanguage.Pl => "pl",
                LocalizeTargetLanguage.Pt => "pt",
                LocalizeTargetLanguage.Ru => "ru",
                LocalizeTargetLanguage.Sv => "sv",
                LocalizeTargetLanguage.Tr => "tr",
                LocalizeTargetLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalizeTargetLanguage? ToEnum(string value)
        {
            return value switch
            {
                "de" => LocalizeTargetLanguage.De,
                "en" => LocalizeTargetLanguage.En,
                "es" => LocalizeTargetLanguage.Es,
                "fr" => LocalizeTargetLanguage.Fr,
                "hi" => LocalizeTargetLanguage.Hi,
                "it" => LocalizeTargetLanguage.It,
                "ja" => LocalizeTargetLanguage.Ja,
                "ko" => LocalizeTargetLanguage.Ko,
                "nl" => LocalizeTargetLanguage.Nl,
                "pl" => LocalizeTargetLanguage.Pl,
                "pt" => LocalizeTargetLanguage.Pt,
                "ru" => LocalizeTargetLanguage.Ru,
                "sv" => LocalizeTargetLanguage.Sv,
                "tr" => LocalizeTargetLanguage.Tr,
                "zh" => LocalizeTargetLanguage.Zh,
                _ => null,
            };
        }
    }
}