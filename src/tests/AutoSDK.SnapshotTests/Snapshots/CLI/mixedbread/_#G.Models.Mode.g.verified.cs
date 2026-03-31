//HintName: G.Models.Mode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The mode of the document parser.
    /// </summary>
    public enum Mode
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        HighQuality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Mode value)
        {
            return value switch
            {
                Mode.Fast => "fast",
                Mode.HighQuality => "high_quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Mode? ToEnum(string value)
        {
            return value switch
            {
                "fast" => Mode.Fast,
                "high_quality" => Mode.HighQuality,
                _ => null,
            };
        }
    }
}