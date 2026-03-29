//HintName: G.Models.ChatAgentRequestLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies what language (and dialect) the chat will operate in. For instance, selecting `en-GB` optimizes for British English. If unset, will use default value `en-US`. Select `multi` for multilingual support, currently this supports Spanish and English.<br/>
    /// Example: en-US
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatAgentRequestLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bg-BG")]
        BgBg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ca-ES")]
        CaEs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cs-CZ")]
        CsCz,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="da-DK")]
        DaDk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de-DE")]
        DeDe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="el-GR")]
        ElGr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-AU")]
        EnAu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-GB")]
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-IN")]
        EnIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-NZ")]
        EnNz,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-US")]
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-419")]
        Es419,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-ES")]
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fi-FI")]
        FiFi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr-CA")]
        FrCa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr-FR")]
        FrFr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hi-IN")]
        HiIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hu-HU")]
        HuHu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id-ID")]
        IdId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="it-IT")]
        ItIt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ja-JP")]
        JaJp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ko-KR")]
        KoKr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt-LT")]
        LtLt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lv-LV")]
        LvLv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="multi")]
        Multi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl-BE")]
        NlBe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl-NL")]
        NlNl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no-NO")]
        NoNo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pl-PL")]
        PlPl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt-BR")]
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt-PT")]
        PtPt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ro-RO")]
        RoRo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ru-RU")]
        RuRu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sk-SK")]
        SkSk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sv-SE")]
        SvSe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="th-TH")]
        ThTh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tr-TR")]
        TrTr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vi-VN")]
        ViVn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh-CN")]
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