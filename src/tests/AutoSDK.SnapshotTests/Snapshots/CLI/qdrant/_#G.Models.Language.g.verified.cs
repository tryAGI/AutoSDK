//HintName: G.Models.Language.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// 
        /// </summary>
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        Azerbaijani,
        /// <summary>
        /// 
        /// </summary>
        Basque,
        /// <summary>
        /// 
        /// </summary>
        Bengali,
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
        Hinglish,
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
        Kazakh,
        /// <summary>
        /// 
        /// </summary>
        Nepali,
        /// <summary>
        /// 
        /// </summary>
        Norwegian,
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
        Slovene,
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
        Tajik,
        /// <summary>
        /// 
        /// </summary>
        Turkish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Language value)
        {
            return value switch
            {
                Language.Arabic => "arabic",
                Language.Azerbaijani => "azerbaijani",
                Language.Basque => "basque",
                Language.Bengali => "bengali",
                Language.Catalan => "catalan",
                Language.Chinese => "chinese",
                Language.Danish => "danish",
                Language.Dutch => "dutch",
                Language.English => "english",
                Language.Finnish => "finnish",
                Language.French => "french",
                Language.German => "german",
                Language.Greek => "greek",
                Language.Hebrew => "hebrew",
                Language.Hinglish => "hinglish",
                Language.Hungarian => "hungarian",
                Language.Indonesian => "indonesian",
                Language.Italian => "italian",
                Language.Japanese => "japanese",
                Language.Kazakh => "kazakh",
                Language.Nepali => "nepali",
                Language.Norwegian => "norwegian",
                Language.Portuguese => "portuguese",
                Language.Romanian => "romanian",
                Language.Russian => "russian",
                Language.Slovene => "slovene",
                Language.Spanish => "spanish",
                Language.Swedish => "swedish",
                Language.Tajik => "tajik",
                Language.Turkish => "turkish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Language? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => Language.Arabic,
                "azerbaijani" => Language.Azerbaijani,
                "basque" => Language.Basque,
                "bengali" => Language.Bengali,
                "catalan" => Language.Catalan,
                "chinese" => Language.Chinese,
                "danish" => Language.Danish,
                "dutch" => Language.Dutch,
                "english" => Language.English,
                "finnish" => Language.Finnish,
                "french" => Language.French,
                "german" => Language.German,
                "greek" => Language.Greek,
                "hebrew" => Language.Hebrew,
                "hinglish" => Language.Hinglish,
                "hungarian" => Language.Hungarian,
                "indonesian" => Language.Indonesian,
                "italian" => Language.Italian,
                "japanese" => Language.Japanese,
                "kazakh" => Language.Kazakh,
                "nepali" => Language.Nepali,
                "norwegian" => Language.Norwegian,
                "portuguese" => Language.Portuguese,
                "romanian" => Language.Romanian,
                "russian" => Language.Russian,
                "slovene" => Language.Slovene,
                "spanish" => Language.Spanish,
                "swedish" => Language.Swedish,
                "tajik" => Language.Tajik,
                "turkish" => Language.Turkish,
                _ => null,
            };
        }
    }
}