//HintName: G.Models.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target language code to dub the audio to (e.g., "es" for Spanish, "fr" for French).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar")]
        Ar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bg")]
        Bg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cs")]
        Cs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="da")]
        Da,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de")]
        De,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="el")]
        El,
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
        [global::System.Runtime.Serialization.EnumMember(Value="fi")]
        Fi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fil")]
        Fil,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr")]
        Fr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hi")]
        Hi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hr")]
        Hr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
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
        [global::System.Runtime.Serialization.EnumMember(Value="ms")]
        Ms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl")]
        Nl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pl")]
        Pl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt")]
        Pt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ro")]
        Ro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ru")]
        Ru,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sk")]
        Sk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sv")]
        Sv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ta")]
        Ta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tr")]
        Tr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uk")]
        Uk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh")]
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang value)
        {
            return value switch
            {
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ar => "ar",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Bg => "bg",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Cs => "cs",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Da => "da",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.De => "de",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.El => "el",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.En => "en",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es => "es",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fi => "fi",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fil => "fil",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fr => "fr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hi => "hi",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hr => "hr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Id => "id",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.It => "it",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ja => "ja",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ko => "ko",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ms => "ms",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Nl => "nl",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pl => "pl",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pt => "pt",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ro => "ro",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ru => "ru",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sk => "sk",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sv => "sv",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ta => "ta",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Tr => "tr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Uk => "uk",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang? ToEnum(string value)
        {
            return value switch
            {
                "ar" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ar,
                "bg" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Bg,
                "cs" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Cs,
                "da" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Da,
                "de" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.De,
                "el" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.El,
                "en" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.En,
                "es" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es,
                "fi" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fi,
                "fil" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fil,
                "fr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fr,
                "hi" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hi,
                "hr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hr,
                "id" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Id,
                "it" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.It,
                "ja" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ja,
                "ko" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ko,
                "ms" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ms,
                "nl" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Nl,
                "pl" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pl,
                "pt" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pt,
                "ro" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ro,
                "ru" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ru,
                "sk" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sk,
                "sv" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sv,
                "ta" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ta,
                "tr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Tr,
                "uk" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Uk,
                "zh" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Zh,
                _ => null,
            };
        }
    }
}