//HintName: G.Models.ChannelEmoteScale.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChannelEmoteScale
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1.0")]
        x10,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2.0")]
        x20,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3.0")]
        x30,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelEmoteScaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelEmoteScale value)
        {
            return value switch
            {
                ChannelEmoteScale.x10 => "1.0",
                ChannelEmoteScale.x20 => "2.0",
                ChannelEmoteScale.x30 => "3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelEmoteScale? ToEnum(string value)
        {
            return value switch
            {
                "1.0" => ChannelEmoteScale.x10,
                "2.0" => ChannelEmoteScale.x20,
                "3.0" => ChannelEmoteScale.x30,
                _ => null,
            };
        }
    }
}