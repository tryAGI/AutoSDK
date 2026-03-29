//HintName: G.Models.PiiRedactionConfigDTOProcessedTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of processed text to return (marker or mask)<br/>
    /// Example: MARKER
    /// </summary>
    public enum PiiRedactionConfigDTOProcessedTextType
    {
        /// <summary>
        /// 
        /// </summary>
        Marker,
        /// <summary>
        /// 
        /// </summary>
        Mask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PiiRedactionConfigDTOProcessedTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PiiRedactionConfigDTOProcessedTextType value)
        {
            return value switch
            {
                PiiRedactionConfigDTOProcessedTextType.Marker => "MARKER",
                PiiRedactionConfigDTOProcessedTextType.Mask => "MASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PiiRedactionConfigDTOProcessedTextType? ToEnum(string value)
        {
            return value switch
            {
                "MARKER" => PiiRedactionConfigDTOProcessedTextType.Marker,
                "MASK" => PiiRedactionConfigDTOProcessedTextType.Mask,
                _ => null,
            };
        }
    }
}