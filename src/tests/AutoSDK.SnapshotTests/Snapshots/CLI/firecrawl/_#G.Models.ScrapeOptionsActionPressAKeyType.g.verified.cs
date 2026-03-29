//HintName: G.Models.ScrapeOptionsActionPressAKeyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Press a key on the page
    /// </summary>
    public enum ScrapeOptionsActionPressAKeyType
    {
        /// <summary>
        /// 
        /// </summary>
        Press,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsActionPressAKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsActionPressAKeyType value)
        {
            return value switch
            {
                ScrapeOptionsActionPressAKeyType.Press => "press",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsActionPressAKeyType? ToEnum(string value)
        {
            return value switch
            {
                "press" => ScrapeOptionsActionPressAKeyType.Press,
                _ => null,
            };
        }
    }
}