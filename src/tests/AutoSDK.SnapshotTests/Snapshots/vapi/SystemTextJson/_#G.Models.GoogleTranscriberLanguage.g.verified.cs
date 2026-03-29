//HintName: G.Models.GoogleTranscriberLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    public enum GoogleTranscriberLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        Bengali,
        /// <summary>
        /// 
        /// </summary>
        Bulgarian,
        /// <summary>
        /// 
        /// </summary>
        Chinese,
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
        Estonian,
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
        Latvian,
        /// <summary>
        /// 
        /// </summary>
        Lithuanian,
        /// <summary>
        /// 
        /// </summary>
        Multilingual,
        /// <summary>
        /// 
        /// </summary>
        Norwegian,
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
        Serbian,
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
        Swahili,
        /// <summary>
        /// 
        /// </summary>
        Swedish,
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