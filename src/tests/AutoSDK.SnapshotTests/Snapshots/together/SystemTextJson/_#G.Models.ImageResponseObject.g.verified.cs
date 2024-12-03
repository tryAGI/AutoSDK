//HintName: G.Models.ImageResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: list
    /// </summary>
    public enum ImageResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageResponseObject value)
        {
            return value switch
            {
                ImageResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ImageResponseObject.List,
                _ => null,
            };
        }
    }
}