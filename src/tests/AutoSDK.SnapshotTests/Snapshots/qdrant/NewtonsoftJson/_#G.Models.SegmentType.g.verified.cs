//HintName: G.Models.SegmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of segment
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SegmentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="indexed")]
        Indexed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plain")]
        Plain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="special")]
        Special,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentType value)
        {
            return value switch
            {
                SegmentType.Indexed => "indexed",
                SegmentType.Plain => "plain",
                SegmentType.Special => "special",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentType? ToEnum(string value)
        {
            return value switch
            {
                "indexed" => SegmentType.Indexed,
                "plain" => SegmentType.Plain,
                "special" => SegmentType.Special,
                _ => null,
            };
        }
    }
}