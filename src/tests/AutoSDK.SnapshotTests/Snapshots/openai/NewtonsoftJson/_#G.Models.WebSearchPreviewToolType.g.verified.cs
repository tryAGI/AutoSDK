//HintName: G.Models.WebSearchPreviewToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the web search tool. One of `web_search_preview` or `web_search_preview_2025_03_11`.<br/>
    /// Default Value: web_search_preview
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchPreviewToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_preview")]
        WebSearchPreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_preview_2025_03_11")]
        WebSearchPreview20250311,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchPreviewToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchPreviewToolType value)
        {
            return value switch
            {
                WebSearchPreviewToolType.WebSearchPreview => "web_search_preview",
                WebSearchPreviewToolType.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchPreviewToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview" => WebSearchPreviewToolType.WebSearchPreview,
                "web_search_preview_2025_03_11" => WebSearchPreviewToolType.WebSearchPreview20250311,
                _ => null,
            };
        }
    }
}