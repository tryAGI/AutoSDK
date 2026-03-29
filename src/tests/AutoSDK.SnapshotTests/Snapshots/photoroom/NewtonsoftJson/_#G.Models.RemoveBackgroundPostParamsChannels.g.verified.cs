//HintName: G.Models.RemoveBackgroundPostParamsChannels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The channels of the resulting image<br/>
    /// Default Value: rgba
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RemoveBackgroundPostParamsChannels
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alpha")]
        Alpha,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rgba")]
        Rgba,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveBackgroundPostParamsChannelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveBackgroundPostParamsChannels value)
        {
            return value switch
            {
                RemoveBackgroundPostParamsChannels.Alpha => "alpha",
                RemoveBackgroundPostParamsChannels.Rgba => "rgba",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveBackgroundPostParamsChannels? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => RemoveBackgroundPostParamsChannels.Alpha,
                "rgba" => RemoveBackgroundPostParamsChannels.Rgba,
                _ => null,
            };
        }
    }
}