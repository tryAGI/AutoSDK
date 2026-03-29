//HintName: G.Models.UploadAnImageResponseFaceOverlap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UploadAnImageResponseFaceOverlap
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
    public static class UploadAnImageResponseFaceOverlapExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAnImageResponseFaceOverlap value)
        {
            return value switch
            {
                UploadAnImageResponseFaceOverlap.No => "NO",
                UploadAnImageResponseFaceOverlap.Partial => "PARTIAL",
                UploadAnImageResponseFaceOverlap.Unknown => "UNKNOWN",
                UploadAnImageResponseFaceOverlap.Yes => "YES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAnImageResponseFaceOverlap? ToEnum(string value)
        {
            return value switch
            {
                "NO" => UploadAnImageResponseFaceOverlap.No,
                "PARTIAL" => UploadAnImageResponseFaceOverlap.Partial,
                "UNKNOWN" => UploadAnImageResponseFaceOverlap.Unknown,
                "YES" => UploadAnImageResponseFaceOverlap.Yes,
                _ => null,
            };
        }
    }
}