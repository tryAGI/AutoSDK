//HintName: G.Models.FallbackPlayHTVoiceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language to use for the speech.
    /// </summary>
    public enum FallbackPlayHTVoiceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Afrikaans,
        /// <summary>
        /// 
        /// </summary>
        Albanian,
        /// <summary>
        /// 
        /// </summary>
        Amharic,
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
        Catalan,
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
        French,
        /// <summary>
        /// 
        /// </summary>
        Galician,
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
        Mandarin,
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
        Russian,
        /// <summary>
        /// 
        /// </summary>
        Serbian,
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
        Tagalog,
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
        Urdu,
        /// <summary>
        /// 
        /// </summary>
        Xhosa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackPlayHTVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackPlayHTVoiceLanguage value)
        {
            return value switch
            {
                FallbackPlayHTVoiceLanguage.Afrikaans => "afrikaans",
                FallbackPlayHTVoiceLanguage.Albanian => "albanian",
                FallbackPlayHTVoiceLanguage.Amharic => "amharic",
                FallbackPlayHTVoiceLanguage.Arabic => "arabic",
                FallbackPlayHTVoiceLanguage.Bengali => "bengali",
                FallbackPlayHTVoiceLanguage.Bulgarian => "bulgarian",
                FallbackPlayHTVoiceLanguage.Catalan => "catalan",
                FallbackPlayHTVoiceLanguage.Croatian => "croatian",
                FallbackPlayHTVoiceLanguage.Czech => "czech",
                FallbackPlayHTVoiceLanguage.Danish => "danish",
                FallbackPlayHTVoiceLanguage.Dutch => "dutch",
                FallbackPlayHTVoiceLanguage.English => "english",
                FallbackPlayHTVoiceLanguage.French => "french",
                FallbackPlayHTVoiceLanguage.Galician => "galician",
                FallbackPlayHTVoiceLanguage.German => "german",
                FallbackPlayHTVoiceLanguage.Greek => "greek",
                FallbackPlayHTVoiceLanguage.Hebrew => "hebrew",
                FallbackPlayHTVoiceLanguage.Hindi => "hindi",
                FallbackPlayHTVoiceLanguage.Hungarian => "hungarian",
                FallbackPlayHTVoiceLanguage.Indonesian => "indonesian",
                FallbackPlayHTVoiceLanguage.Italian => "italian",
                FallbackPlayHTVoiceLanguage.Japanese => "japanese",
                FallbackPlayHTVoiceLanguage.Korean => "korean",
                FallbackPlayHTVoiceLanguage.Malay => "malay",
                FallbackPlayHTVoiceLanguage.Mandarin => "mandarin",
                FallbackPlayHTVoiceLanguage.Polish => "polish",
                FallbackPlayHTVoiceLanguage.Portuguese => "portuguese",
                FallbackPlayHTVoiceLanguage.Russian => "russian",
                FallbackPlayHTVoiceLanguage.Serbian => "serbian",
                FallbackPlayHTVoiceLanguage.Spanish => "spanish",
                FallbackPlayHTVoiceLanguage.Swedish => "swedish",
                FallbackPlayHTVoiceLanguage.Tagalog => "tagalog",
                FallbackPlayHTVoiceLanguage.Thai => "thai",
                FallbackPlayHTVoiceLanguage.Turkish => "turkish",
                FallbackPlayHTVoiceLanguage.Ukrainian => "ukrainian",
                FallbackPlayHTVoiceLanguage.Urdu => "urdu",
                FallbackPlayHTVoiceLanguage.Xhosa => "xhosa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackPlayHTVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "afrikaans" => FallbackPlayHTVoiceLanguage.Afrikaans,
                "albanian" => FallbackPlayHTVoiceLanguage.Albanian,
                "amharic" => FallbackPlayHTVoiceLanguage.Amharic,
                "arabic" => FallbackPlayHTVoiceLanguage.Arabic,
                "bengali" => FallbackPlayHTVoiceLanguage.Bengali,
                "bulgarian" => FallbackPlayHTVoiceLanguage.Bulgarian,
                "catalan" => FallbackPlayHTVoiceLanguage.Catalan,
                "croatian" => FallbackPlayHTVoiceLanguage.Croatian,
                "czech" => FallbackPlayHTVoiceLanguage.Czech,
                "danish" => FallbackPlayHTVoiceLanguage.Danish,
                "dutch" => FallbackPlayHTVoiceLanguage.Dutch,
                "english" => FallbackPlayHTVoiceLanguage.English,
                "french" => FallbackPlayHTVoiceLanguage.French,
                "galician" => FallbackPlayHTVoiceLanguage.Galician,
                "german" => FallbackPlayHTVoiceLanguage.German,
                "greek" => FallbackPlayHTVoiceLanguage.Greek,
                "hebrew" => FallbackPlayHTVoiceLanguage.Hebrew,
                "hindi" => FallbackPlayHTVoiceLanguage.Hindi,
                "hungarian" => FallbackPlayHTVoiceLanguage.Hungarian,
                "indonesian" => FallbackPlayHTVoiceLanguage.Indonesian,
                "italian" => FallbackPlayHTVoiceLanguage.Italian,
                "japanese" => FallbackPlayHTVoiceLanguage.Japanese,
                "korean" => FallbackPlayHTVoiceLanguage.Korean,
                "malay" => FallbackPlayHTVoiceLanguage.Malay,
                "mandarin" => FallbackPlayHTVoiceLanguage.Mandarin,
                "polish" => FallbackPlayHTVoiceLanguage.Polish,
                "portuguese" => FallbackPlayHTVoiceLanguage.Portuguese,
                "russian" => FallbackPlayHTVoiceLanguage.Russian,
                "serbian" => FallbackPlayHTVoiceLanguage.Serbian,
                "spanish" => FallbackPlayHTVoiceLanguage.Spanish,
                "swedish" => FallbackPlayHTVoiceLanguage.Swedish,
                "tagalog" => FallbackPlayHTVoiceLanguage.Tagalog,
                "thai" => FallbackPlayHTVoiceLanguage.Thai,
                "turkish" => FallbackPlayHTVoiceLanguage.Turkish,
                "ukrainian" => FallbackPlayHTVoiceLanguage.Ukrainian,
                "urdu" => FallbackPlayHTVoiceLanguage.Urdu,
                "xhosa" => FallbackPlayHTVoiceLanguage.Xhosa,
                _ => null,
            };
        }
    }
}