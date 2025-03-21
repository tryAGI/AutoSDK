//HintName: G.Models.ScreenshotType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a screenshot action, this property is <br/>
    /// always set to `screenshot`.<br/>
    /// Default Value: screenshot
    /// </summary>
    public enum ScreenshotType
    {
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScreenshotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScreenshotType value)
        {
            return value switch
            {
                ScreenshotType.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScreenshotType? ToEnum(string value)
        {
            return value switch
            {
                "screenshot" => ScreenshotType.Screenshot,
                _ => null,
            };
        }
    }
}