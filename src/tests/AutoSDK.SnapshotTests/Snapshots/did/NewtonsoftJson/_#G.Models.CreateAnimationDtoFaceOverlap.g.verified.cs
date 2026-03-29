//HintName: G.Models.CreateAnimationDtoFaceOverlap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAnimationDtoFaceOverlap
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
    public static class CreateAnimationDtoFaceOverlapExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnimationDtoFaceOverlap value)
        {
            return value switch
            {
                CreateAnimationDtoFaceOverlap.No => "NO",
                CreateAnimationDtoFaceOverlap.Partial => "PARTIAL",
                CreateAnimationDtoFaceOverlap.Unknown => "UNKNOWN",
                CreateAnimationDtoFaceOverlap.Yes => "YES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnimationDtoFaceOverlap? ToEnum(string value)
        {
            return value switch
            {
                "NO" => CreateAnimationDtoFaceOverlap.No,
                "PARTIAL" => CreateAnimationDtoFaceOverlap.Partial,
                "UNKNOWN" => CreateAnimationDtoFaceOverlap.Unknown,
                "YES" => CreateAnimationDtoFaceOverlap.Yes,
                _ => null,
            };
        }
    }
}