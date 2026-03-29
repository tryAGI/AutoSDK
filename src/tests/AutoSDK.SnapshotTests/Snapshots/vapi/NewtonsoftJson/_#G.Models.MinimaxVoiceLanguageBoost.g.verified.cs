//HintName: G.Models.MinimaxVoiceLanguageBoost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language hint for MiniMax T2A. Example: yue (Cantonese), zh (Chinese), en (English).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MinimaxVoiceLanguageBoost
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
    public static class MinimaxVoiceLanguageBoostExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimaxVoiceLanguageBoost value)
        {
            return value switch
            {
                MinimaxVoiceLanguageBoost.Afrikaans => "Afrikaans",
                MinimaxVoiceLanguageBoost.Arabic => "Arabic",
                MinimaxVoiceLanguageBoost.Bulgarian => "Bulgarian",
                MinimaxVoiceLanguageBoost.Catalan => "Catalan",
                MinimaxVoiceLanguageBoost.Chinese => "Chinese",
                MinimaxVoiceLanguageBoost.Chinese_Yue => "Chinese,Yue",
                MinimaxVoiceLanguageBoost.Croatian => "Croatian",
                MinimaxVoiceLanguageBoost.Czech => "Czech",
                MinimaxVoiceLanguageBoost.Danish => "Danish",
                MinimaxVoiceLanguageBoost.Dutch => "Dutch",
                MinimaxVoiceLanguageBoost.English => "English",
                MinimaxVoiceLanguageBoost.Filipino => "Filipino",
                MinimaxVoiceLanguageBoost.Finnish => "Finnish",
                MinimaxVoiceLanguageBoost.French => "French",
                MinimaxVoiceLanguageBoost.German => "German",
                MinimaxVoiceLanguageBoost.Greek => "Greek",
                MinimaxVoiceLanguageBoost.Hebrew => "Hebrew",
                MinimaxVoiceLanguageBoost.Hindi => "Hindi",
                MinimaxVoiceLanguageBoost.Hungarian => "Hungarian",
                MinimaxVoiceLanguageBoost.Indonesian => "Indonesian",
                MinimaxVoiceLanguageBoost.Italian => "Italian",
                MinimaxVoiceLanguageBoost.Japanese => "Japanese",
                MinimaxVoiceLanguageBoost.Korean => "Korean",
                MinimaxVoiceLanguageBoost.Malay => "Malay",
                MinimaxVoiceLanguageBoost.Norwegian => "Norwegian",
                MinimaxVoiceLanguageBoost.Nynorsk => "Nynorsk",
                MinimaxVoiceLanguageBoost.Persian => "Persian",
                MinimaxVoiceLanguageBoost.Polish => "Polish",
                MinimaxVoiceLanguageBoost.Portuguese => "Portuguese",
                MinimaxVoiceLanguageBoost.Romanian => "Romanian",
                MinimaxVoiceLanguageBoost.Russian => "Russian",
                MinimaxVoiceLanguageBoost.Slovak => "Slovak",
                MinimaxVoiceLanguageBoost.Slovenian => "Slovenian",
                MinimaxVoiceLanguageBoost.Spanish => "Spanish",
                MinimaxVoiceLanguageBoost.Swedish => "Swedish",
                MinimaxVoiceLanguageBoost.Tamil => "Tamil",
                MinimaxVoiceLanguageBoost.Thai => "Thai",
                MinimaxVoiceLanguageBoost.Turkish => "Turkish",
                MinimaxVoiceLanguageBoost.Ukrainian => "Ukrainian",
                MinimaxVoiceLanguageBoost.Vietnamese => "Vietnamese",
                MinimaxVoiceLanguageBoost.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimaxVoiceLanguageBoost? ToEnum(string value)
        {
            return value switch
            {
                "Afrikaans" => MinimaxVoiceLanguageBoost.Afrikaans,
                "Arabic" => MinimaxVoiceLanguageBoost.Arabic,
                "Bulgarian" => MinimaxVoiceLanguageBoost.Bulgarian,
                "Catalan" => MinimaxVoiceLanguageBoost.Catalan,
                "Chinese" => MinimaxVoiceLanguageBoost.Chinese,
                "Chinese,Yue" => MinimaxVoiceLanguageBoost.Chinese_Yue,
                "Croatian" => MinimaxVoiceLanguageBoost.Croatian,
                "Czech" => MinimaxVoiceLanguageBoost.Czech,
                "Danish" => MinimaxVoiceLanguageBoost.Danish,
                "Dutch" => MinimaxVoiceLanguageBoost.Dutch,
                "English" => MinimaxVoiceLanguageBoost.English,
                "Filipino" => MinimaxVoiceLanguageBoost.Filipino,
                "Finnish" => MinimaxVoiceLanguageBoost.Finnish,
                "French" => MinimaxVoiceLanguageBoost.French,
                "German" => MinimaxVoiceLanguageBoost.German,
                "Greek" => MinimaxVoiceLanguageBoost.Greek,
                "Hebrew" => MinimaxVoiceLanguageBoost.Hebrew,
                "Hindi" => MinimaxVoiceLanguageBoost.Hindi,
                "Hungarian" => MinimaxVoiceLanguageBoost.Hungarian,
                "Indonesian" => MinimaxVoiceLanguageBoost.Indonesian,
                "Italian" => MinimaxVoiceLanguageBoost.Italian,
                "Japanese" => MinimaxVoiceLanguageBoost.Japanese,
                "Korean" => MinimaxVoiceLanguageBoost.Korean,
                "Malay" => MinimaxVoiceLanguageBoost.Malay,
                "Norwegian" => MinimaxVoiceLanguageBoost.Norwegian,
                "Nynorsk" => MinimaxVoiceLanguageBoost.Nynorsk,
                "Persian" => MinimaxVoiceLanguageBoost.Persian,
                "Polish" => MinimaxVoiceLanguageBoost.Polish,
                "Portuguese" => MinimaxVoiceLanguageBoost.Portuguese,
                "Romanian" => MinimaxVoiceLanguageBoost.Romanian,
                "Russian" => MinimaxVoiceLanguageBoost.Russian,
                "Slovak" => MinimaxVoiceLanguageBoost.Slovak,
                "Slovenian" => MinimaxVoiceLanguageBoost.Slovenian,
                "Spanish" => MinimaxVoiceLanguageBoost.Spanish,
                "Swedish" => MinimaxVoiceLanguageBoost.Swedish,
                "Tamil" => MinimaxVoiceLanguageBoost.Tamil,
                "Thai" => MinimaxVoiceLanguageBoost.Thai,
                "Turkish" => MinimaxVoiceLanguageBoost.Turkish,
                "Ukrainian" => MinimaxVoiceLanguageBoost.Ukrainian,
                "Vietnamese" => MinimaxVoiceLanguageBoost.Vietnamese,
                "auto" => MinimaxVoiceLanguageBoost.Auto,
                _ => null,
            };
        }
    }
}