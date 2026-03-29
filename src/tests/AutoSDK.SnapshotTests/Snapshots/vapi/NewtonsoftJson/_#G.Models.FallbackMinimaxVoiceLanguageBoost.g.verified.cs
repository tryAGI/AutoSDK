//HintName: G.Models.FallbackMinimaxVoiceLanguageBoost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language hint for MiniMax T2A. Example: yue (Cantonese), zh (Chinese), en (English).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackMinimaxVoiceLanguageBoost
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
        /// yue (Cantonese), zh (Chinese), en (English).
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
        /// yue (Cantonese), zh (Chinese), en (English).
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
    public static class FallbackMinimaxVoiceLanguageBoostExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackMinimaxVoiceLanguageBoost value)
        {
            return value switch
            {
                FallbackMinimaxVoiceLanguageBoost.Afrikaans => "Afrikaans",
                FallbackMinimaxVoiceLanguageBoost.Arabic => "Arabic",
                FallbackMinimaxVoiceLanguageBoost.Bulgarian => "Bulgarian",
                FallbackMinimaxVoiceLanguageBoost.Catalan => "Catalan",
                FallbackMinimaxVoiceLanguageBoost.Chinese => "Chinese",
                FallbackMinimaxVoiceLanguageBoost.Chinese_Yue => "Chinese,Yue",
                FallbackMinimaxVoiceLanguageBoost.Croatian => "Croatian",
                FallbackMinimaxVoiceLanguageBoost.Czech => "Czech",
                FallbackMinimaxVoiceLanguageBoost.Danish => "Danish",
                FallbackMinimaxVoiceLanguageBoost.Dutch => "Dutch",
                FallbackMinimaxVoiceLanguageBoost.English => "English",
                FallbackMinimaxVoiceLanguageBoost.Filipino => "Filipino",
                FallbackMinimaxVoiceLanguageBoost.Finnish => "Finnish",
                FallbackMinimaxVoiceLanguageBoost.French => "French",
                FallbackMinimaxVoiceLanguageBoost.German => "German",
                FallbackMinimaxVoiceLanguageBoost.Greek => "Greek",
                FallbackMinimaxVoiceLanguageBoost.Hebrew => "Hebrew",
                FallbackMinimaxVoiceLanguageBoost.Hindi => "Hindi",
                FallbackMinimaxVoiceLanguageBoost.Hungarian => "Hungarian",
                FallbackMinimaxVoiceLanguageBoost.Indonesian => "Indonesian",
                FallbackMinimaxVoiceLanguageBoost.Italian => "Italian",
                FallbackMinimaxVoiceLanguageBoost.Japanese => "Japanese",
                FallbackMinimaxVoiceLanguageBoost.Korean => "Korean",
                FallbackMinimaxVoiceLanguageBoost.Malay => "Malay",
                FallbackMinimaxVoiceLanguageBoost.Norwegian => "Norwegian",
                FallbackMinimaxVoiceLanguageBoost.Nynorsk => "Nynorsk",
                FallbackMinimaxVoiceLanguageBoost.Persian => "Persian",
                FallbackMinimaxVoiceLanguageBoost.Polish => "Polish",
                FallbackMinimaxVoiceLanguageBoost.Portuguese => "Portuguese",
                FallbackMinimaxVoiceLanguageBoost.Romanian => "Romanian",
                FallbackMinimaxVoiceLanguageBoost.Russian => "Russian",
                FallbackMinimaxVoiceLanguageBoost.Slovak => "Slovak",
                FallbackMinimaxVoiceLanguageBoost.Slovenian => "Slovenian",
                FallbackMinimaxVoiceLanguageBoost.Spanish => "Spanish",
                FallbackMinimaxVoiceLanguageBoost.Swedish => "Swedish",
                FallbackMinimaxVoiceLanguageBoost.Tamil => "Tamil",
                FallbackMinimaxVoiceLanguageBoost.Thai => "Thai",
                FallbackMinimaxVoiceLanguageBoost.Turkish => "Turkish",
                FallbackMinimaxVoiceLanguageBoost.Ukrainian => "Ukrainian",
                FallbackMinimaxVoiceLanguageBoost.Vietnamese => "Vietnamese",
                FallbackMinimaxVoiceLanguageBoost.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackMinimaxVoiceLanguageBoost? ToEnum(string value)
        {
            return value switch
            {
                "Afrikaans" => FallbackMinimaxVoiceLanguageBoost.Afrikaans,
                "Arabic" => FallbackMinimaxVoiceLanguageBoost.Arabic,
                "Bulgarian" => FallbackMinimaxVoiceLanguageBoost.Bulgarian,
                "Catalan" => FallbackMinimaxVoiceLanguageBoost.Catalan,
                "Chinese" => FallbackMinimaxVoiceLanguageBoost.Chinese,
                "Chinese,Yue" => FallbackMinimaxVoiceLanguageBoost.Chinese_Yue,
                "Croatian" => FallbackMinimaxVoiceLanguageBoost.Croatian,
                "Czech" => FallbackMinimaxVoiceLanguageBoost.Czech,
                "Danish" => FallbackMinimaxVoiceLanguageBoost.Danish,
                "Dutch" => FallbackMinimaxVoiceLanguageBoost.Dutch,
                "English" => FallbackMinimaxVoiceLanguageBoost.English,
                "Filipino" => FallbackMinimaxVoiceLanguageBoost.Filipino,
                "Finnish" => FallbackMinimaxVoiceLanguageBoost.Finnish,
                "French" => FallbackMinimaxVoiceLanguageBoost.French,
                "German" => FallbackMinimaxVoiceLanguageBoost.German,
                "Greek" => FallbackMinimaxVoiceLanguageBoost.Greek,
                "Hebrew" => FallbackMinimaxVoiceLanguageBoost.Hebrew,
                "Hindi" => FallbackMinimaxVoiceLanguageBoost.Hindi,
                "Hungarian" => FallbackMinimaxVoiceLanguageBoost.Hungarian,
                "Indonesian" => FallbackMinimaxVoiceLanguageBoost.Indonesian,
                "Italian" => FallbackMinimaxVoiceLanguageBoost.Italian,
                "Japanese" => FallbackMinimaxVoiceLanguageBoost.Japanese,
                "Korean" => FallbackMinimaxVoiceLanguageBoost.Korean,
                "Malay" => FallbackMinimaxVoiceLanguageBoost.Malay,
                "Norwegian" => FallbackMinimaxVoiceLanguageBoost.Norwegian,
                "Nynorsk" => FallbackMinimaxVoiceLanguageBoost.Nynorsk,
                "Persian" => FallbackMinimaxVoiceLanguageBoost.Persian,
                "Polish" => FallbackMinimaxVoiceLanguageBoost.Polish,
                "Portuguese" => FallbackMinimaxVoiceLanguageBoost.Portuguese,
                "Romanian" => FallbackMinimaxVoiceLanguageBoost.Romanian,
                "Russian" => FallbackMinimaxVoiceLanguageBoost.Russian,
                "Slovak" => FallbackMinimaxVoiceLanguageBoost.Slovak,
                "Slovenian" => FallbackMinimaxVoiceLanguageBoost.Slovenian,
                "Spanish" => FallbackMinimaxVoiceLanguageBoost.Spanish,
                "Swedish" => FallbackMinimaxVoiceLanguageBoost.Swedish,
                "Tamil" => FallbackMinimaxVoiceLanguageBoost.Tamil,
                "Thai" => FallbackMinimaxVoiceLanguageBoost.Thai,
                "Turkish" => FallbackMinimaxVoiceLanguageBoost.Turkish,
                "Ukrainian" => FallbackMinimaxVoiceLanguageBoost.Ukrainian,
                "Vietnamese" => FallbackMinimaxVoiceLanguageBoost.Vietnamese,
                "auto" => FallbackMinimaxVoiceLanguageBoost.Auto,
                _ => null,
            };
        }
    }
}