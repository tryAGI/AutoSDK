//HintName: G.Models.ScrapeOptionsActionWaitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Wait for a specified amount of milliseconds
    /// </summary>
    public enum ScrapeOptionsActionWaitType
    {
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsActionWaitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsActionWaitType value)
        {
            return value switch
            {
                ScrapeOptionsActionWaitType.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsActionWaitType? ToEnum(string value)
        {
            return value switch
            {
                "wait" => ScrapeOptionsActionWaitType.Wait,
                _ => null,
            };
        }
    }
}