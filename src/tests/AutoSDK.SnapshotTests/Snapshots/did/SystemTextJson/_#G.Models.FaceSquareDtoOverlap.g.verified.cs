//HintName: G.Models.FaceSquareDtoOverlap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FaceSquareDtoOverlap
    {
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// 
        /// </summary>
        Partial,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Yes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FaceSquareDtoOverlapExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSquareDtoOverlap value)
        {
            return value switch
            {
                FaceSquareDtoOverlap.No => "NO",
                FaceSquareDtoOverlap.Partial => "PARTIAL",
                FaceSquareDtoOverlap.Unknown => "UNKNOWN",
                FaceSquareDtoOverlap.Yes => "YES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSquareDtoOverlap? ToEnum(string value)
        {
            return value switch
            {
                "NO" => FaceSquareDtoOverlap.No,
                "PARTIAL" => FaceSquareDtoOverlap.Partial,
                "UNKNOWN" => FaceSquareDtoOverlap.Unknown,
                "YES" => FaceSquareDtoOverlap.Yes,
                _ => null,
            };
        }
    }
}