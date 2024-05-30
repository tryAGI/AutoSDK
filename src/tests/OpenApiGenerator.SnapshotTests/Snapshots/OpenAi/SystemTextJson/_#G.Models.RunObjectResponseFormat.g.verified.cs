//HintName: G.Models.RunObjectResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    public enum RunObjectResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    public static class RunObjectResponseFormatExtensions
    {
        public static string ToValueString(this RunObjectResponseFormat value)
        {
            return value switch
            {
                RunObjectResponseFormat.None => "none",
                RunObjectResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "none" => RunObjectResponseFormat.None,
                "auto" => RunObjectResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => RunObjectResponseFormat.None,
                1 => RunObjectResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}