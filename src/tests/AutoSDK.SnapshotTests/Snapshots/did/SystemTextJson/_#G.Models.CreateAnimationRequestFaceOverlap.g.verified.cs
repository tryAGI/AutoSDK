//HintName: G.Models.CreateAnimationRequestFaceOverlap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAnimationRequestFaceOverlap
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
    public static class CreateAnimationRequestFaceOverlapExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnimationRequestFaceOverlap value)
        {
            return value switch
            {
                CreateAnimationRequestFaceOverlap.No => "NO",
                CreateAnimationRequestFaceOverlap.Partial => "PARTIAL",
                CreateAnimationRequestFaceOverlap.Unknown => "UNKNOWN",
                CreateAnimationRequestFaceOverlap.Yes => "YES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnimationRequestFaceOverlap? ToEnum(string value)
        {
            return value switch
            {
                "NO" => CreateAnimationRequestFaceOverlap.No,
                "PARTIAL" => CreateAnimationRequestFaceOverlap.Partial,
                "UNKNOWN" => CreateAnimationRequestFaceOverlap.Unknown,
                "YES" => CreateAnimationRequestFaceOverlap.Yes,
                _ => null,
            };
        }
    }
}