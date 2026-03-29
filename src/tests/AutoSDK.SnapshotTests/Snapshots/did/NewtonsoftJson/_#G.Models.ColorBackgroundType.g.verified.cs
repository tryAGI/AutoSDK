//HintName: G.Models.ColorBackgroundType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ColorBackgroundType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="color")]
        Color,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColorBackgroundTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColorBackgroundType value)
        {
            return value switch
            {
                ColorBackgroundType.Color => "color",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColorBackgroundType? ToEnum(string value)
        {
            return value switch
            {
                "color" => ColorBackgroundType.Color,
                _ => null,
            };
        }
    }
}