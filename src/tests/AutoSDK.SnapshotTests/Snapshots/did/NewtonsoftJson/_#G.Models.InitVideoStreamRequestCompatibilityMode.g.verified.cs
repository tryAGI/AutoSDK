//HintName: G.Models.InitVideoStreamRequestCompatibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the video codec to be used in the stream.<br/>
    /// When set to on: VP8 will be used.<br/>
    /// When set to off: H264 will be used<br/>
    /// When set to auto the codec will be selected according to the browser.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InitVideoStreamRequestCompatibilityMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// H264 will be used
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// VP8 will be used.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on")]
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InitVideoStreamRequestCompatibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitVideoStreamRequestCompatibilityMode value)
        {
            return value switch
            {
                InitVideoStreamRequestCompatibilityMode.Auto => "auto",
                InitVideoStreamRequestCompatibilityMode.Off => "off",
                InitVideoStreamRequestCompatibilityMode.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitVideoStreamRequestCompatibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => InitVideoStreamRequestCompatibilityMode.Auto,
                "off" => InitVideoStreamRequestCompatibilityMode.Off,
                "on" => InitVideoStreamRequestCompatibilityMode.On,
                _ => null,
            };
        }
    }
}