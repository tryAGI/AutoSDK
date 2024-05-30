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
        _10,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2.0")]
        _20,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3.0")]
        _30,
    }

    public static class ChannelEmoteScaleExtensions
    {
        public static string ToValueString(this ChannelEmoteScale value)
        {
            return value switch
            {
                ChannelEmoteScale._10 => "1.0",
                ChannelEmoteScale._20 => "2.0",
                ChannelEmoteScale._30 => "3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChannelEmoteScale ToEnum(string value)
        {
            return value switch
            {
                "1.0" => ChannelEmoteScale._10,
                "2.0" => ChannelEmoteScale._20,
                "3.0" => ChannelEmoteScale._30,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChannelEmoteScale ToEnum(int value)
        {
            return value switch
            {
                0 => ChannelEmoteScale._10,
                1 => ChannelEmoteScale._20,
                2 => ChannelEmoteScale._30,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}