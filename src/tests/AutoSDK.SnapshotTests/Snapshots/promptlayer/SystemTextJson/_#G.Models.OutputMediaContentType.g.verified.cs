//HintName: G.Models.OutputMediaContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: output_media
    /// </summary>
    public enum OutputMediaContentType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputMedia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMediaContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMediaContentType value)
        {
            return value switch
            {
                OutputMediaContentType.OutputMedia => "output_media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMediaContentType? ToEnum(string value)
        {
            return value switch
            {
                "output_media" => OutputMediaContentType.OutputMedia,
                _ => null,
            };
        }
    }
}