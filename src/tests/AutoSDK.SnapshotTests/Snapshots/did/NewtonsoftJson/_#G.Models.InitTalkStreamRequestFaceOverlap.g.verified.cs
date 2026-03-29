//HintName: G.Models.InitTalkStreamRequestFaceOverlap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InitTalkStreamRequestFaceOverlap
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NO")]
        No,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARTIAL")]
        Partial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNKNOWN")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="YES")]
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