//HintName: G.Models.AgentRequestLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies what language (and dialect) the speech recognition will operate in. For instance, selecting `en-GB` optimizes speech recognition for British English. If unset, will use default value `en-US`. Select `multi` for multilingual support.<br/>
    /// Example: en-US
    /// </summary>
    public enum AgentRequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        AfZa,
        /// <summary>
        /// 
        /// </summary>
        ArSa,
        /// <summary>
        /// 
        /// </summary>
        AzAz,
        /// <summary>
        /// 
        /// </summary>
        BgBg,
        /// <summary>
        /// 
        /// </summary>
        BsBa,
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
        CyGb,
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
        FaIr,
        /// <summary>
        /// 
        /// </summary>
        FiFi,
        /// <summary>
        /// 
        /// </summary>
        FilPh,
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
        GlEs,
        /// <summary>
        /// 
        /// </summary>
        HeIl,
        /// <summary>
        /// 
        /// </summary>
        HiIn,
        /// <summary>
        /// 
        /// </summary>
        HrHr,
        /// <summary>
        /// 
        /// </summary>
        HuHu,
        /// <summary>
        /// 
        /// </summary>
        HyAm,
        /// <summary>
        /// 
        /// </summary>
        IdId,
        /// <summary>
        /// 
        /// </summary>
        IsIs,
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
        KkKz,
        /// <summary>
        /// 
        /// </summary>
        KnIn,
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
        MkMk,
        /// <summary>
        /// 
        /// </summary>
        MrIn,
        /// <summary>
        /// 
        /// </summary>
        MsMy,
        /// <summary>
        /// 
        /// </summary>
        Multi,
        /// <summary>
        /// 
        /// </summary>
        NeNp,
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
        SlSi,
        /// <summary>
        /// 
        /// </summary>
        SrRs,
        /// <summary>
        /// 
        /// </summary>
        SvSe,
        /// <summary>
        /// 
        /// </summary>
        SwKe,
        /// <summary>
        /// 
        /// </summary>
        TaIn,
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
        UkUa,
        /// <summary>
        /// 
        /// </summary>
        UrIn,
        /// <summary>
        /// 
        /// </summary>
        ViVn,
        /// <summary>
        /// 
        /// </summary>
        YueCn,
        /// <summary>
        /// 
        /// </summary>
        ZhCn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestLanguage value)
        {
            return value switch
            {
                AgentRequestLanguage.AfZa => "af-ZA",
                AgentRequestLanguage.ArSa => "ar-SA",
                AgentRequestLanguage.AzAz => "az-AZ",
                AgentRequestLanguage.BgBg => "bg-BG",
                AgentRequestLanguage.BsBa => "bs-BA",
                AgentRequestLanguage.CaEs => "ca-ES",
                AgentRequestLanguage.CsCz => "cs-CZ",
                AgentRequestLanguage.CyGb => "cy-GB",
                AgentRequestLanguage.DaDk => "da-DK",
                AgentRequestLanguage.DeDe => "de-DE",
                AgentRequestLanguage.ElGr => "el-GR",
                AgentRequestLanguage.EnAu => "en-AU",
                AgentRequestLanguage.EnGb => "en-GB",
                AgentRequestLanguage.EnIn => "en-IN",
                AgentRequestLanguage.EnNz => "en-NZ",
                AgentRequestLanguage.EnUs => "en-US",
                AgentRequestLanguage.Es419 => "es-419",
                AgentRequestLanguage.EsEs => "es-ES",
                AgentRequestLanguage.FaIr => "fa-IR",
                AgentRequestLanguage.FiFi => "fi-FI",
                AgentRequestLanguage.FilPh => "fil-PH",
                AgentRequestLanguage.FrCa => "fr-CA",
                AgentRequestLanguage.FrFr => "fr-FR",
                AgentRequestLanguage.GlEs => "gl-ES",
                AgentRequestLanguage.HeIl => "he-IL",
                AgentRequestLanguage.HiIn => "hi-IN",
                AgentRequestLanguage.HrHr => "hr-HR",
                AgentRequestLanguage.HuHu => "hu-HU",
                AgentRequestLanguage.HyAm => "hy-AM",
                AgentRequestLanguage.IdId => "id-ID",
                AgentRequestLanguage.IsIs => "is-IS",
                AgentRequestLanguage.ItIt => "it-IT",
                AgentRequestLanguage.JaJp => "ja-JP",
                AgentRequestLanguage.KkKz => "kk-KZ",
                AgentRequestLanguage.KnIn => "kn-IN",
                AgentRequestLanguage.KoKr => "ko-KR",
                AgentRequestLanguage.LtLt => "lt-LT",
                AgentRequestLanguage.LvLv => "lv-LV",
                AgentRequestLanguage.MkMk => "mk-MK",
                AgentRequestLanguage.MrIn => "mr-IN",
                AgentRequestLanguage.MsMy => "ms-MY",
                AgentRequestLanguage.Multi => "multi",
                AgentRequestLanguage.NeNp => "ne-NP",
                AgentRequestLanguage.NlBe => "nl-BE",
                AgentRequestLanguage.NlNl => "nl-NL",
                AgentRequestLanguage.NoNo => "no-NO",
                AgentRequestLanguage.PlPl => "pl-PL",
                AgentRequestLanguage.PtBr => "pt-BR",
                AgentRequestLanguage.PtPt => "pt-PT",
                AgentRequestLanguage.RoRo => "ro-RO",
                AgentRequestLanguage.RuRu => "ru-RU",
                AgentRequestLanguage.SkSk => "sk-SK",
                AgentRequestLanguage.SlSi => "sl-SI",
                AgentRequestLanguage.SrRs => "sr-RS",
                AgentRequestLanguage.SvSe => "sv-SE",
                AgentRequestLanguage.SwKe => "sw-KE",
                AgentRequestLanguage.TaIn => "ta-IN",
                AgentRequestLanguage.ThTh => "th-TH",
                AgentRequestLanguage.TrTr => "tr-TR",
                AgentRequestLanguage.UkUa => "uk-UA",
                AgentRequestLanguage.UrIn => "ur-IN",
                AgentRequestLanguage.ViVn => "vi-VN",
                AgentRequestLanguage.YueCn => "yue-CN",
                AgentRequestLanguage.ZhCn => "zh-CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "af-ZA" => AgentRequestLanguage.AfZa,
                "ar-SA" => AgentRequestLanguage.ArSa,
                "az-AZ" => AgentRequestLanguage.AzAz,
                "bg-BG" => AgentRequestLanguage.BgBg,
                "bs-BA" => AgentRequestLanguage.BsBa,
                "ca-ES" => AgentRequestLanguage.CaEs,
                "cs-CZ" => AgentRequestLanguage.CsCz,
                "cy-GB" => AgentRequestLanguage.CyGb,
                "da-DK" => AgentRequestLanguage.DaDk,
                "de-DE" => AgentRequestLanguage.DeDe,
                "el-GR" => AgentRequestLanguage.ElGr,
                "en-AU" => AgentRequestLanguage.EnAu,
                "en-GB" => AgentRequestLanguage.EnGb,
                "en-IN" => AgentRequestLanguage.EnIn,
                "en-NZ" => AgentRequestLanguage.EnNz,
                "en-US" => AgentRequestLanguage.EnUs,
                "es-419" => AgentRequestLanguage.Es419,
                "es-ES" => AgentRequestLanguage.EsEs,
                "fa-IR" => AgentRequestLanguage.FaIr,
                "fi-FI" => AgentRequestLanguage.FiFi,
                "fil-PH" => AgentRequestLanguage.FilPh,
                "fr-CA" => AgentRequestLanguage.FrCa,
                "fr-FR" => AgentRequestLanguage.FrFr,
                "gl-ES" => AgentRequestLanguage.GlEs,
                "he-IL" => AgentRequestLanguage.HeIl,
                "hi-IN" => AgentRequestLanguage.HiIn,
                "hr-HR" => AgentRequestLanguage.HrHr,
                "hu-HU" => AgentRequestLanguage.HuHu,
                "hy-AM" => AgentRequestLanguage.HyAm,
                "id-ID" => AgentRequestLanguage.IdId,
                "is-IS" => AgentRequestLanguage.IsIs,
                "it-IT" => AgentRequestLanguage.ItIt,
                "ja-JP" => AgentRequestLanguage.JaJp,
                "kk-KZ" => AgentRequestLanguage.KkKz,
                "kn-IN" => AgentRequestLanguage.KnIn,
                "ko-KR" => AgentRequestLanguage.KoKr,
                "lt-LT" => AgentRequestLanguage.LtLt,
                "lv-LV" => AgentRequestLanguage.LvLv,
                "mk-MK" => AgentRequestLanguage.MkMk,
                "mr-IN" => AgentRequestLanguage.MrIn,
                "ms-MY" => AgentRequestLanguage.MsMy,
                "multi" => AgentRequestLanguage.Multi,
                "ne-NP" => AgentRequestLanguage.NeNp,
                "nl-BE" => AgentRequestLanguage.NlBe,
                "nl-NL" => AgentRequestLanguage.NlNl,
                "no-NO" => AgentRequestLanguage.NoNo,
                "pl-PL" => AgentRequestLanguage.PlPl,
                "pt-BR" => AgentRequestLanguage.PtBr,
                "pt-PT" => AgentRequestLanguage.PtPt,
                "ro-RO" => AgentRequestLanguage.RoRo,
                "ru-RU" => AgentRequestLanguage.RuRu,
                "sk-SK" => AgentRequestLanguage.SkSk,
                "sl-SI" => AgentRequestLanguage.SlSi,
                "sr-RS" => AgentRequestLanguage.SrRs,
                "sv-SE" => AgentRequestLanguage.SvSe,
                "sw-KE" => AgentRequestLanguage.SwKe,
                "ta-IN" => AgentRequestLanguage.TaIn,
                "th-TH" => AgentRequestLanguage.ThTh,
                "tr-TR" => AgentRequestLanguage.TrTr,
                "uk-UA" => AgentRequestLanguage.UkUa,
                "ur-IN" => AgentRequestLanguage.UrIn,
                "vi-VN" => AgentRequestLanguage.ViVn,
                "yue-CN" => AgentRequestLanguage.YueCn,
                "zh-CN" => AgentRequestLanguage.ZhCn,
                _ => null,
            };
        }
    }
}