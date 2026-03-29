//HintName: G.Models.SupportedLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SupportedLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Afrikaans")]
        Afrikaans,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Arabic")]
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bulgarian")]
        Bulgarian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Catalan")]
        Catalan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Chinese")]
        Chinese,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Chinese,Yue")]
        Chinese_Yue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Croatian")]
        Croatian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Czech")]
        Czech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Danish")]
        Danish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Dutch")]
        Dutch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="English")]
        English,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Filipino")]
        Filipino,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Finnish")]
        Finnish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="French")]
        French,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="German")]
        German,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Greek")]
        Greek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Hebrew")]
        Hebrew,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Hindi")]
        Hindi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Hungarian")]
        Hungarian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Indonesian")]
        Indonesian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Italian")]
        Italian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Japanese")]
        Japanese,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Korean")]
        Korean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Malay")]
        Malay,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Norwegian")]
        Norwegian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Nynorsk")]
        Nynorsk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Persian")]
        Persian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Polish")]
        Polish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Portuguese")]
        Portuguese,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Romanian")]
        Romanian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Russian")]
        Russian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Slovak")]
        Slovak,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Slovenian")]
        Slovenian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Spanish")]
        Spanish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Swedish")]
        Swedish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Tamil")]
        Tamil,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Thai")]
        Thai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Turkish")]
        Turkish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Ukrainian")]
        Ukrainian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Vietnamese")]
        Vietnamese,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupportedLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedLanguage value)
        {
            return value switch
            {
                SupportedLanguage.Afrikaans => "Afrikaans",
                SupportedLanguage.Arabic => "Arabic",
                SupportedLanguage.Bulgarian => "Bulgarian",
                SupportedLanguage.Catalan => "Catalan",
                SupportedLanguage.Chinese => "Chinese",
                SupportedLanguage.Chinese_Yue => "Chinese,Yue",
                SupportedLanguage.Croatian => "Croatian",
                SupportedLanguage.Czech => "Czech",
                SupportedLanguage.Danish => "Danish",
                SupportedLanguage.Dutch => "Dutch",
                SupportedLanguage.English => "English",
                SupportedLanguage.Filipino => "Filipino",
                SupportedLanguage.Finnish => "Finnish",
                SupportedLanguage.French => "French",
                SupportedLanguage.German => "German",
                SupportedLanguage.Greek => "Greek",
                SupportedLanguage.Hebrew => "Hebrew",
                SupportedLanguage.Hindi => "Hindi",
                SupportedLanguage.Hungarian => "Hungarian",
                SupportedLanguage.Indonesian => "Indonesian",
                SupportedLanguage.Italian => "Italian",
                SupportedLanguage.Japanese => "Japanese",
                SupportedLanguage.Korean => "Korean",
                SupportedLanguage.Malay => "Malay",
                SupportedLanguage.Norwegian => "Norwegian",
                SupportedLanguage.Nynorsk => "Nynorsk",
                SupportedLanguage.Persian => "Persian",
                SupportedLanguage.Polish => "Polish",
                SupportedLanguage.Portuguese => "Portuguese",
                SupportedLanguage.Romanian => "Romanian",
                SupportedLanguage.Russian => "Russian",
                SupportedLanguage.Slovak => "Slovak",
                SupportedLanguage.Slovenian => "Slovenian",
                SupportedLanguage.Spanish => "Spanish",
                SupportedLanguage.Swedish => "Swedish",
                SupportedLanguage.Tamil => "Tamil",
                SupportedLanguage.Thai => "Thai",
                SupportedLanguage.Turkish => "Turkish",
                SupportedLanguage.Ukrainian => "Ukrainian",
                SupportedLanguage.Vietnamese => "Vietnamese",
                SupportedLanguage.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedLanguage? ToEnum(string value)
        {
            return value switch
            {
                "Afrikaans" => SupportedLanguage.Afrikaans,
                "Arabic" => SupportedLanguage.Arabic,
                "Bulgarian" => SupportedLanguage.Bulgarian,
                "Catalan" => SupportedLanguage.Catalan,
                "Chinese" => SupportedLanguage.Chinese,
                "Chinese,Yue" => SupportedLanguage.Chinese_Yue,
                "Croatian" => SupportedLanguage.Croatian,
                "Czech" => SupportedLanguage.Czech,
                "Danish" => SupportedLanguage.Danish,
                "Dutch" => SupportedLanguage.Dutch,
                "English" => SupportedLanguage.English,
                "Filipino" => SupportedLanguage.Filipino,
                "Finnish" => SupportedLanguage.Finnish,
                "French" => SupportedLanguage.French,
                "German" => SupportedLanguage.German,
                "Greek" => SupportedLanguage.Greek,
                "Hebrew" => SupportedLanguage.Hebrew,
                "Hindi" => SupportedLanguage.Hindi,
                "Hungarian" => SupportedLanguage.Hungarian,
                "Indonesian" => SupportedLanguage.Indonesian,
                "Italian" => SupportedLanguage.Italian,
                "Japanese" => SupportedLanguage.Japanese,
                "Korean" => SupportedLanguage.Korean,
                "Malay" => SupportedLanguage.Malay,
                "Norwegian" => SupportedLanguage.Norwegian,
                "Nynorsk" => SupportedLanguage.Nynorsk,
                "Persian" => SupportedLanguage.Persian,
                "Polish" => SupportedLanguage.Polish,
                "Portuguese" => SupportedLanguage.Portuguese,
                "Romanian" => SupportedLanguage.Romanian,
                "Russian" => SupportedLanguage.Russian,
                "Slovak" => SupportedLanguage.Slovak,
                "Slovenian" => SupportedLanguage.Slovenian,
                "Spanish" => SupportedLanguage.Spanish,
                "Swedish" => SupportedLanguage.Swedish,
                "Tamil" => SupportedLanguage.Tamil,
                "Thai" => SupportedLanguage.Thai,
                "Turkish" => SupportedLanguage.Turkish,
                "Ukrainian" => SupportedLanguage.Ukrainian,
                "Vietnamese" => SupportedLanguage.Vietnamese,
                "auto" => SupportedLanguage.Auto,
                _ => null,
            };
        }
    }
}