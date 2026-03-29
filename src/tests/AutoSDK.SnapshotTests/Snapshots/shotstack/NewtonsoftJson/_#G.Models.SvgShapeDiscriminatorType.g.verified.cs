//HintName: G.Models.SvgShapeDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgShapeDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="arrow")]
        Arrow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="circle")]
        Circle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cross")]
        Cross,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ellipse")]
        Ellipse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heart")]
        Heart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line")]
        Line,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="path")]
        Path,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="polygon")]
        Polygon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rectangle")]
        Rectangle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ring")]
        Ring,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="star")]
        Star,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgShapeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgShapeDiscriminatorType value)
        {
            return value switch
            {
                SvgShapeDiscriminatorType.Arrow => "arrow",
                SvgShapeDiscriminatorType.Circle => "circle",
                SvgShapeDiscriminatorType.Cross => "cross",
                SvgShapeDiscriminatorType.Ellipse => "ellipse",
                SvgShapeDiscriminatorType.Heart => "heart",
                SvgShapeDiscriminatorType.Line => "line",
                SvgShapeDiscriminatorType.Path => "path",
                SvgShapeDiscriminatorType.Polygon => "polygon",
                SvgShapeDiscriminatorType.Rectangle => "rectangle",
                SvgShapeDiscriminatorType.Ring => "ring",
                SvgShapeDiscriminatorType.Star => "star",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgShapeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "arrow" => SvgShapeDiscriminatorType.Arrow,
                "circle" => SvgShapeDiscriminatorType.Circle,
                "cross" => SvgShapeDiscriminatorType.Cross,
                "ellipse" => SvgShapeDiscriminatorType.Ellipse,
                "heart" => SvgShapeDiscriminatorType.Heart,
                "line" => SvgShapeDiscriminatorType.Line,
                "path" => SvgShapeDiscriminatorType.Path,
                "polygon" => SvgShapeDiscriminatorType.Polygon,
                "rectangle" => SvgShapeDiscriminatorType.Rectangle,
                "ring" => SvgShapeDiscriminatorType.Ring,
                "star" => SvgShapeDiscriminatorType.Star,
                _ => null,
            };
        }
    }
}