//HintName: G.Models.GlobalEmoteFormatItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GlobalEmoteFormatItem
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
    public static class GlobalEmoteFormatItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlobalEmoteFormatItem value)
        {
            return value switch
            {
                GlobalEmoteFormatItem.Animated => "animated",
                GlobalEmoteFormatItem.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlobalEmoteFormatItem? ToEnum(string value)
        {
            return value switch
            {
                "animated" => GlobalEmoteFormatItem.Animated,
                "static" => GlobalEmoteFormatItem.Static,
                _ => null,
            };
        }
    }
}