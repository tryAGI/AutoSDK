//HintName: G.Models.SvgHeartShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `heart`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgHeartShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heart")]
        Heart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgHeartShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgHeartShapeType value)
        {
            return value switch
            {
                SvgHeartShapeType.Heart => "heart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgHeartShapeType? ToEnum(string value)
        {
            return value switch
            {
                "heart" => SvgHeartShapeType.Heart,
                _ => null,
            };
        }
    }
}