//HintName: G.Models.TransliterateRequestSourceLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Source language code (BCP-47) or "auto"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransliterateRequestSourceLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
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