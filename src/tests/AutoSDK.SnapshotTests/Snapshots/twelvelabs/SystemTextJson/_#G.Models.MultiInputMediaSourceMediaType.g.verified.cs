//HintName: G.Models.MultiInputMediaSourceMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of media.<br/>
    /// **Value**: `image`
    /// </summary>
    public enum MultiInputMediaSourceMediaType
    {
        /// <summary>
        /// `image`
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultiInputMediaSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiInputMediaSourceMediaType value)
        {
            return value switch
            {
                MultiInputMediaSourceMediaType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiInputMediaSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "image" => MultiInputMediaSourceMediaType.Image,
                _ => null,
            };
        }
    }
}