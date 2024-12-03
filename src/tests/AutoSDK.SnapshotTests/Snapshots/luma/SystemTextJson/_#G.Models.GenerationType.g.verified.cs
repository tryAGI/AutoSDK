//HintName: G.Models.GenerationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationType value)
        {
            return value switch
            {
                GenerationType.Video => "video",
                GenerationType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationType? ToEnum(string value)
        {
            return value switch
            {
                "video" => GenerationType.Video,
                "image" => GenerationType.Image,
                _ => null,
            };
        }
    }
}