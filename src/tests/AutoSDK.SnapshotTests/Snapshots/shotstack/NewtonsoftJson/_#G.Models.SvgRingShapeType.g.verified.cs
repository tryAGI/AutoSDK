//HintName: G.Models.SvgRingShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `ring`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgRingShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ring")]
        Ring,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgRingShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgRingShapeType value)
        {
            return value switch
            {
                SvgRingShapeType.Ring => "ring",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgRingShapeType? ToEnum(string value)
        {
            return value switch
            {
                "ring" => SvgRingShapeType.Ring,
                _ => null,
            };
        }
    }
}