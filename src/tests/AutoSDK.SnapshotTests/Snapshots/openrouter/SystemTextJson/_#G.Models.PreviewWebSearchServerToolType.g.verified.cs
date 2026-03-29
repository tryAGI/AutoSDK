//HintName: G.Models.PreviewWebSearchServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreviewWebSearchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreviewWebSearchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreviewWebSearchServerToolType value)
        {
            return value switch
            {
                PreviewWebSearchServerToolType.WebSearchPreview => "web_search_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreviewWebSearchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview" => PreviewWebSearchServerToolType.WebSearchPreview,
                _ => null,
            };
        }
    }
}