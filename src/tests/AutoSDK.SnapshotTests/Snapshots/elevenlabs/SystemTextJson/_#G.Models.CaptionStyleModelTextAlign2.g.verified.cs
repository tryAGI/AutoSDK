//HintName: G.Models.CaptionStyleModelTextAlign2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleModelTextAlign2
    {
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        End,
        /// <summary>
        /// 
        /// </summary>
        Start,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextAlign2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextAlign2 value)
        {
            return value switch
            {
                CaptionStyleModelTextAlign2.Center => "center",
                CaptionStyleModelTextAlign2.End => "end",
                CaptionStyleModelTextAlign2.Start => "start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextAlign2? ToEnum(string value)
        {
            return value switch
            {
                "center" => CaptionStyleModelTextAlign2.Center,
                "end" => CaptionStyleModelTextAlign2.End,
                "start" => CaptionStyleModelTextAlign2.Start,
                _ => null,
            };
        }
    }
}