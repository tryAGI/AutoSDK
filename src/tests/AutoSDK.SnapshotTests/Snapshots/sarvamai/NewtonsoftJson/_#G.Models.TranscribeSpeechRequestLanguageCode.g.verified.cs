//HintName: G.Models.TranscribeSpeechRequestLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language of the audio (BCP-47). Optional for saarika:v2.5.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscribeSpeechRequestLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="as-IN")]
        AsIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bn-IN")]
        BnIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="brx-IN")]
        BrxIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="doi-IN")]
        DoiIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-IN")]
        EnIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gu-IN")]
        GuIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hi-IN")]
        HiIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kn-IN")]
        KnIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kok-IN")]
        KokIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ks-IN")]
        KsIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mai-IN")]
        MaiIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ml-IN")]
        MlIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mni-IN")]
        MniIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mr-IN")]
        MrIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ne-IN")]
        NeIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="od-IN")]
        OdIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pa-IN")]
        PaIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sa-IN")]
        SaIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sat-IN")]
        SatIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sd-IN")]
        SdIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ta-IN")]
        TaIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="te-IN")]
        TeIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ur-IN")]
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