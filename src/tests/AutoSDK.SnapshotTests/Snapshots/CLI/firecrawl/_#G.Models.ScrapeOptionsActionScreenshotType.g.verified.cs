//HintName: G.Models.ScrapeOptionsActionScreenshotType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Take a screenshot. The links will be in the response's `actions.screenshots` array.
    /// </summary>
    public enum ScrapeOptionsActionScreenshotType
    {
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsActionScreenshotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsActionScreenshotType value)
        {
            return value switch
            {
                ScrapeOptionsActionScreenshotType.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsActionScreenshotType? ToEnum(string value)
        {
            return value switch
            {
                "screenshot" => ScrapeOptionsActionScreenshotType.Screenshot,
                _ => null,
            };
        }
    }
}