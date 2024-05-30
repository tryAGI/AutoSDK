//HintName: G.Models.ChannelEmoteFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChannelEmoteFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animated")]
        Animated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="static")]
        Static,
    }

    public static class ChannelEmoteFormatExtensions
    {
        public static string ToValueString(this ChannelEmoteFormat value)
        {
            return value switch
            {
                ChannelEmoteFormat.Animated => "animated",
                ChannelEmoteFormat.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChannelEmoteFormat ToEnum(string value)
        {
            return value switch
            {
                "animated" => ChannelEmoteFormat.Animated,
                "static" => ChannelEmoteFormat.Static,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChannelEmoteFormat ToEnum(int value)
        {
            return value switch
            {
                0 => ChannelEmoteFormat.Animated,
                1 => ChannelEmoteFormat.Static,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}