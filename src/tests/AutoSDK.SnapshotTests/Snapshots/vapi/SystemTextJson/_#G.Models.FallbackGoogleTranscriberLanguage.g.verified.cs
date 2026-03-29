//HintName: G.Models.FallbackGoogleTranscriberLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    public enum FallbackGoogleTranscriberLanguage
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
    public static class FallbackGoogleTranscriberLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackGoogleTranscriberLanguage value)
        {
            return value switch
            {
                FallbackGoogleTranscriberLanguage.Arabic => "Arabic",
                FallbackGoogleTranscriberLanguage.Bengali => "Bengali",
                FallbackGoogleTranscriberLanguage.Bulgarian => "Bulgarian",
                FallbackGoogleTranscriberLanguage.Chinese => "Chinese",
                FallbackGoogleTranscriberLanguage.Croatian => "Croatian",
                FallbackGoogleTranscriberLanguage.Czech => "Czech",
                FallbackGoogleTranscriberLanguage.Danish => "Danish",
                FallbackGoogleTranscriberLanguage.Dutch => "Dutch",
                FallbackGoogleTranscriberLanguage.English => "English",
                FallbackGoogleTranscriberLanguage.Estonian => "Estonian",
                FallbackGoogleTranscriberLanguage.Finnish => "Finnish",
                FallbackGoogleTranscriberLanguage.French => "French",
                FallbackGoogleTranscriberLanguage.German => "German",
                FallbackGoogleTranscriberLanguage.Greek => "Greek",
                FallbackGoogleTranscriberLanguage.Hebrew => "Hebrew",
                FallbackGoogleTranscriberLanguage.Hindi => "Hindi",
                FallbackGoogleTranscriberLanguage.Hungarian => "Hungarian",
                FallbackGoogleTranscriberLanguage.Indonesian => "Indonesian",
                FallbackGoogleTranscriberLanguage.Italian => "Italian",
                FallbackGoogleTranscriberLanguage.Japanese => "Japanese",
                FallbackGoogleTranscriberLanguage.Korean => "Korean",
                FallbackGoogleTranscriberLanguage.Latvian => "Latvian",
                FallbackGoogleTranscriberLanguage.Lithuanian => "Lithuanian",
                FallbackGoogleTranscriberLanguage.Multilingual => "Multilingual",
                FallbackGoogleTranscriberLanguage.Norwegian => "Norwegian",
                FallbackGoogleTranscriberLanguage.Polish => "Polish",
                FallbackGoogleTranscriberLanguage.Portuguese => "Portuguese",
                FallbackGoogleTranscriberLanguage.Romanian => "Romanian",
                FallbackGoogleTranscriberLanguage.Russian => "Russian",
                FallbackGoogleTranscriberLanguage.Serbian => "Serbian",
                FallbackGoogleTranscriberLanguage.Slovak => "Slovak",
                FallbackGoogleTranscriberLanguage.Slovenian => "Slovenian",
                FallbackGoogleTranscriberLanguage.Spanish => "Spanish",
                FallbackGoogleTranscriberLanguage.Swahili => "Swahili",
                FallbackGoogleTranscriberLanguage.Swedish => "Swedish",
                FallbackGoogleTranscriberLanguage.Thai => "Thai",
                FallbackGoogleTranscriberLanguage.Turkish => "Turkish",
                FallbackGoogleTranscriberLanguage.Ukrainian => "Ukrainian",
                FallbackGoogleTranscriberLanguage.Vietnamese => "Vietnamese",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackGoogleTranscriberLanguage? ToEnum(string value)
        {
            return value switch
            {
                "Arabic" => FallbackGoogleTranscriberLanguage.Arabic,
                "Bengali" => FallbackGoogleTranscriberLanguage.Bengali,
                "Bulgarian" => FallbackGoogleTranscriberLanguage.Bulgarian,
                "Chinese" => FallbackGoogleTranscriberLanguage.Chinese,
                "Croatian" => FallbackGoogleTranscriberLanguage.Croatian,
                "Czech" => FallbackGoogleTranscriberLanguage.Czech,
                "Danish" => FallbackGoogleTranscriberLanguage.Danish,
                "Dutch" => FallbackGoogleTranscriberLanguage.Dutch,
                "English" => FallbackGoogleTranscriberLanguage.English,
                "Estonian" => FallbackGoogleTranscriberLanguage.Estonian,
                "Finnish" => FallbackGoogleTranscriberLanguage.Finnish,
                "French" => FallbackGoogleTranscriberLanguage.French,
                "German" => FallbackGoogleTranscriberLanguage.German,
                "Greek" => FallbackGoogleTranscriberLanguage.Greek,
                "Hebrew" => FallbackGoogleTranscriberLanguage.Hebrew,
                "Hindi" => FallbackGoogleTranscriberLanguage.Hindi,
                "Hungarian" => FallbackGoogleTranscriberLanguage.Hungarian,
                "Indonesian" => FallbackGoogleTranscriberLanguage.Indonesian,
                "Italian" => FallbackGoogleTranscriberLanguage.Italian,
                "Japanese" => FallbackGoogleTranscriberLanguage.Japanese,
                "Korean" => FallbackGoogleTranscriberLanguage.Korean,
                "Latvian" => FallbackGoogleTranscriberLanguage.Latvian,
                "Lithuanian" => FallbackGoogleTranscriberLanguage.Lithuanian,
                "Multilingual" => FallbackGoogleTranscriberLanguage.Multilingual,
                "Norwegian" => FallbackGoogleTranscriberLanguage.Norwegian,
                "Polish" => FallbackGoogleTranscriberLanguage.Polish,
                "Portuguese" => FallbackGoogleTranscriberLanguage.Portuguese,
                "Romanian" => FallbackGoogleTranscriberLanguage.Romanian,
                "Russian" => FallbackGoogleTranscriberLanguage.Russian,
                "Serbian" => FallbackGoogleTranscriberLanguage.Serbian,
                "Slovak" => FallbackGoogleTranscriberLanguage.Slovak,
                "Slovenian" => FallbackGoogleTranscriberLanguage.Slovenian,
                "Spanish" => FallbackGoogleTranscriberLanguage.Spanish,
                "Swahili" => FallbackGoogleTranscriberLanguage.Swahili,
                "Swedish" => FallbackGoogleTranscriberLanguage.Swedish,
                "Thai" => FallbackGoogleTranscriberLanguage.Thai,
                "Turkish" => FallbackGoogleTranscriberLanguage.Turkish,
                "Ukrainian" => FallbackGoogleTranscriberLanguage.Ukrainian,
                "Vietnamese" => FallbackGoogleTranscriberLanguage.Vietnamese,
                _ => null,
            };
        }
    }
}