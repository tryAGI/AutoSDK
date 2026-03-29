//HintName: G.Models.SnowballLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Languages supported by snowball stemmer.
    /// </summary>
    public enum SnowballLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        Armenian,
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
        Hungarian,
        /// <summary>
        /// 
        /// </summary>
        Italian,
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
        Turkish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnowballLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnowballLanguage value)
        {
            return value switch
            {
                SnowballLanguage.Arabic => "arabic",
                SnowballLanguage.Armenian => "armenian",
                SnowballLanguage.Danish => "danish",
                SnowballLanguage.Dutch => "dutch",
                SnowballLanguage.English => "english",
                SnowballLanguage.Finnish => "finnish",
                SnowballLanguage.French => "french",
                SnowballLanguage.German => "german",
                SnowballLanguage.Greek => "greek",
                SnowballLanguage.Hungarian => "hungarian",
                SnowballLanguage.Italian => "italian",
                SnowballLanguage.Norwegian => "norwegian",
                SnowballLanguage.Portuguese => "portuguese",
                SnowballLanguage.Romanian => "romanian",
                SnowballLanguage.Russian => "russian",
                SnowballLanguage.Spanish => "spanish",
                SnowballLanguage.Swedish => "swedish",
                SnowballLanguage.Tamil => "tamil",
                SnowballLanguage.Turkish => "turkish",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnowballLanguage? ToEnum(string value)
        {
            return value switch
            {
                "arabic" => SnowballLanguage.Arabic,
                "armenian" => SnowballLanguage.Armenian,
                "danish" => SnowballLanguage.Danish,
                "dutch" => SnowballLanguage.Dutch,
                "english" => SnowballLanguage.English,
                "finnish" => SnowballLanguage.Finnish,
                "french" => SnowballLanguage.French,
                "german" => SnowballLanguage.German,
                "greek" => SnowballLanguage.Greek,
                "hungarian" => SnowballLanguage.Hungarian,
                "italian" => SnowballLanguage.Italian,
                "norwegian" => SnowballLanguage.Norwegian,
                "portuguese" => SnowballLanguage.Portuguese,
                "romanian" => SnowballLanguage.Romanian,
                "russian" => SnowballLanguage.Russian,
                "spanish" => SnowballLanguage.Spanish,
                "swedish" => SnowballLanguage.Swedish,
                "tamil" => SnowballLanguage.Tamil,
                "turkish" => SnowballLanguage.Turkish,
                _ => null,
            };
        }
    }
}