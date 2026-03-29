//HintName: G.Models.FallbackMinimaxVoiceLanguageBoost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language hint for MiniMax T2A. Example: yue (Cantonese), zh (Chinese), en (English).
    /// </summary>
    public enum FallbackMinimaxVoiceLanguageBoost
    {
        /// <summary>
        /// 
        /// </summary>
        Afrikaans,
        /// <summary>
        /// 
        /// </summary>
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        Bulgarian,
        /// <summary>
        /// 
        /// </summary>
        Catalan,
        /// <summary>
        /// yue (Cantonese), zh (Chinese), en (English).
        /// </summary>
        Chinese,
        /// <summary>
        /// 
        /// </summary>
        Chinese_Yue,
        /// <summary>
        /// 
        /// </summary>
        Croatian,
        /// <summary>
        /// 
        /// </summary>
        Czech,
        /// <summary>
        /// 
        /// </summary>
        Danish,
        /// <summary>
        /// 
        /// </summary>
        Dutch,
        /// <summary>
        /// yue (Cantonese), zh (Chinese), en (English).
        /// </summary>
        English,
        /// <summary>
        /// 
        /// </summary>
        Filipino,
        /// <summary>
        /// 
        /// </summary>
        Finnish,
        /// <summary>
        /// 
        /// </summary>
        French,
        /// <summary>
        /// 
        /// </summary>
        German,
        /// <summary>
        /// 
        /// </summary>
        Greek,
        /// <summary>
        /// 
        /// </summary>
        Hebrew,
        /// <summary>
        /// 
        /// </summary>
        Hindi,
        /// <summary>
        /// 
        /// </summary>
        Hungarian,
        /// <summary>
        /// 
        /// </summary>
        Indonesian,
        /// <summary>
        /// 
        /// </summary>
        Italian,
        /// <summary>
        /// 
        /// </summary>
        Japanese,
        /// <summary>
        /// 
        /// </summary>
        Korean,
        /// <summary>
        /// 
        /// </summary>
        Malay,
        /// <summary>
        /// 
        /// </summary>
        Norwegian,
        /// <summary>
        /// 
        /// </summary>
        Nynorsk,
        /// <summary>
        /// 
        /// </summary>
        Persian,
        /// <summary>
        /// 
        /// </summary>
        Polish,
        /// <summary>
        /// 
        /// </summary>
        Portuguese,
        /// <summary>
        /// 
        /// </summary>
        Romanian,
        /// <summary>
        /// 
        /// </summary>
        Russian,
        /// <summary>
        /// 
        /// </summary>
        Slovak,
        /// <summary>
        /// 
        /// </summary>
        Slovenian,
        /// <summary>
        /// 
        /// </summary>
        Spanish,
        /// <summary>
        /// 
        /// </summary>
        Swedish,
        /// <summary>
        /// 
        /// </summary>
        Tamil,
        /// <summary>
        /// 
        /// </summary>
        Thai,
        /// <summary>
        /// 
        /// </summary>
        Turkish,
        /// <summary>
        /// 
        /// </summary>
        Ukrainian,
        /// <summary>
        /// 
        /// </summary>
        Vietnamese,
        /// <summary>
        /// 
        /// </summary>
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