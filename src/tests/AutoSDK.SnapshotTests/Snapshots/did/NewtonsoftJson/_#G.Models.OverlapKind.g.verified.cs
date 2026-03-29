//HintName: G.Models.OverlapKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OverlapKind
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
    public static class OverlapKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OverlapKind value)
        {
            return value switch
            {
                OverlapKind.No => "NO",
                OverlapKind.Partial => "PARTIAL",
                OverlapKind.Unknown => "UNKNOWN",
                OverlapKind.Yes => "YES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OverlapKind? ToEnum(string value)
        {
            return value switch
            {
                "NO" => OverlapKind.No,
                "PARTIAL" => OverlapKind.Partial,
                "UNKNOWN" => OverlapKind.Unknown,
                "YES" => OverlapKind.Yes,
                _ => null,
            };
        }
    }
}