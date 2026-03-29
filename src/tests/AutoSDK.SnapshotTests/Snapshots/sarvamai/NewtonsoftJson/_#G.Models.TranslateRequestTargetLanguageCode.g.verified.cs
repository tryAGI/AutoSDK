//HintName: G.Models.TranslateRequestTargetLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Target language code (BCP-47)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslateRequestTargetLanguageCode
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
        [global::System.Runtime.Serialization.EnumMember(Value="ur-IN")]
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