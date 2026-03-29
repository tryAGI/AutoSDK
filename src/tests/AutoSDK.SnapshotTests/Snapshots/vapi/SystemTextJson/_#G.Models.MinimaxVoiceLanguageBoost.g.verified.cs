//HintName: G.Models.MinimaxVoiceLanguageBoost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language hint for MiniMax T2A. Example: yue (Cantonese), zh (Chinese), en (English).
    /// </summary>
    public enum MinimaxVoiceLanguageBoost
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