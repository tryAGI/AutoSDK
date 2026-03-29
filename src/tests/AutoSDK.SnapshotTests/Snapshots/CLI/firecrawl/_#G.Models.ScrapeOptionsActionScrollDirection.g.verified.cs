//HintName: G.Models.ScrapeOptionsActionScrollDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Direction to scroll<br/>
    /// Default Value: down
    /// </summary>
    public enum ScrapeOptionsActionScrollDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Down,
        /// <summary>
        /// 
        /// </summary>
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsActionScrollDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsActionScrollDirection value)
        {
            return value switch
            {
                ScrapeOptionsActionScrollDirection.Down => "down",
                ScrapeOptionsActionScrollDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsActionScrollDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => ScrapeOptionsActionScrollDirection.Down,
                "up" => ScrapeOptionsActionScrollDirection.Up,
                _ => null,
            };
        }
    }
}