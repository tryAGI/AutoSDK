//HintName: G.Models.TranslateRequestSourceLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Source language code (BCP-47) or "auto" for automatic detection with mayura:v1
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslateRequestSourceLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="as-IN")]
        AsIn,
        /// <summary>
        /// v1
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
    public static class TranslateRequestSourceLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateRequestSourceLanguageCode value)
        {
            return value switch
            {
                TranslateRequestSourceLanguageCode.AsIn => "as-IN",
                TranslateRequestSourceLanguageCode.Auto => "auto",
                TranslateRequestSourceLanguageCode.BnIn => "bn-IN",
                TranslateRequestSourceLanguageCode.BrxIn => "brx-IN",
                TranslateRequestSourceLanguageCode.DoiIn => "doi-IN",
                TranslateRequestSourceLanguageCode.EnIn => "en-IN",
                TranslateRequestSourceLanguageCode.GuIn => "gu-IN",
                TranslateRequestSourceLanguageCode.HiIn => "hi-IN",
                TranslateRequestSourceLanguageCode.KnIn => "kn-IN",
                TranslateRequestSourceLanguageCode.KokIn => "kok-IN",
                TranslateRequestSourceLanguageCode.KsIn => "ks-IN",
                TranslateRequestSourceLanguageCode.MaiIn => "mai-IN",
                TranslateRequestSourceLanguageCode.MlIn => "ml-IN",
                TranslateRequestSourceLanguageCode.MniIn => "mni-IN",
                TranslateRequestSourceLanguageCode.MrIn => "mr-IN",
                TranslateRequestSourceLanguageCode.NeIn => "ne-IN",
                TranslateRequestSourceLanguageCode.OdIn => "od-IN",
                TranslateRequestSourceLanguageCode.PaIn => "pa-IN",
                TranslateRequestSourceLanguageCode.SaIn => "sa-IN",
                TranslateRequestSourceLanguageCode.SatIn => "sat-IN",
                TranslateRequestSourceLanguageCode.SdIn => "sd-IN",
                TranslateRequestSourceLanguageCode.TaIn => "ta-IN",
                TranslateRequestSourceLanguageCode.TeIn => "te-IN",
                TranslateRequestSourceLanguageCode.UrIn => "ur-IN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateRequestSourceLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "as-IN" => TranslateRequestSourceLanguageCode.AsIn,
                "auto" => TranslateRequestSourceLanguageCode.Auto,
                "bn-IN" => TranslateRequestSourceLanguageCode.BnIn,
                "brx-IN" => TranslateRequestSourceLanguageCode.BrxIn,
                "doi-IN" => TranslateRequestSourceLanguageCode.DoiIn,
                "en-IN" => TranslateRequestSourceLanguageCode.EnIn,
                "gu-IN" => TranslateRequestSourceLanguageCode.GuIn,
                "hi-IN" => TranslateRequestSourceLanguageCode.HiIn,
                "kn-IN" => TranslateRequestSourceLanguageCode.KnIn,
                "kok-IN" => TranslateRequestSourceLanguageCode.KokIn,
                "ks-IN" => TranslateRequestSourceLanguageCode.KsIn,
                "mai-IN" => TranslateRequestSourceLanguageCode.MaiIn,
                "ml-IN" => TranslateRequestSourceLanguageCode.MlIn,
                "mni-IN" => TranslateRequestSourceLanguageCode.MniIn,
                "mr-IN" => TranslateRequestSourceLanguageCode.MrIn,
                "ne-IN" => TranslateRequestSourceLanguageCode.NeIn,
                "od-IN" => TranslateRequestSourceLanguageCode.OdIn,
                "pa-IN" => TranslateRequestSourceLanguageCode.PaIn,
                "sa-IN" => TranslateRequestSourceLanguageCode.SaIn,
                "sat-IN" => TranslateRequestSourceLanguageCode.SatIn,
                "sd-IN" => TranslateRequestSourceLanguageCode.SdIn,
                "ta-IN" => TranslateRequestSourceLanguageCode.TaIn,
                "te-IN" => TranslateRequestSourceLanguageCode.TeIn,
                "ur-IN" => TranslateRequestSourceLanguageCode.UrIn,
                _ => null,
            };
        }
    }
}