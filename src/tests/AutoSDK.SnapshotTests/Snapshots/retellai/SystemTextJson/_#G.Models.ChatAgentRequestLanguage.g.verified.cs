//HintName: G.Models.ChatAgentRequestLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies what language (and dialect) the chat will operate in. For instance, selecting `en-GB` optimizes for British English. If unset, will use default value `en-US`. Select `multi` for multilingual support, currently this supports Spanish and English.<br/>
    /// Example: en-US
    /// </summary>
    public enum ChatAgentRequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        BgBg,
        /// <summary>
        /// 
        /// </summary>
        CaEs,
        /// <summary>
        /// 
        /// </summary>
        CsCz,
        /// <summary>
        /// 
        /// </summary>
        DaDk,
        /// <summary>
        /// 
        /// </summary>
        DeDe,
        /// <summary>
        /// 
        /// </summary>
        ElGr,
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
        Es419,
        /// <summary>
        /// 
        /// </summary>
        EsEs,
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
        HuHu,
        /// <summary>
        /// 
        /// </summary>
        IdId,
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
        LtLt,
        /// <summary>
        /// 
        /// </summary>
        LvLv,
        /// <summary>
        /// 
        /// </summary>
        Multi,
        /// <summary>
        /// 
        /// </summary>
        NlBe,
        /// <summary>
        /// 
        /// </summary>
        NlNl,
        /// <summary>
        /// 
        /// </summary>
        NoNo,
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
        RoRo,
        /// <summary>
        /// 
        /// </summary>
        RuRu,
        /// <summary>
        /// 
        /// </summary>
        SkSk,
        /// <summary>
        /// 
        /// </summary>
        SvSe,
        /// <summary>
        /// 
        /// </summary>
        ThTh,
        /// <summary>
        /// 
        /// </summary>
        TrTr,
        /// <summary>
        /// 
        /// </summary>
        ViVn,
        /// <summary>
        /// 
        /// </summary>
        ZhCn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatAgentRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatAgentRequestLanguage value)
        {
            return value switch
            {
                ChatAgentRequestLanguage.BgBg => "bg-BG",
                ChatAgentRequestLanguage.CaEs => "ca-ES",
                ChatAgentRequestLanguage.CsCz => "cs-CZ",
                ChatAgentRequestLanguage.DaDk => "da-DK",
                ChatAgentRequestLanguage.DeDe => "de-DE",
                ChatAgentRequestLanguage.ElGr => "el-GR",
                ChatAgentRequestLanguage.EnAu => "en-AU",
                ChatAgentRequestLanguage.EnGb => "en-GB",
                ChatAgentRequestLanguage.EnIn => "en-IN",
                ChatAgentRequestLanguage.EnNz => "en-NZ",
                ChatAgentRequestLanguage.EnUs => "en-US",
                ChatAgentRequestLanguage.Es419 => "es-419",
                ChatAgentRequestLanguage.EsEs => "es-ES",
                ChatAgentRequestLanguage.FiFi => "fi-FI",
                ChatAgentRequestLanguage.FrCa => "fr-CA",
                ChatAgentRequestLanguage.FrFr => "fr-FR",
                ChatAgentRequestLanguage.HiIn => "hi-IN",
                ChatAgentRequestLanguage.HuHu => "hu-HU",
                ChatAgentRequestLanguage.IdId => "id-ID",
                ChatAgentRequestLanguage.ItIt => "it-IT",
                ChatAgentRequestLanguage.JaJp => "ja-JP",
                ChatAgentRequestLanguage.KoKr => "ko-KR",
                ChatAgentRequestLanguage.LtLt => "lt-LT",
                ChatAgentRequestLanguage.LvLv => "lv-LV",
                ChatAgentRequestLanguage.Multi => "multi",
                ChatAgentRequestLanguage.NlBe => "nl-BE",
                ChatAgentRequestLanguage.NlNl => "nl-NL",
                ChatAgentRequestLanguage.NoNo => "no-NO",
                ChatAgentRequestLanguage.PlPl => "pl-PL",
                ChatAgentRequestLanguage.PtBr => "pt-BR",
                ChatAgentRequestLanguage.PtPt => "pt-PT",
                ChatAgentRequestLanguage.RoRo => "ro-RO",
                ChatAgentRequestLanguage.RuRu => "ru-RU",
                ChatAgentRequestLanguage.SkSk => "sk-SK",
                ChatAgentRequestLanguage.SvSe => "sv-SE",
                ChatAgentRequestLanguage.ThTh => "th-TH",
                ChatAgentRequestLanguage.TrTr => "tr-TR",
                ChatAgentRequestLanguage.ViVn => "vi-VN",
                ChatAgentRequestLanguage.ZhCn => "zh-CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatAgentRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "bg-BG" => ChatAgentRequestLanguage.BgBg,
                "ca-ES" => ChatAgentRequestLanguage.CaEs,
                "cs-CZ" => ChatAgentRequestLanguage.CsCz,
                "da-DK" => ChatAgentRequestLanguage.DaDk,
                "de-DE" => ChatAgentRequestLanguage.DeDe,
                "el-GR" => ChatAgentRequestLanguage.ElGr,
                "en-AU" => ChatAgentRequestLanguage.EnAu,
                "en-GB" => ChatAgentRequestLanguage.EnGb,
                "en-IN" => ChatAgentRequestLanguage.EnIn,
                "en-NZ" => ChatAgentRequestLanguage.EnNz,
                "en-US" => ChatAgentRequestLanguage.EnUs,
                "es-419" => ChatAgentRequestLanguage.Es419,
                "es-ES" => ChatAgentRequestLanguage.EsEs,
                "fi-FI" => ChatAgentRequestLanguage.FiFi,
                "fr-CA" => ChatAgentRequestLanguage.FrCa,
                "fr-FR" => ChatAgentRequestLanguage.FrFr,
                "hi-IN" => ChatAgentRequestLanguage.HiIn,
                "hu-HU" => ChatAgentRequestLanguage.HuHu,
                "id-ID" => ChatAgentRequestLanguage.IdId,
                "it-IT" => ChatAgentRequestLanguage.ItIt,
                "ja-JP" => ChatAgentRequestLanguage.JaJp,
                "ko-KR" => ChatAgentRequestLanguage.KoKr,
                "lt-LT" => ChatAgentRequestLanguage.LtLt,
                "lv-LV" => ChatAgentRequestLanguage.LvLv,
                "multi" => ChatAgentRequestLanguage.Multi,
                "nl-BE" => ChatAgentRequestLanguage.NlBe,
                "nl-NL" => ChatAgentRequestLanguage.NlNl,
                "no-NO" => ChatAgentRequestLanguage.NoNo,
                "pl-PL" => ChatAgentRequestLanguage.PlPl,
                "pt-BR" => ChatAgentRequestLanguage.PtBr,
                "pt-PT" => ChatAgentRequestLanguage.PtPt,
                "ro-RO" => ChatAgentRequestLanguage.RoRo,
                "ru-RU" => ChatAgentRequestLanguage.RuRu,
                "sk-SK" => ChatAgentRequestLanguage.SkSk,
                "sv-SE" => ChatAgentRequestLanguage.SvSe,
                "th-TH" => ChatAgentRequestLanguage.ThTh,
                "tr-TR" => ChatAgentRequestLanguage.TrTr,
                "vi-VN" => ChatAgentRequestLanguage.ViVn,
                "zh-CN" => ChatAgentRequestLanguage.ZhCn,
                _ => null,
            };
        }
    }
}