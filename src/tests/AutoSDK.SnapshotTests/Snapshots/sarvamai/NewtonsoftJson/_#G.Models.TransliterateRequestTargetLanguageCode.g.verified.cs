//HintName: G.Models.TransliterateRequestTargetLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Target language code (BCP-47)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransliterateRequestTargetLanguageCode
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