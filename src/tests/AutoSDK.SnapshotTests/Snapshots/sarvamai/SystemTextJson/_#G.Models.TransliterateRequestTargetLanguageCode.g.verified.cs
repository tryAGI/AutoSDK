//HintName: G.Models.TransliterateRequestTargetLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Target language code (BCP-47)
    /// </summary>
    public enum TransliterateRequestTargetLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        BnIn,
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
        MlIn,
        /// <summary>
        /// 
        /// </summary>
        MrIn,
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
        TaIn,
        /// <summary>
        /// 
        /// </summary>
        TeIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransliterateRequestTargetLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransliterateRequestTargetLanguageCode value)
        {
            return value switch
            {
                TransliterateRequestTargetLanguageCode.BnIn => "bn-IN",
                TransliterateRequestTargetLanguageCode.EnIn => "en-IN",
                TransliterateRequestTargetLanguageCode.GuIn => "gu-IN",
                TransliterateRequestTargetLanguageCode.HiIn => "hi-IN",
                TransliterateRequestTargetLanguageCode.KnIn => "kn-IN",
                TransliterateRequestTargetLanguageCode.MlIn => "ml-IN",
                TransliterateRequestTargetLanguageCode.MrIn => "mr-IN",
                TransliterateRequestTargetLanguageCode.OdIn => "od-IN",
                TransliterateRequestTargetLanguageCode.PaIn => "pa-IN",
                TransliterateRequestTargetLanguageCode.TaIn => "ta-IN",
                TransliterateRequestTargetLanguageCode.TeIn => "te-IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransliterateRequestTargetLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "bn-IN" => TransliterateRequestTargetLanguageCode.BnIn,
                "en-IN" => TransliterateRequestTargetLanguageCode.EnIn,
                "gu-IN" => TransliterateRequestTargetLanguageCode.GuIn,
                "hi-IN" => TransliterateRequestTargetLanguageCode.HiIn,
                "kn-IN" => TransliterateRequestTargetLanguageCode.KnIn,
                "ml-IN" => TransliterateRequestTargetLanguageCode.MlIn,
                "mr-IN" => TransliterateRequestTargetLanguageCode.MrIn,
                "od-IN" => TransliterateRequestTargetLanguageCode.OdIn,
                "pa-IN" => TransliterateRequestTargetLanguageCode.PaIn,
                "ta-IN" => TransliterateRequestTargetLanguageCode.TaIn,
                "te-IN" => TransliterateRequestTargetLanguageCode.TeIn,
                _ => null,
            };
        }
    }
}