//HintName: G.Models.CompressionRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompressionRatio
    {
        /// <summary>
        /// 
        /// </summary>
        X16,
        /// <summary>
        /// 
        /// </summary>
        X32,
        /// <summary>
        /// 
        /// </summary>
        X4,
        /// <summary>
        /// 
        /// </summary>
        X64,
        /// <summary>
        /// 
        /// </summary>
        X8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompressionRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompressionRatio value)
        {
            return value switch
            {
                CompressionRatio.X16 => "x16",
                CompressionRatio.X32 => "x32",
                CompressionRatio.X4 => "x4",
                CompressionRatio.X64 => "x64",
                CompressionRatio.X8 => "x8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompressionRatio? ToEnum(string value)
        {
            return value switch
            {
                "x16" => CompressionRatio.X16,
                "x32" => CompressionRatio.X32,
                "x4" => CompressionRatio.X4,
                "x64" => CompressionRatio.X64,
                "x8" => CompressionRatio.X8,
                _ => null,
            };
        }
    }
}