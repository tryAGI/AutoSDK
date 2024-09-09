//HintName: G.Models.ChannelEmoteScaleItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChannelEmoteScaleItem
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
    public static class ChannelEmoteScaleItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelEmoteScaleItem value)
        {
            return value switch
            {
                ChannelEmoteScaleItem.x10 => "1.0",
                ChannelEmoteScaleItem.x20 => "2.0",
                ChannelEmoteScaleItem.x30 => "3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelEmoteScaleItem? ToEnum(string value)
        {
            return value switch
            {
                "1.0" => ChannelEmoteScaleItem.x10,
                "2.0" => ChannelEmoteScaleItem.x20,
                "3.0" => ChannelEmoteScaleItem.x30,
                _ => null,
            };
        }
    }
}