//HintName: G.Models.InitTalkStreamRequestCompatibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the video codec to be used in the stream.<br/>
    /// When set to on: VP8 will be used.<br/>
    /// When set to off: H264 will be used<br/>
    /// When set to auto the codec will be selected according to the browser.
    /// </summary>
    public enum InitTalkStreamRequestCompatibilityMode
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
    public static class InitTalkStreamRequestCompatibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitTalkStreamRequestCompatibilityMode value)
        {
            return value switch
            {
                InitTalkStreamRequestCompatibilityMode.Auto => "auto",
                InitTalkStreamRequestCompatibilityMode.Off => "off",
                InitTalkStreamRequestCompatibilityMode.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitTalkStreamRequestCompatibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => InitTalkStreamRequestCompatibilityMode.Auto,
                "off" => InitTalkStreamRequestCompatibilityMode.Off,
                "on" => InitTalkStreamRequestCompatibilityMode.On,
                _ => null,
            };
        }
    }
}