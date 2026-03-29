//HintName: G.Models.SvgCircleShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `circle`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgCircleShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="circle")]
        Circle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgCircleShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgCircleShapeType value)
        {
            return value switch
            {
                SvgCircleShapeType.Circle => "circle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgCircleShapeType? ToEnum(string value)
        {
            return value switch
            {
                "circle" => SvgCircleShapeType.Circle,
                _ => null,
            };
        }
    }
}