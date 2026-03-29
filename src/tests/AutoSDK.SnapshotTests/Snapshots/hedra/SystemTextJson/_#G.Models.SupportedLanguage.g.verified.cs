//HintName: G.Models.SupportedLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SupportedLanguage
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
        /// 
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
        /// 
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