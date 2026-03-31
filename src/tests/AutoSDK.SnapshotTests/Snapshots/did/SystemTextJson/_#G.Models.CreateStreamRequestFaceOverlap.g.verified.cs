//HintName: G.Models.CreateStreamRequestFaceOverlap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateStreamRequestFaceOverlap
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
    public static class CreateStreamRequestFaceOverlapExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamRequestFaceOverlap value)
        {
            return value switch
            {
                CreateStreamRequestFaceOverlap.No => "NO",
                CreateStreamRequestFaceOverlap.Partial => "PARTIAL",
                CreateStreamRequestFaceOverlap.Unknown => "UNKNOWN",
                CreateStreamRequestFaceOverlap.Yes => "YES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamRequestFaceOverlap? ToEnum(string value)
        {
            return value switch
            {
                "NO" => CreateStreamRequestFaceOverlap.No,
                "PARTIAL" => CreateStreamRequestFaceOverlap.Partial,
                "UNKNOWN" => CreateStreamRequestFaceOverlap.Unknown,
                "YES" => CreateStreamRequestFaceOverlap.Yes,
                _ => null,
            };
        }
    }
}