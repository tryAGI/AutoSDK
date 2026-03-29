//HintName: G.Models.SvgCrossShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `cross`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgCrossShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cross")]
        Cross,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgCrossShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgCrossShapeType value)
        {
            return value switch
            {
                SvgCrossShapeType.Cross => "cross",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgCrossShapeType? ToEnum(string value)
        {
            return value switch
            {
                "cross" => SvgCrossShapeType.Cross,
                _ => null,
            };
        }
    }
}