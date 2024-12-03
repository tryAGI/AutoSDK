//HintName: G.Models.ChannelEmoteFormatItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChannelEmoteFormatItem
    {
        /// <summary>
        /// 
        /// </summary>
        Animated,
        /// <summary>
        /// 
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelEmoteFormatItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelEmoteFormatItem value)
        {
            return value switch
            {
                ChannelEmoteFormatItem.Animated => "animated",
                ChannelEmoteFormatItem.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelEmoteFormatItem? ToEnum(string value)
        {
            return value switch
            {
                "animated" => ChannelEmoteFormatItem.Animated,
                "static" => ChannelEmoteFormatItem.Static,
                _ => null,
            };
        }
    }
}