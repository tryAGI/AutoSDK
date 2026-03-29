//HintName: G.Models.UploadImageResponseDtoFaceOverlap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UploadImageResponseDtoFaceOverlap
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
    public static class UploadImageResponseDtoFaceOverlapExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadImageResponseDtoFaceOverlap value)
        {
            return value switch
            {
                UploadImageResponseDtoFaceOverlap.No => "NO",
                UploadImageResponseDtoFaceOverlap.Partial => "PARTIAL",
                UploadImageResponseDtoFaceOverlap.Unknown => "UNKNOWN",
                UploadImageResponseDtoFaceOverlap.Yes => "YES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadImageResponseDtoFaceOverlap? ToEnum(string value)
        {
            return value switch
            {
                "NO" => UploadImageResponseDtoFaceOverlap.No,
                "PARTIAL" => UploadImageResponseDtoFaceOverlap.Partial,
                "UNKNOWN" => UploadImageResponseDtoFaceOverlap.Unknown,
                "YES" => UploadImageResponseDtoFaceOverlap.Yes,
                _ => null,
            };
        }
    }
}