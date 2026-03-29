//HintName: G.Models.GoogleTranscriberLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleTranscriberLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Arabic")]
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bengali")]
        Bengali,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bulgarian")]
        Bulgarian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Chinese")]
        Chinese,
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
        [global::System.Runtime.Serialization.EnumMember(Value="Estonian")]
        Estonian,
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
        [global::System.Runtime.Serialization.EnumMember(Value="Latvian")]
        Latvian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Lithuanian")]
        Lithuanian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Multilingual")]
        Multilingual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Norwegian")]
        Norwegian,
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
        [global::System.Runtime.Serialization.EnumMember(Value="Serbian")]
        Serbian,
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
        [global::System.Runtime.Serialization.EnumMember(Value="Swahili")]
        Swahili,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Swedish")]
        Swedish,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleTranscriberLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleTranscriberLanguage value)
        {
            return value switch
            {
                GoogleTranscriberLanguage.Arabic => "Arabic",
                GoogleTranscriberLanguage.Bengali => "Bengali",
                GoogleTranscriberLanguage.Bulgarian => "Bulgarian",
                GoogleTranscriberLanguage.Chinese => "Chinese",
                GoogleTranscriberLanguage.Croatian => "Croatian",
                GoogleTranscriberLanguage.Czech => "Czech",
                GoogleTranscriberLanguage.Danish => "Danish",
                GoogleTranscriberLanguage.Dutch => "Dutch",
                GoogleTranscriberLanguage.English => "English",
                GoogleTranscriberLanguage.Estonian => "Estonian",
                GoogleTranscriberLanguage.Finnish => "Finnish",
                GoogleTranscriberLanguage.French => "French",
                GoogleTranscriberLanguage.German => "German",
                GoogleTranscriberLanguage.Greek => "Greek",
                GoogleTranscriberLanguage.Hebrew => "Hebrew",
                GoogleTranscriberLanguage.Hindi => "Hindi",
                GoogleTranscriberLanguage.Hungarian => "Hungarian",
                GoogleTranscriberLanguage.Indonesian => "Indonesian",
                GoogleTranscriberLanguage.Italian => "Italian",
                GoogleTranscriberLanguage.Japanese => "Japanese",
                GoogleTranscriberLanguage.Korean => "Korean",
                GoogleTranscriberLanguage.Latvian => "Latvian",
                GoogleTranscriberLanguage.Lithuanian => "Lithuanian",
                GoogleTranscriberLanguage.Multilingual => "Multilingual",
                GoogleTranscriberLanguage.Norwegian => "Norwegian",
                GoogleTranscriberLanguage.Polish => "Polish",
                GoogleTranscriberLanguage.Portuguese => "Portuguese",
                GoogleTranscriberLanguage.Romanian => "Romanian",
                GoogleTranscriberLanguage.Russian => "Russian",
                GoogleTranscriberLanguage.Serbian => "Serbian",
                GoogleTranscriberLanguage.Slovak => "Slovak",
                GoogleTranscriberLanguage.Slovenian => "Slovenian",
                GoogleTranscriberLanguage.Spanish => "Spanish",
                GoogleTranscriberLanguage.Swahili => "Swahili",
                GoogleTranscriberLanguage.Swedish => "Swedish",
                GoogleTranscriberLanguage.Thai => "Thai",
                GoogleTranscriberLanguage.Turkish => "Turkish",
                GoogleTranscriberLanguage.Ukrainian => "Ukrainian",
                GoogleTranscriberLanguage.Vietnamese => "Vietnamese",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleTranscriberLanguage? ToEnum(string value)
        {
            return value switch
            {
                "Arabic" => GoogleTranscriberLanguage.Arabic,
                "Bengali" => GoogleTranscriberLanguage.Bengali,
                "Bulgarian" => GoogleTranscriberLanguage.Bulgarian,
                "Chinese" => GoogleTranscriberLanguage.Chinese,
                "Croatian" => GoogleTranscriberLanguage.Croatian,
                "Czech" => GoogleTranscriberLanguage.Czech,
                "Danish" => GoogleTranscriberLanguage.Danish,
                "Dutch" => GoogleTranscriberLanguage.Dutch,
                "English" => GoogleTranscriberLanguage.English,
                "Estonian" => GoogleTranscriberLanguage.Estonian,
                "Finnish" => GoogleTranscriberLanguage.Finnish,
                "French" => GoogleTranscriberLanguage.French,
                "German" => GoogleTranscriberLanguage.German,
                "Greek" => GoogleTranscriberLanguage.Greek,
                "Hebrew" => GoogleTranscriberLanguage.Hebrew,
                "Hindi" => GoogleTranscriberLanguage.Hindi,
                "Hungarian" => GoogleTranscriberLanguage.Hungarian,
                "Indonesian" => GoogleTranscriberLanguage.Indonesian,
                "Italian" => GoogleTranscriberLanguage.Italian,
                "Japanese" => GoogleTranscriberLanguage.Japanese,
                "Korean" => GoogleTranscriberLanguage.Korean,
                "Latvian" => GoogleTranscriberLanguage.Latvian,
                "Lithuanian" => GoogleTranscriberLanguage.Lithuanian,
                "Multilingual" => GoogleTranscriberLanguage.Multilingual,
                "Norwegian" => GoogleTranscriberLanguage.Norwegian,
                "Polish" => GoogleTranscriberLanguage.Polish,
                "Portuguese" => GoogleTranscriberLanguage.Portuguese,
                "Romanian" => GoogleTranscriberLanguage.Romanian,
                "Russian" => GoogleTranscriberLanguage.Russian,
                "Serbian" => GoogleTranscriberLanguage.Serbian,
                "Slovak" => GoogleTranscriberLanguage.Slovak,
                "Slovenian" => GoogleTranscriberLanguage.Slovenian,
                "Spanish" => GoogleTranscriberLanguage.Spanish,
                "Swahili" => GoogleTranscriberLanguage.Swahili,
                "Swedish" => GoogleTranscriberLanguage.Swedish,
                "Thai" => GoogleTranscriberLanguage.Thai,
                "Turkish" => GoogleTranscriberLanguage.Turkish,
                "Ukrainian" => GoogleTranscriberLanguage.Ukrainian,
                "Vietnamese" => GoogleTranscriberLanguage.Vietnamese,
                _ => null,
            };
        }
    }
}