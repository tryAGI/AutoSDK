//HintName: G.Models.TextTo3DPreviewRequestArtStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated for Meshy-6
    /// </summary>
    public enum TextTo3DPreviewRequestArtStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Realistic,
        /// <summary>
        /// 
        /// </summary>
        Sculpture,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextTo3DPreviewRequestArtStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextTo3DPreviewRequestArtStyle value)
        {
            return value switch
            {
                TextTo3DPreviewRequestArtStyle.Realistic => "realistic",
                TextTo3DPreviewRequestArtStyle.Sculpture => "sculpture",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextTo3DPreviewRequestArtStyle? ToEnum(string value)
        {
            return value switch
            {
                "realistic" => TextTo3DPreviewRequestArtStyle.Realistic,
                "sculpture" => TextTo3DPreviewRequestArtStyle.Sculpture,
                _ => null,
            };
        }
    }
}