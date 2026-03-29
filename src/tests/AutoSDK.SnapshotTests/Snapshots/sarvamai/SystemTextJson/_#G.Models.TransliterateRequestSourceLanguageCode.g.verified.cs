//HintName: G.Models.TransliterateRequestSourceLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Source language code (BCP-47) or "auto"
    /// </summary>
    public enum TransliterateRequestSourceLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
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
    public static class TransliterateRequestSourceLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransliterateRequestSourceLanguageCode value)
        {
            return value switch
            {
                TransliterateRequestSourceLanguageCode.Auto => "auto",
                TransliterateRequestSourceLanguageCode.BnIn => "bn-IN",
                TransliterateRequestSourceLanguageCode.EnIn => "en-IN",
                TransliterateRequestSourceLanguageCode.GuIn => "gu-IN",
                TransliterateRequestSourceLanguageCode.HiIn => "hi-IN",
                TransliterateRequestSourceLanguageCode.KnIn => "kn-IN",
                TransliterateRequestSourceLanguageCode.MlIn => "ml-IN",
                TransliterateRequestSourceLanguageCode.MrIn => "mr-IN",
                TransliterateRequestSourceLanguageCode.OdIn => "od-IN",
                TransliterateRequestSourceLanguageCode.PaIn => "pa-IN",
                TransliterateRequestSourceLanguageCode.TaIn => "ta-IN",
                TransliterateRequestSourceLanguageCode.TeIn => "te-IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransliterateRequestSourceLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TransliterateRequestSourceLanguageCode.Auto,
                "bn-IN" => TransliterateRequestSourceLanguageCode.BnIn,
                "en-IN" => TransliterateRequestSourceLanguageCode.EnIn,
                "gu-IN" => TransliterateRequestSourceLanguageCode.GuIn,
                "hi-IN" => TransliterateRequestSourceLanguageCode.HiIn,
                "kn-IN" => TransliterateRequestSourceLanguageCode.KnIn,
                "ml-IN" => TransliterateRequestSourceLanguageCode.MlIn,
                "mr-IN" => TransliterateRequestSourceLanguageCode.MrIn,
                "od-IN" => TransliterateRequestSourceLanguageCode.OdIn,
                "pa-IN" => TransliterateRequestSourceLanguageCode.PaIn,
                "ta-IN" => TransliterateRequestSourceLanguageCode.TaIn,
                "te-IN" => TransliterateRequestSourceLanguageCode.TeIn,
                _ => null,
            };
        }
    }
}