//HintName: G.Models.GeneratedVideoInputsCharacterOrientation2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratedVideoInputsCharacterOrientation2
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
    public static class GeneratedVideoInputsCharacterOrientation2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedVideoInputsCharacterOrientation2 value)
        {
            return value switch
            {
                GeneratedVideoInputsCharacterOrientation2.Image => "image",
                GeneratedVideoInputsCharacterOrientation2.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedVideoInputsCharacterOrientation2? ToEnum(string value)
        {
            return value switch
            {
                "image" => GeneratedVideoInputsCharacterOrientation2.Image,
                "video" => GeneratedVideoInputsCharacterOrientation2.Video,
                _ => null,
            };
        }
    }
}