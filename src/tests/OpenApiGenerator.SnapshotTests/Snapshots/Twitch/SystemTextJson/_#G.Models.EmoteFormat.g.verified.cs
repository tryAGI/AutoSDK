//HintName: G.Models.EmoteFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmoteFormat
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

    public static class EmoteFormatExtensions
    {
        public static string ToValueString(this EmoteFormat value)
        {
            return value switch
            {
                EmoteFormat.Animated => "animated",
                EmoteFormat.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmoteFormat ToEnum(string value)
        {
            return value switch
            {
                "animated" => EmoteFormat.Animated,
                "static" => EmoteFormat.Static,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmoteFormat ToEnum(int value)
        {
            return value switch
            {
                0 => EmoteFormat.Animated,
                1 => EmoteFormat.Static,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}