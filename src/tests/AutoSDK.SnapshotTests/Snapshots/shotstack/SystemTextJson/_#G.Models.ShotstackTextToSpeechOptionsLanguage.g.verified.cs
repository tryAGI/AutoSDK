//HintName: G.Models.ShotstackTextToSpeechOptionsLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language code for the text-to-speech conversion. You must pair the correct language with the correct voice (see voice parameter above).<br/>
    /// Select a language from the list of available languages: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`cmn-CN`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`da-DK`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`de-DE`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`en-AU`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`en-GB`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`en-IN`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`en-US`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`es-ES`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`es-MX`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`es-US`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fr-CA`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fr-FR`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`it-IT`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`ja-JP`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`hi-IN`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`ko-KR`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`nb-NO`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`nl-NL`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`pl-PL`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`pt-BR`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`pt-PT`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`sv-SE`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`en-NZ`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`en-ZA`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`ca-ES`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`de-AT`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`yue-CN`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`ar-AE`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fi-FI`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Default Value: en-US
    /// </summary>
    public enum ShotstackTextToSpeechOptionsLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        ArAe,
        /// <summary>
        /// 
        /// </summary>
        CaEs,
        /// <summary>
        /// 
        /// </summary>
        CmnCn,
        /// <summary>
        /// 
        /// </summary>
        DaDk,
        /// <summary>
        /// 
        /// </summary>
        DeAt,
        /// <summary>
        /// 
        /// </summary>
        DeDe,
        /// <summary>
        /// 
        /// </summary>
        EnAu,
        /// <summary>
        /// 
        /// </summary>
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        EnIn,
        /// <summary>
        /// 
        /// </summary>
        EnNz,
        /// <summary>
        /// 
        /// </summary>
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        EnZa,
        /// <summary>
        /// 
        /// </summary>
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        EsMx,
        /// <summary>
        /// 
        /// </summary>
        EsUs,
        /// <summary>
        /// 
        /// </summary>
        FiFi,
        /// <summary>
        /// 
        /// </summary>
        FrCa,
        /// <summary>
        /// 
        /// </summary>
        FrFr,
        /// <summary>
        /// 
        /// </summary>
        HiIn,
        /// <summary>
        /// 
        /// </summary>
        ItIt,
        /// <summary>
        /// 
        /// </summary>
        JaJp,
        /// <summary>
        /// 
        /// </summary>
        KoKr,
        /// <summary>
        /// 
        /// </summary>
        NbNo,
        /// <summary>
        /// 
        /// </summary>
        NlNl,
        /// <summary>
        /// 
        /// </summary>
        PlPl,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        PtPt,
        /// <summary>
        /// 
        /// </summary>
        SvSe,
        /// <summary>
        /// 
        /// </summary>
        YueCn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShotstackTextToSpeechOptionsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShotstackTextToSpeechOptionsLanguage value)
        {
            return value switch
            {
                ShotstackTextToSpeechOptionsLanguage.ArAe => "ar-AE",
                ShotstackTextToSpeechOptionsLanguage.CaEs => "ca-ES",
                ShotstackTextToSpeechOptionsLanguage.CmnCn => "cmn-CN",
                ShotstackTextToSpeechOptionsLanguage.DaDk => "da-DK",
                ShotstackTextToSpeechOptionsLanguage.DeAt => "de-AT",
                ShotstackTextToSpeechOptionsLanguage.DeDe => "de-DE",
                ShotstackTextToSpeechOptionsLanguage.EnAu => "en-AU",
                ShotstackTextToSpeechOptionsLanguage.EnGb => "en-GB",
                ShotstackTextToSpeechOptionsLanguage.EnIn => "en-IN",
                ShotstackTextToSpeechOptionsLanguage.EnNz => "en-NZ",
                ShotstackTextToSpeechOptionsLanguage.EnUs => "en-US",
                ShotstackTextToSpeechOptionsLanguage.EnZa => "en-ZA",
                ShotstackTextToSpeechOptionsLanguage.EsEs => "es-ES",
                ShotstackTextToSpeechOptionsLanguage.EsMx => "es-MX",
                ShotstackTextToSpeechOptionsLanguage.EsUs => "es-US",
                ShotstackTextToSpeechOptionsLanguage.FiFi => "fi-FI",
                ShotstackTextToSpeechOptionsLanguage.FrCa => "fr-CA",
                ShotstackTextToSpeechOptionsLanguage.FrFr => "fr-FR",
                ShotstackTextToSpeechOptionsLanguage.HiIn => "hi-IN",
                ShotstackTextToSpeechOptionsLanguage.ItIt => "it-IT",
                ShotstackTextToSpeechOptionsLanguage.JaJp => "ja-JP",
                ShotstackTextToSpeechOptionsLanguage.KoKr => "ko-KR",
                ShotstackTextToSpeechOptionsLanguage.NbNo => "nb-NO",
                ShotstackTextToSpeechOptionsLanguage.NlNl => "nl-NL",
                ShotstackTextToSpeechOptionsLanguage.PlPl => "pl-PL",
                ShotstackTextToSpeechOptionsLanguage.PtBr => "pt-BR",
                ShotstackTextToSpeechOptionsLanguage.PtPt => "pt-PT",
                ShotstackTextToSpeechOptionsLanguage.SvSe => "sv-SE",
                ShotstackTextToSpeechOptionsLanguage.YueCn => "yue-CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShotstackTextToSpeechOptionsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar-AE" => ShotstackTextToSpeechOptionsLanguage.ArAe,
                "ca-ES" => ShotstackTextToSpeechOptionsLanguage.CaEs,
                "cmn-CN" => ShotstackTextToSpeechOptionsLanguage.CmnCn,
                "da-DK" => ShotstackTextToSpeechOptionsLanguage.DaDk,
                "de-AT" => ShotstackTextToSpeechOptionsLanguage.DeAt,
                "de-DE" => ShotstackTextToSpeechOptionsLanguage.DeDe,
                "en-AU" => ShotstackTextToSpeechOptionsLanguage.EnAu,
                "en-GB" => ShotstackTextToSpeechOptionsLanguage.EnGb,
                "en-IN" => ShotstackTextToSpeechOptionsLanguage.EnIn,
                "en-NZ" => ShotstackTextToSpeechOptionsLanguage.EnNz,
                "en-US" => ShotstackTextToSpeechOptionsLanguage.EnUs,
                "en-ZA" => ShotstackTextToSpeechOptionsLanguage.EnZa,
                "es-ES" => ShotstackTextToSpeechOptionsLanguage.EsEs,
                "es-MX" => ShotstackTextToSpeechOptionsLanguage.EsMx,
                "es-US" => ShotstackTextToSpeechOptionsLanguage.EsUs,
                "fi-FI" => ShotstackTextToSpeechOptionsLanguage.FiFi,
                "fr-CA" => ShotstackTextToSpeechOptionsLanguage.FrCa,
                "fr-FR" => ShotstackTextToSpeechOptionsLanguage.FrFr,
                "hi-IN" => ShotstackTextToSpeechOptionsLanguage.HiIn,
                "it-IT" => ShotstackTextToSpeechOptionsLanguage.ItIt,
                "ja-JP" => ShotstackTextToSpeechOptionsLanguage.JaJp,
                "ko-KR" => ShotstackTextToSpeechOptionsLanguage.KoKr,
                "nb-NO" => ShotstackTextToSpeechOptionsLanguage.NbNo,
                "nl-NL" => ShotstackTextToSpeechOptionsLanguage.NlNl,
                "pl-PL" => ShotstackTextToSpeechOptionsLanguage.PlPl,
                "pt-BR" => ShotstackTextToSpeechOptionsLanguage.PtBr,
                "pt-PT" => ShotstackTextToSpeechOptionsLanguage.PtPt,
                "sv-SE" => ShotstackTextToSpeechOptionsLanguage.SvSe,
                "yue-CN" => ShotstackTextToSpeechOptionsLanguage.YueCn,
                _ => null,
            };
        }
    }
}