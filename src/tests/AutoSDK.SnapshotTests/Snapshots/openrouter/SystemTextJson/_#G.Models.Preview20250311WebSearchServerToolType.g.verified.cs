//HintName: G.Models.Preview20250311WebSearchServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Preview20250311WebSearchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview20250311,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Preview20250311WebSearchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Preview20250311WebSearchServerToolType value)
        {
            return value switch
            {
                Preview20250311WebSearchServerToolType.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Preview20250311WebSearchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview_2025_03_11" => Preview20250311WebSearchServerToolType.WebSearchPreview20250311,
                _ => null,
            };
        }
    }
}