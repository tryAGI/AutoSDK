//HintName: G.Models.ExpressiveImageBackgroundType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExpressiveImageBackgroundType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpressiveImageBackgroundTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveImageBackgroundType value)
        {
            return value switch
            {
                ExpressiveImageBackgroundType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveImageBackgroundType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ExpressiveImageBackgroundType.ImageUrl,
                _ => null,
            };
        }
    }
}