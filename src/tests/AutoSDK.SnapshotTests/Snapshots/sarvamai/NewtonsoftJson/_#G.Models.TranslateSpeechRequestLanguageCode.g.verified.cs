//HintName: G.Models.TranslateSpeechRequestLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language of the audio (BCP-47)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslateSpeechRequestLanguageCode
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
    public static class TranslateSpeechRequestLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateSpeechRequestLanguageCode value)
        {
            return value switch
            {
                TranslateSpeechRequestLanguageCode.AsIn => "as-IN",
                TranslateSpeechRequestLanguageCode.BnIn => "bn-IN",
                TranslateSpeechRequestLanguageCode.BrxIn => "brx-IN",
                TranslateSpeechRequestLanguageCode.DoiIn => "doi-IN",
                TranslateSpeechRequestLanguageCode.EnIn => "en-IN",
                TranslateSpeechRequestLanguageCode.GuIn => "gu-IN",
                TranslateSpeechRequestLanguageCode.HiIn => "hi-IN",
                TranslateSpeechRequestLanguageCode.KnIn => "kn-IN",
                TranslateSpeechRequestLanguageCode.KokIn => "kok-IN",
                TranslateSpeechRequestLanguageCode.KsIn => "ks-IN",
                TranslateSpeechRequestLanguageCode.MaiIn => "mai-IN",
                TranslateSpeechRequestLanguageCode.MlIn => "ml-IN",
                TranslateSpeechRequestLanguageCode.MniIn => "mni-IN",
                TranslateSpeechRequestLanguageCode.MrIn => "mr-IN",
                TranslateSpeechRequestLanguageCode.NeIn => "ne-IN",
                TranslateSpeechRequestLanguageCode.OdIn => "od-IN",
                TranslateSpeechRequestLanguageCode.PaIn => "pa-IN",
                TranslateSpeechRequestLanguageCode.SaIn => "sa-IN",
                TranslateSpeechRequestLanguageCode.SatIn => "sat-IN",
                TranslateSpeechRequestLanguageCode.SdIn => "sd-IN",
                TranslateSpeechRequestLanguageCode.TaIn => "ta-IN",
                TranslateSpeechRequestLanguageCode.TeIn => "te-IN",
                TranslateSpeechRequestLanguageCode.Unknown => "unknown",
                TranslateSpeechRequestLanguageCode.UrIn => "ur-IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateSpeechRequestLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "as-IN" => TranslateSpeechRequestLanguageCode.AsIn,
                "bn-IN" => TranslateSpeechRequestLanguageCode.BnIn,
                "brx-IN" => TranslateSpeechRequestLanguageCode.BrxIn,
                "doi-IN" => TranslateSpeechRequestLanguageCode.DoiIn,
                "en-IN" => TranslateSpeechRequestLanguageCode.EnIn,
                "gu-IN" => TranslateSpeechRequestLanguageCode.GuIn,
                "hi-IN" => TranslateSpeechRequestLanguageCode.HiIn,
                "kn-IN" => TranslateSpeechRequestLanguageCode.KnIn,
                "kok-IN" => TranslateSpeechRequestLanguageCode.KokIn,
                "ks-IN" => TranslateSpeechRequestLanguageCode.KsIn,
                "mai-IN" => TranslateSpeechRequestLanguageCode.MaiIn,
                "ml-IN" => TranslateSpeechRequestLanguageCode.MlIn,
                "mni-IN" => TranslateSpeechRequestLanguageCode.MniIn,
                "mr-IN" => TranslateSpeechRequestLanguageCode.MrIn,
                "ne-IN" => TranslateSpeechRequestLanguageCode.NeIn,
                "od-IN" => TranslateSpeechRequestLanguageCode.OdIn,
                "pa-IN" => TranslateSpeechRequestLanguageCode.PaIn,
                "sa-IN" => TranslateSpeechRequestLanguageCode.SaIn,
                "sat-IN" => TranslateSpeechRequestLanguageCode.SatIn,
                "sd-IN" => TranslateSpeechRequestLanguageCode.SdIn,
                "ta-IN" => TranslateSpeechRequestLanguageCode.TaIn,
                "te-IN" => TranslateSpeechRequestLanguageCode.TeIn,
                "unknown" => TranslateSpeechRequestLanguageCode.Unknown,
                "ur-IN" => TranslateSpeechRequestLanguageCode.UrIn,
                _ => null,
            };
        }
    }
}