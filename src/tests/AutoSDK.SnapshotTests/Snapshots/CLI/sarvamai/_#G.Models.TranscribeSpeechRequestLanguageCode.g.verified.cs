//HintName: G.Models.TranscribeSpeechRequestLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language of the audio (BCP-47). Optional for saarika:v2.5.
    /// </summary>
    public enum TranscribeSpeechRequestLanguageCode
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
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        UrIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscribeSpeechRequestLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscribeSpeechRequestLanguageCode value)
        {
            return value switch
            {
                TranscribeSpeechRequestLanguageCode.AsIn => "as-IN",
                TranscribeSpeechRequestLanguageCode.BnIn => "bn-IN",
                TranscribeSpeechRequestLanguageCode.BrxIn => "brx-IN",
                TranscribeSpeechRequestLanguageCode.DoiIn => "doi-IN",
                TranscribeSpeechRequestLanguageCode.EnIn => "en-IN",
                TranscribeSpeechRequestLanguageCode.GuIn => "gu-IN",
                TranscribeSpeechRequestLanguageCode.HiIn => "hi-IN",
                TranscribeSpeechRequestLanguageCode.KnIn => "kn-IN",
                TranscribeSpeechRequestLanguageCode.KokIn => "kok-IN",
                TranscribeSpeechRequestLanguageCode.KsIn => "ks-IN",
                TranscribeSpeechRequestLanguageCode.MaiIn => "mai-IN",
                TranscribeSpeechRequestLanguageCode.MlIn => "ml-IN",
                TranscribeSpeechRequestLanguageCode.MniIn => "mni-IN",
                TranscribeSpeechRequestLanguageCode.MrIn => "mr-IN",
                TranscribeSpeechRequestLanguageCode.NeIn => "ne-IN",
                TranscribeSpeechRequestLanguageCode.OdIn => "od-IN",
                TranscribeSpeechRequestLanguageCode.PaIn => "pa-IN",
                TranscribeSpeechRequestLanguageCode.SaIn => "sa-IN",
                TranscribeSpeechRequestLanguageCode.SatIn => "sat-IN",
                TranscribeSpeechRequestLanguageCode.SdIn => "sd-IN",
                TranscribeSpeechRequestLanguageCode.TaIn => "ta-IN",
                TranscribeSpeechRequestLanguageCode.TeIn => "te-IN",
                TranscribeSpeechRequestLanguageCode.Unknown => "unknown",
                TranscribeSpeechRequestLanguageCode.UrIn => "ur-IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscribeSpeechRequestLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "as-IN" => TranscribeSpeechRequestLanguageCode.AsIn,
                "bn-IN" => TranscribeSpeechRequestLanguageCode.BnIn,
                "brx-IN" => TranscribeSpeechRequestLanguageCode.BrxIn,
                "doi-IN" => TranscribeSpeechRequestLanguageCode.DoiIn,
                "en-IN" => TranscribeSpeechRequestLanguageCode.EnIn,
                "gu-IN" => TranscribeSpeechRequestLanguageCode.GuIn,
                "hi-IN" => TranscribeSpeechRequestLanguageCode.HiIn,
                "kn-IN" => TranscribeSpeechRequestLanguageCode.KnIn,
                "kok-IN" => TranscribeSpeechRequestLanguageCode.KokIn,
                "ks-IN" => TranscribeSpeechRequestLanguageCode.KsIn,
                "mai-IN" => TranscribeSpeechRequestLanguageCode.MaiIn,
                "ml-IN" => TranscribeSpeechRequestLanguageCode.MlIn,
                "mni-IN" => TranscribeSpeechRequestLanguageCode.MniIn,
                "mr-IN" => TranscribeSpeechRequestLanguageCode.MrIn,
                "ne-IN" => TranscribeSpeechRequestLanguageCode.NeIn,
                "od-IN" => TranscribeSpeechRequestLanguageCode.OdIn,
                "pa-IN" => TranscribeSpeechRequestLanguageCode.PaIn,
                "sa-IN" => TranscribeSpeechRequestLanguageCode.SaIn,
                "sat-IN" => TranscribeSpeechRequestLanguageCode.SatIn,
                "sd-IN" => TranscribeSpeechRequestLanguageCode.SdIn,
                "ta-IN" => TranscribeSpeechRequestLanguageCode.TaIn,
                "te-IN" => TranscribeSpeechRequestLanguageCode.TeIn,
                "unknown" => TranscribeSpeechRequestLanguageCode.Unknown,
                "ur-IN" => TranscribeSpeechRequestLanguageCode.UrIn,
                _ => null,
            };
        }
    }
}