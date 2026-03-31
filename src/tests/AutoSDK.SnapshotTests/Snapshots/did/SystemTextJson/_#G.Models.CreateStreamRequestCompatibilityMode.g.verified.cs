//HintName: G.Models.CreateStreamRequestCompatibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the video codec to be used in the stream.<br/>
    /// When set to on: VP8 will be used.<br/>
    /// When set to off: H264 will be used<br/>
    /// When set to auto the codec will be selected according to the browser.
    /// </summary>
    public enum CreateStreamRequestCompatibilityMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// H264 will be used
        /// </summary>
        Off,
        /// <summary>
        /// VP8 will be used.
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStreamRequestCompatibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamRequestCompatibilityMode value)
        {
            return value switch
            {
                CreateStreamRequestCompatibilityMode.Auto => "auto",
                CreateStreamRequestCompatibilityMode.Off => "off",
                CreateStreamRequestCompatibilityMode.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamRequestCompatibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateStreamRequestCompatibilityMode.Auto,
                "off" => CreateStreamRequestCompatibilityMode.Off,
                "on" => CreateStreamRequestCompatibilityMode.On,
                _ => null,
            };
        }
    }
}