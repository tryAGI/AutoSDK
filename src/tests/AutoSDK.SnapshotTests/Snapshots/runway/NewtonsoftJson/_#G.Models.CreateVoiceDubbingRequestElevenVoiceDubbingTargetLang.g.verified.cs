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
        [global::System.Runtime.Serialization.EnumMember(Value="en")]
        En,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hi")]
        Hi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt")]
        Pt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh")]
        Zh,
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
        [global::System.Runtime.Serialization.EnumMember(Value="de")]
        De,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ja")]
        Ja,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar")]
        Ar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ru")]
        Ru,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ko")]
        Ko,
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
        [global::System.Runtime.Serialization.EnumMember(Value="nl")]
        Nl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tr")]
        Tr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pl")]
        Pl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sv")]
        Sv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fil")]
        Fil,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ms")]
        Ms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ro")]
        Ro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uk")]
        Uk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="el")]
        El,
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
        [global::System.Runtime.Serialization.EnumMember(Value="fi")]
        Fi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bg")]
        Bg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hr")]
        Hr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sk")]
        Sk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ta")]
        Ta,
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
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.En => "en",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hi => "hi",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pt => "pt",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Zh => "zh",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es => "es",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fr => "fr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.De => "de",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ja => "ja",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ar => "ar",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ru => "ru",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ko => "ko",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Id => "id",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.It => "it",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Nl => "nl",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Tr => "tr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pl => "pl",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sv => "sv",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fil => "fil",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ms => "ms",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ro => "ro",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Uk => "uk",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.El => "el",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Cs => "cs",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Da => "da",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fi => "fi",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Bg => "bg",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hr => "hr",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sk => "sk",
                CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ta => "ta",
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
                "en" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.En,
                "hi" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hi,
                "pt" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pt,
                "zh" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Zh,
                "es" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es,
                "fr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fr,
                "de" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.De,
                "ja" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ja,
                "ar" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ar,
                "ru" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ru,
                "ko" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ko,
                "id" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Id,
                "it" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.It,
                "nl" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Nl,
                "tr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Tr,
                "pl" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Pl,
                "sv" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sv,
                "fil" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fil,
                "ms" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ms,
                "ro" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ro,
                "uk" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Uk,
                "el" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.El,
                "cs" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Cs,
                "da" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Da,
                "fi" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Fi,
                "bg" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Bg,
                "hr" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Hr,
                "sk" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Sk,
                "ta" => CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Ta,
                _ => null,
            };
        }
    }
}