//HintName: G.Models.CreateStreamRequestCompatibilityMode2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the video codec to be used in the stream.<br/>
    /// When set to on: VP8 will be used.<br/>
    /// When set to off: H264 will be used<br/>
    /// When set to auto the codec will be selected according to the browser.
    /// </summary>
    public enum CreateStreamRequestCompatibilityMode2
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
    public static class CreateStreamRequestCompatibilityMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamRequestCompatibilityMode2 value)
        {
            return value switch
            {
                CreateStreamRequestCompatibilityMode2.Auto => "auto",
                CreateStreamRequestCompatibilityMode2.Off => "off",
                CreateStreamRequestCompatibilityMode2.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamRequestCompatibilityMode2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateStreamRequestCompatibilityMode2.Auto,
                "off" => CreateStreamRequestCompatibilityMode2.Off,
                "on" => CreateStreamRequestCompatibilityMode2.On,
                _ => null,
            };
        }
    }
}