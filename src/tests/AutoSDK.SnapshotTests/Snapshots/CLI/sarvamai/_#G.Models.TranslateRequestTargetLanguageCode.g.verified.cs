//HintName: G.Models.TranslateRequestTargetLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Target language code (BCP-47)
    /// </summary>
    public enum TranslateRequestTargetLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        AsIn,
        /// <summary>
        /// 
        /// </summary>
        BnIn,
        /// <summary>
        /// 
        /// </summary>
        BrxIn,
        /// <summary>
        /// 
        /// </summary>
        DoiIn,
        /// <summary>
        /// 
        /// </summary>
        EnIn,
        /// <summary>
        /// 
        /// </summary>
        GuIn,
        /// <summary>
        /// 
        /// </summary>
        HiIn,
        /// <summary>
        /// 
        /// </summary>
        KnIn,
        /// <summary>
        /// 
        /// </summary>
        KokIn,
        /// <summary>
        /// 
        /// </summary>
        KsIn,
        /// <summary>
        /// 
        /// </summary>
        MaiIn,
        /// <summary>
        /// 
        /// </summary>
        MlIn,
        /// <summary>
        /// 
        /// </summary>
        MniIn,
        /// <summary>
        /// 
        /// </summary>
        MrIn,
        /// <summary>
        /// 
        /// </summary>
        NeIn,
        /// <summary>
        /// 
        /// </summary>
        OdIn,
        /// <summary>
        /// 
        /// </summary>
        PaIn,
        /// <summary>
        /// 
        /// </summary>
        SaIn,
        /// <summary>
        /// 
        /// </summary>
        SatIn,
        /// <summary>
        /// 
        /// </summary>
        SdIn,
        /// <summary>
        /// 
        /// </summary>
        TaIn,
        /// <summary>
        /// 
        /// </summary>
        TeIn,
        /// <summary>
        /// 
        /// </summary>
        UrIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateRequestTargetLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateRequestTargetLanguageCode value)
        {
            return value switch
            {
                TranslateRequestTargetLanguageCode.AsIn => "as-IN",
                TranslateRequestTargetLanguageCode.BnIn => "bn-IN",
                TranslateRequestTargetLanguageCode.BrxIn => "brx-IN",
                TranslateRequestTargetLanguageCode.DoiIn => "doi-IN",
                TranslateRequestTargetLanguageCode.EnIn => "en-IN",
                TranslateRequestTargetLanguageCode.GuIn => "gu-IN",
                TranslateRequestTargetLanguageCode.HiIn => "hi-IN",
                TranslateRequestTargetLanguageCode.KnIn => "kn-IN",
                TranslateRequestTargetLanguageCode.KokIn => "kok-IN",
                TranslateRequestTargetLanguageCode.KsIn => "ks-IN",
                TranslateRequestTargetLanguageCode.MaiIn => "mai-IN",
                TranslateRequestTargetLanguageCode.MlIn => "ml-IN",
                TranslateRequestTargetLanguageCode.MniIn => "mni-IN",
                TranslateRequestTargetLanguageCode.MrIn => "mr-IN",
                TranslateRequestTargetLanguageCode.NeIn => "ne-IN",
                TranslateRequestTargetLanguageCode.OdIn => "od-IN",
                TranslateRequestTargetLanguageCode.PaIn => "pa-IN",
                TranslateRequestTargetLanguageCode.SaIn => "sa-IN",
                TranslateRequestTargetLanguageCode.SatIn => "sat-IN",
                TranslateRequestTargetLanguageCode.SdIn => "sd-IN",
                TranslateRequestTargetLanguageCode.TaIn => "ta-IN",
                TranslateRequestTargetLanguageCode.TeIn => "te-IN",
                TranslateRequestTargetLanguageCode.UrIn => "ur-IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateRequestTargetLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "as-IN" => TranslateRequestTargetLanguageCode.AsIn,
                "bn-IN" => TranslateRequestTargetLanguageCode.BnIn,
                "brx-IN" => TranslateRequestTargetLanguageCode.BrxIn,
                "doi-IN" => TranslateRequestTargetLanguageCode.DoiIn,
                "en-IN" => TranslateRequestTargetLanguageCode.EnIn,
                "gu-IN" => TranslateRequestTargetLanguageCode.GuIn,
                "hi-IN" => TranslateRequestTargetLanguageCode.HiIn,
                "kn-IN" => TranslateRequestTargetLanguageCode.KnIn,
                "kok-IN" => TranslateRequestTargetLanguageCode.KokIn,
                "ks-IN" => TranslateRequestTargetLanguageCode.KsIn,
                "mai-IN" => TranslateRequestTargetLanguageCode.MaiIn,
                "ml-IN" => TranslateRequestTargetLanguageCode.MlIn,
                "mni-IN" => TranslateRequestTargetLanguageCode.MniIn,
                "mr-IN" => TranslateRequestTargetLanguageCode.MrIn,
                "ne-IN" => TranslateRequestTargetLanguageCode.NeIn,
                "od-IN" => TranslateRequestTargetLanguageCode.OdIn,
                "pa-IN" => TranslateRequestTargetLanguageCode.PaIn,
                "sa-IN" => TranslateRequestTargetLanguageCode.SaIn,
                "sat-IN" => TranslateRequestTargetLanguageCode.SatIn,
                "sd-IN" => TranslateRequestTargetLanguageCode.SdIn,
                "ta-IN" => TranslateRequestTargetLanguageCode.TaIn,
                "te-IN" => TranslateRequestTargetLanguageCode.TeIn,
                "ur-IN" => TranslateRequestTargetLanguageCode.UrIn,
                _ => null,
            };
        }
    }
}