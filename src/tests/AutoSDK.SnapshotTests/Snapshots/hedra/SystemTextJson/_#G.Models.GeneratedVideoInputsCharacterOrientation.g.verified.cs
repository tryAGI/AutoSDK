//HintName: G.Models.GeneratedVideoInputsCharacterOrientation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratedVideoInputsCharacterOrientation
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedVideoInputsCharacterOrientationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedVideoInputsCharacterOrientation value)
        {
            return value switch
            {
                GeneratedVideoInputsCharacterOrientation.Image => "image",
                GeneratedVideoInputsCharacterOrientation.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedVideoInputsCharacterOrientation? ToEnum(string value)
        {
            return value switch
            {
                "image" => GeneratedVideoInputsCharacterOrientation.Image,
                "video" => GeneratedVideoInputsCharacterOrientation.Video,
                _ => null,
            };
        }
    }
}