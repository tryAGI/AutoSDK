//HintName: G.Models.FaceSquareOverlap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FaceSquareOverlap
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
    public static class FaceSquareOverlapExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FaceSquareOverlap value)
        {
            return value switch
            {
                FaceSquareOverlap.No => "NO",
                FaceSquareOverlap.Partial => "PARTIAL",
                FaceSquareOverlap.Unknown => "UNKNOWN",
                FaceSquareOverlap.Yes => "YES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FaceSquareOverlap? ToEnum(string value)
        {
            return value switch
            {
                "NO" => FaceSquareOverlap.No,
                "PARTIAL" => FaceSquareOverlap.Partial,
                "UNKNOWN" => FaceSquareOverlap.Unknown,
                "YES" => FaceSquareOverlap.Yes,
                _ => null,
            };
        }
    }
}