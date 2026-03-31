//HintName: G.Models.InitTalkStreamRequestFaceOverlap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InitTalkStreamRequestFaceOverlap
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
    public static class InitTalkStreamRequestFaceOverlapExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitTalkStreamRequestFaceOverlap value)
        {
            return value switch
            {
                InitTalkStreamRequestFaceOverlap.No => "NO",
                InitTalkStreamRequestFaceOverlap.Partial => "PARTIAL",
                InitTalkStreamRequestFaceOverlap.Unknown => "UNKNOWN",
                InitTalkStreamRequestFaceOverlap.Yes => "YES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitTalkStreamRequestFaceOverlap? ToEnum(string value)
        {
            return value switch
            {
                "NO" => InitTalkStreamRequestFaceOverlap.No,
                "PARTIAL" => InitTalkStreamRequestFaceOverlap.Partial,
                "UNKNOWN" => InitTalkStreamRequestFaceOverlap.Unknown,
                "YES" => InitTalkStreamRequestFaceOverlap.Yes,
                _ => null,
            };
        }
    }
}