//HintName: G.Models.OutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat value)
        {
            return value switch
            {
                OutputFormat.Jpeg => "jpeg",
                OutputFormat.Png => "png",
                OutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => OutputFormat.Jpeg,
                "png" => OutputFormat.Png,
                "webp" => OutputFormat.Webp,
                _ => null,
            };
        }
    }
}