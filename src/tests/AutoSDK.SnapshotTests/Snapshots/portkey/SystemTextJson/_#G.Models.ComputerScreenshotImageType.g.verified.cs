//HintName: G.Models.ComputerScreenshotImageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a computer screenshot, this property is <br/>
    /// always set to `computer_screenshot`.<br/>
    /// Default Value: computer_screenshot
    /// </summary>
    public enum ComputerScreenshotImageType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerScreenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerScreenshotImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerScreenshotImageType value)
        {
            return value switch
            {
                ComputerScreenshotImageType.ComputerScreenshot => "computer_screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerScreenshotImageType? ToEnum(string value)
        {
            return value switch
            {
                "computer_screenshot" => ComputerScreenshotImageType.ComputerScreenshot,
                _ => null,
            };
        }
    }
}