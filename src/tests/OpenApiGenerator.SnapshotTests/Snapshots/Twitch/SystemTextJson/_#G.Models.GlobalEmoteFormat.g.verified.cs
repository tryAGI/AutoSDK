//HintName: G.Models.GlobalEmoteFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GlobalEmoteFormat
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

    public static class GlobalEmoteFormatExtensions
    {
        public static string ToValueString(this GlobalEmoteFormat value)
        {
            return value switch
            {
                GlobalEmoteFormat.Animated => "animated",
                GlobalEmoteFormat.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GlobalEmoteFormat ToEnum(string value)
        {
            return value switch
            {
                "animated" => GlobalEmoteFormat.Animated,
                "static" => GlobalEmoteFormat.Static,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GlobalEmoteFormat ToEnum(int value)
        {
            return value switch
            {
                0 => GlobalEmoteFormat.Animated,
                1 => GlobalEmoteFormat.Static,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}