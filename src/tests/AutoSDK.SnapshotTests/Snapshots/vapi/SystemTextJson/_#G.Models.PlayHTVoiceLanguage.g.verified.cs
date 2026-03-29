//HintName: G.Models.PlayHTVoiceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language to use for the speech.
    /// </summary>
    public enum PlayHTVoiceLanguage
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
    public static class PlayHTVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayHTVoiceLanguage value)
        {
            return value switch
            {
                PlayHTVoiceLanguage.Afrikaans => "afrikaans",
                PlayHTVoiceLanguage.Albanian => "albanian",
                PlayHTVoiceLanguage.Amharic => "amharic",
                PlayHTVoiceLanguage.Arabic => "arabic",
                PlayHTVoiceLanguage.Bengali => "bengali",
                PlayHTVoiceLanguage.Bulgarian => "bulgarian",
                PlayHTVoiceLanguage.Catalan => "catalan",
                PlayHTVoiceLanguage.Croatian => "croatian",
                PlayHTVoiceLanguage.Czech => "czech",
                PlayHTVoiceLanguage.Danish => "danish",
                PlayHTVoiceLanguage.Dutch => "dutch",
                PlayHTVoiceLanguage.English => "english",
                PlayHTVoiceLanguage.French => "french",
                PlayHTVoiceLanguage.Galician => "galician",
                PlayHTVoiceLanguage.German => "german",
                PlayHTVoiceLanguage.Greek => "greek",
                PlayHTVoiceLanguage.Hebrew => "hebrew",
                PlayHTVoiceLanguage.Hindi => "hindi",
                PlayHTVoiceLanguage.Hungarian => "hungarian",
                PlayHTVoiceLanguage.Indonesian => "indonesian",
                PlayHTVoiceLanguage.Italian => "italian",
                PlayHTVoiceLanguage.Japanese => "japanese",
                PlayHTVoiceLanguage.Korean => "korean",
                PlayHTVoiceLanguage.Malay => "malay",
                PlayHTVoiceLanguage.Mandarin => "mandarin",
                PlayHTVoiceLanguage.Polish => "polish",
                PlayHTVoiceLanguage.Portuguese => "portuguese",
                PlayHTVoiceLanguage.Russian => "russian",
                PlayHTVoiceLanguage.Serbian => "serbian",
                PlayHTVoiceLanguage.Spanish => "spanish",
                PlayHTVoiceLanguage.Swedish => "swedish",
                PlayHTVoiceLanguage.Tagalog => "tagalog",
                PlayHTVoiceLanguage.Thai => "thai",
                PlayHTVoiceLanguage.Turkish => "turkish",
                PlayHTVoiceLanguage.Ukrainian => "ukrainian",
                PlayHTVoiceLanguage.Urdu => "urdu",
                PlayHTVoiceLanguage.Xhosa => "xhosa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayHTVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "afrikaans" => PlayHTVoiceLanguage.Afrikaans,
                "albanian" => PlayHTVoiceLanguage.Albanian,
                "amharic" => PlayHTVoiceLanguage.Amharic,
                "arabic" => PlayHTVoiceLanguage.Arabic,
                "bengali" => PlayHTVoiceLanguage.Bengali,
                "bulgarian" => PlayHTVoiceLanguage.Bulgarian,
                "catalan" => PlayHTVoiceLanguage.Catalan,
                "croatian" => PlayHTVoiceLanguage.Croatian,
                "czech" => PlayHTVoiceLanguage.Czech,
                "danish" => PlayHTVoiceLanguage.Danish,
                "dutch" => PlayHTVoiceLanguage.Dutch,
                "english" => PlayHTVoiceLanguage.English,
                "french" => PlayHTVoiceLanguage.French,
                "galician" => PlayHTVoiceLanguage.Galician,
                "german" => PlayHTVoiceLanguage.German,
                "greek" => PlayHTVoiceLanguage.Greek,
                "hebrew" => PlayHTVoiceLanguage.Hebrew,
                "hindi" => PlayHTVoiceLanguage.Hindi,
                "hungarian" => PlayHTVoiceLanguage.Hungarian,
                "indonesian" => PlayHTVoiceLanguage.Indonesian,
                "italian" => PlayHTVoiceLanguage.Italian,
                "japanese" => PlayHTVoiceLanguage.Japanese,
                "korean" => PlayHTVoiceLanguage.Korean,
                "malay" => PlayHTVoiceLanguage.Malay,
                "mandarin" => PlayHTVoiceLanguage.Mandarin,
                "polish" => PlayHTVoiceLanguage.Polish,
                "portuguese" => PlayHTVoiceLanguage.Portuguese,
                "russian" => PlayHTVoiceLanguage.Russian,
                "serbian" => PlayHTVoiceLanguage.Serbian,
                "spanish" => PlayHTVoiceLanguage.Spanish,
                "swedish" => PlayHTVoiceLanguage.Swedish,
                "tagalog" => PlayHTVoiceLanguage.Tagalog,
                "thai" => PlayHTVoiceLanguage.Thai,
                "turkish" => PlayHTVoiceLanguage.Turkish,
                "ukrainian" => PlayHTVoiceLanguage.Ukrainian,
                "urdu" => PlayHTVoiceLanguage.Urdu,
                "xhosa" => PlayHTVoiceLanguage.Xhosa,
                _ => null,
            };
        }
    }
}