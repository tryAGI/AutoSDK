//HintName: G.Models.PortkeyLanguageParametersLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language that should be allowed in content
    /// </summary>
    public enum PortkeyLanguageParametersLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        AraArab,
        /// <summary>
        /// 
        /// </summary>
        ArbLatn,
        /// <summary>
        /// 
        /// </summary>
        AzeLatn,
        /// <summary>
        /// 
        /// </summary>
        BenBeng,
        /// <summary>
        /// 
        /// </summary>
        BulCyrl,
        /// <summary>
        /// 
        /// </summary>
        CatLatn,
        /// <summary>
        /// 
        /// </summary>
        CesLatn,
        /// <summary>
        /// 
        /// </summary>
        DanLatn,
        /// <summary>
        /// 
        /// </summary>
        DeuLatn,
        /// <summary>
        /// 
        /// </summary>
        EllGrek,
        /// <summary>
        /// 
        /// </summary>
        EngLatn,
        /// <summary>
        /// 
        /// </summary>
        EstLatn,
        /// <summary>
        /// 
        /// </summary>
        FasArab,
        /// <summary>
        /// 
        /// </summary>
        FilLatn,
        /// <summary>
        /// 
        /// </summary>
        FinLatn,
        /// <summary>
        /// 
        /// </summary>
        FraLatn,
        /// <summary>
        /// 
        /// </summary>
        HebHebr,
        /// <summary>
        /// 
        /// </summary>
        HinDeva,
        /// <summary>
        /// 
        /// </summary>
        HrvLatn,
        /// <summary>
        /// 
        /// </summary>
        HunLatn,
        /// <summary>
        /// 
        /// </summary>
        IndLatn,
        /// <summary>
        /// 
        /// </summary>
        ItaLatn,
        /// <summary>
        /// 
        /// </summary>
        JpnJpan,
        /// <summary>
        /// 
        /// </summary>
        KanKnda,
        /// <summary>
        /// 
        /// </summary>
        KorHang,
        /// <summary>
        /// 
        /// </summary>
        LavLatn,
        /// <summary>
        /// 
        /// </summary>
        LitLatn,
        /// <summary>
        /// 
        /// </summary>
        MarDeva,
        /// <summary>
        /// 
        /// </summary>
        MsaLatn,
        /// <summary>
        /// 
        /// </summary>
        NldLatn,
        /// <summary>
        /// 
        /// </summary>
        NorLatn,
        /// <summary>
        /// 
        /// </summary>
        PesArab,
        /// <summary>
        /// 
        /// </summary>
        PolLatn,
        /// <summary>
        /// 
        /// </summary>
        PorLatn,
        /// <summary>
        /// 
        /// </summary>
        RonLatn,
        /// <summary>
        /// 
        /// </summary>
        RusCyrl,
        /// <summary>
        /// 
        /// </summary>
        SlkLatn,
        /// <summary>
        /// 
        /// </summary>
        SlvLatn,
        /// <summary>
        /// 
        /// </summary>
        SpaLatn,
        /// <summary>
        /// 
        /// </summary>
        SrpCyrl,
        /// <summary>
        /// 
        /// </summary>
        SweLatn,
        /// <summary>
        /// 
        /// </summary>
        TamTaml,
        /// <summary>
        /// 
        /// </summary>
        TelTelu,
        /// <summary>
        /// 
        /// </summary>
        ThaThai,
        /// <summary>
        /// 
        /// </summary>
        TurLatn,
        /// <summary>
        /// 
        /// </summary>
        UkrCyrl,
        /// <summary>
        /// 
        /// </summary>
        UrdArab,
        /// <summary>
        /// 
        /// </summary>
        VieLatn,
        /// <summary>
        /// 
        /// </summary>
        ZhoHans,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PortkeyLanguageParametersLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PortkeyLanguageParametersLanguage value)
        {
            return value switch
            {
                PortkeyLanguageParametersLanguage.AraArab => "ara_Arab",
                PortkeyLanguageParametersLanguage.ArbLatn => "arb_Latn",
                PortkeyLanguageParametersLanguage.AzeLatn => "aze_Latn",
                PortkeyLanguageParametersLanguage.BenBeng => "ben_Beng",
                PortkeyLanguageParametersLanguage.BulCyrl => "bul_Cyrl",
                PortkeyLanguageParametersLanguage.CatLatn => "cat_Latn",
                PortkeyLanguageParametersLanguage.CesLatn => "ces_Latn",
                PortkeyLanguageParametersLanguage.DanLatn => "dan_Latn",
                PortkeyLanguageParametersLanguage.DeuLatn => "deu_Latn",
                PortkeyLanguageParametersLanguage.EllGrek => "ell_Grek",
                PortkeyLanguageParametersLanguage.EngLatn => "eng_Latn",
                PortkeyLanguageParametersLanguage.EstLatn => "est_Latn",
                PortkeyLanguageParametersLanguage.FasArab => "fas_Arab",
                PortkeyLanguageParametersLanguage.FilLatn => "fil_Latn",
                PortkeyLanguageParametersLanguage.FinLatn => "fin_Latn",
                PortkeyLanguageParametersLanguage.FraLatn => "fra_Latn",
                PortkeyLanguageParametersLanguage.HebHebr => "heb_Hebr",
                PortkeyLanguageParametersLanguage.HinDeva => "hin_Deva",
                PortkeyLanguageParametersLanguage.HrvLatn => "hrv_Latn",
                PortkeyLanguageParametersLanguage.HunLatn => "hun_Latn",
                PortkeyLanguageParametersLanguage.IndLatn => "ind_Latn",
                PortkeyLanguageParametersLanguage.ItaLatn => "ita_Latn",
                PortkeyLanguageParametersLanguage.JpnJpan => "jpn_Jpan",
                PortkeyLanguageParametersLanguage.KanKnda => "kan_Knda",
                PortkeyLanguageParametersLanguage.KorHang => "kor_Hang",
                PortkeyLanguageParametersLanguage.LavLatn => "lav_Latn",
                PortkeyLanguageParametersLanguage.LitLatn => "lit_Latn",
                PortkeyLanguageParametersLanguage.MarDeva => "mar_Deva",
                PortkeyLanguageParametersLanguage.MsaLatn => "msa_Latn",
                PortkeyLanguageParametersLanguage.NldLatn => "nld_Latn",
                PortkeyLanguageParametersLanguage.NorLatn => "nor_Latn",
                PortkeyLanguageParametersLanguage.PesArab => "pes_Arab",
                PortkeyLanguageParametersLanguage.PolLatn => "pol_Latn",
                PortkeyLanguageParametersLanguage.PorLatn => "por_Latn",
                PortkeyLanguageParametersLanguage.RonLatn => "ron_Latn",
                PortkeyLanguageParametersLanguage.RusCyrl => "rus_Cyrl",
                PortkeyLanguageParametersLanguage.SlkLatn => "slk_Latn",
                PortkeyLanguageParametersLanguage.SlvLatn => "slv_Latn",
                PortkeyLanguageParametersLanguage.SpaLatn => "spa_Latn",
                PortkeyLanguageParametersLanguage.SrpCyrl => "srp_Cyrl",
                PortkeyLanguageParametersLanguage.SweLatn => "swe_Latn",
                PortkeyLanguageParametersLanguage.TamTaml => "tam_Taml",
                PortkeyLanguageParametersLanguage.TelTelu => "tel_Telu",
                PortkeyLanguageParametersLanguage.ThaThai => "tha_Thai",
                PortkeyLanguageParametersLanguage.TurLatn => "tur_Latn",
                PortkeyLanguageParametersLanguage.UkrCyrl => "ukr_Cyrl",
                PortkeyLanguageParametersLanguage.UrdArab => "urd_Arab",
                PortkeyLanguageParametersLanguage.VieLatn => "vie_Latn",
                PortkeyLanguageParametersLanguage.ZhoHans => "zho_Hans",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PortkeyLanguageParametersLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ara_Arab" => PortkeyLanguageParametersLanguage.AraArab,
                "arb_Latn" => PortkeyLanguageParametersLanguage.ArbLatn,
                "aze_Latn" => PortkeyLanguageParametersLanguage.AzeLatn,
                "ben_Beng" => PortkeyLanguageParametersLanguage.BenBeng,
                "bul_Cyrl" => PortkeyLanguageParametersLanguage.BulCyrl,
                "cat_Latn" => PortkeyLanguageParametersLanguage.CatLatn,
                "ces_Latn" => PortkeyLanguageParametersLanguage.CesLatn,
                "dan_Latn" => PortkeyLanguageParametersLanguage.DanLatn,
                "deu_Latn" => PortkeyLanguageParametersLanguage.DeuLatn,
                "ell_Grek" => PortkeyLanguageParametersLanguage.EllGrek,
                "eng_Latn" => PortkeyLanguageParametersLanguage.EngLatn,
                "est_Latn" => PortkeyLanguageParametersLanguage.EstLatn,
                "fas_Arab" => PortkeyLanguageParametersLanguage.FasArab,
                "fil_Latn" => PortkeyLanguageParametersLanguage.FilLatn,
                "fin_Latn" => PortkeyLanguageParametersLanguage.FinLatn,
                "fra_Latn" => PortkeyLanguageParametersLanguage.FraLatn,
                "heb_Hebr" => PortkeyLanguageParametersLanguage.HebHebr,
                "hin_Deva" => PortkeyLanguageParametersLanguage.HinDeva,
                "hrv_Latn" => PortkeyLanguageParametersLanguage.HrvLatn,
                "hun_Latn" => PortkeyLanguageParametersLanguage.HunLatn,
                "ind_Latn" => PortkeyLanguageParametersLanguage.IndLatn,
                "ita_Latn" => PortkeyLanguageParametersLanguage.ItaLatn,
                "jpn_Jpan" => PortkeyLanguageParametersLanguage.JpnJpan,
                "kan_Knda" => PortkeyLanguageParametersLanguage.KanKnda,
                "kor_Hang" => PortkeyLanguageParametersLanguage.KorHang,
                "lav_Latn" => PortkeyLanguageParametersLanguage.LavLatn,
                "lit_Latn" => PortkeyLanguageParametersLanguage.LitLatn,
                "mar_Deva" => PortkeyLanguageParametersLanguage.MarDeva,
                "msa_Latn" => PortkeyLanguageParametersLanguage.MsaLatn,
                "nld_Latn" => PortkeyLanguageParametersLanguage.NldLatn,
                "nor_Latn" => PortkeyLanguageParametersLanguage.NorLatn,
                "pes_Arab" => PortkeyLanguageParametersLanguage.PesArab,
                "pol_Latn" => PortkeyLanguageParametersLanguage.PolLatn,
                "por_Latn" => PortkeyLanguageParametersLanguage.PorLatn,
                "ron_Latn" => PortkeyLanguageParametersLanguage.RonLatn,
                "rus_Cyrl" => PortkeyLanguageParametersLanguage.RusCyrl,
                "slk_Latn" => PortkeyLanguageParametersLanguage.SlkLatn,
                "slv_Latn" => PortkeyLanguageParametersLanguage.SlvLatn,
                "spa_Latn" => PortkeyLanguageParametersLanguage.SpaLatn,
                "srp_Cyrl" => PortkeyLanguageParametersLanguage.SrpCyrl,
                "swe_Latn" => PortkeyLanguageParametersLanguage.SweLatn,
                "tam_Taml" => PortkeyLanguageParametersLanguage.TamTaml,
                "tel_Telu" => PortkeyLanguageParametersLanguage.TelTelu,
                "tha_Thai" => PortkeyLanguageParametersLanguage.ThaThai,
                "tur_Latn" => PortkeyLanguageParametersLanguage.TurLatn,
                "ukr_Cyrl" => PortkeyLanguageParametersLanguage.UkrCyrl,
                "urd_Arab" => PortkeyLanguageParametersLanguage.UrdArab,
                "vie_Latn" => PortkeyLanguageParametersLanguage.VieLatn,
                "zho_Hans" => PortkeyLanguageParametersLanguage.ZhoHans,
                _ => null,
            };
        }
    }
}