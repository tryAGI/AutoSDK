//HintName: G.Models.TextToSpeechRequestTargetLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language code (BCP-47) for text normalization
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextToSpeechRequestTargetLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bn-IN")]
        BnIn,
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
        [global::System.Runtime.Serialization.EnumMember(Value="ml-IN")]
        MlIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mr-IN")]
        MrIn,
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
        [global::System.Runtime.Serialization.EnumMember(Value="ta-IN")]
        TaIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="te-IN")]
        TeIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechRequestTargetLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestTargetLanguageCode value)
        {
            return value switch
            {
                TextToSpeechRequestTargetLanguageCode.BnIn => "bn-IN",
                TextToSpeechRequestTargetLanguageCode.EnIn => "en-IN",
                TextToSpeechRequestTargetLanguageCode.GuIn => "gu-IN",
                TextToSpeechRequestTargetLanguageCode.HiIn => "hi-IN",
                TextToSpeechRequestTargetLanguageCode.KnIn => "kn-IN",
                TextToSpeechRequestTargetLanguageCode.MlIn => "ml-IN",
                TextToSpeechRequestTargetLanguageCode.MrIn => "mr-IN",
                TextToSpeechRequestTargetLanguageCode.OdIn => "od-IN",
                TextToSpeechRequestTargetLanguageCode.PaIn => "pa-IN",
                TextToSpeechRequestTargetLanguageCode.TaIn => "ta-IN",
                TextToSpeechRequestTargetLanguageCode.TeIn => "te-IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestTargetLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "bn-IN" => TextToSpeechRequestTargetLanguageCode.BnIn,
                "en-IN" => TextToSpeechRequestTargetLanguageCode.EnIn,
                "gu-IN" => TextToSpeechRequestTargetLanguageCode.GuIn,
                "hi-IN" => TextToSpeechRequestTargetLanguageCode.HiIn,
                "kn-IN" => TextToSpeechRequestTargetLanguageCode.KnIn,
                "ml-IN" => TextToSpeechRequestTargetLanguageCode.MlIn,
                "mr-IN" => TextToSpeechRequestTargetLanguageCode.MrIn,
                "od-IN" => TextToSpeechRequestTargetLanguageCode.OdIn,
                "pa-IN" => TextToSpeechRequestTargetLanguageCode.PaIn,
                "ta-IN" => TextToSpeechRequestTargetLanguageCode.TaIn,
                "te-IN" => TextToSpeechRequestTargetLanguageCode.TeIn,
                _ => null,
            };
        }
    }
}