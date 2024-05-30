//HintName: G.Models.GlobalEmoteScale.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GlobalEmoteScale
    {
        /// <summary>
        /// 
        /// </summary>
        _10,
        /// <summary>
        /// 
        /// </summary>
        _20,
        /// <summary>
        /// 
        /// </summary>
        _30,
    }

    public static class GlobalEmoteScaleExtensions
    {
        public static string ToValueString(this GlobalEmoteScale value)
        {
            return value switch
            {
                GlobalEmoteScale._10 => "1.0",
                GlobalEmoteScale._20 => "2.0",
                GlobalEmoteScale._30 => "3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GlobalEmoteScale ToEnum(string value)
        {
            return value switch
            {
                "1.0" => GlobalEmoteScale._10,
                "2.0" => GlobalEmoteScale._20,
                "3.0" => GlobalEmoteScale._30,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GlobalEmoteScale ToEnum(int value)
        {
            return value switch
            {
                0 => GlobalEmoteScale._10,
                1 => GlobalEmoteScale._20,
                2 => GlobalEmoteScale._30,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}