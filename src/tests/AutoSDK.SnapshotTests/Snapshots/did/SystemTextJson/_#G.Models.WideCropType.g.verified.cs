//HintName: G.Models.WideCropType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    public enum WideCropType
    {
        /// <summary>
        /// 
        /// </summary>
        Wide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WideCropTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WideCropType value)
        {
            return value switch
            {
                WideCropType.Wide => "wide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WideCropType? ToEnum(string value)
        {
            return value switch
            {
                "wide" => WideCropType.Wide,
                _ => null,
            };
        }
    }
}