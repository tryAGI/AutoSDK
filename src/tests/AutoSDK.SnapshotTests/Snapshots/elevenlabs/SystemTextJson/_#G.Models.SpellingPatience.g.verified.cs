//HintName: G.Models.SpellingPatience.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls if the agent should be more patient when user is spelling numbers and named entities.
    /// </summary>
    public enum SpellingPatience
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpellingPatienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpellingPatience value)
        {
            return value switch
            {
                SpellingPatience.Auto => "auto",
                SpellingPatience.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpellingPatience? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SpellingPatience.Auto,
                "off" => SpellingPatience.Off,
                _ => null,
            };
        }
    }
}