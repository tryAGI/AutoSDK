//HintName: G.Models.RectangleCropType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RectangleCropType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rectangle")]
        Rectangle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RectangleCropTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RectangleCropType value)
        {
            return value switch
            {
                RectangleCropType.Rectangle => "rectangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RectangleCropType? ToEnum(string value)
        {
            return value switch
            {
                "rectangle" => RectangleCropType.Rectangle,
                _ => null,
            };
        }
    }
}