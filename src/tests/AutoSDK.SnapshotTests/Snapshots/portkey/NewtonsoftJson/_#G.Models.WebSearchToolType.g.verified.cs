//HintName: G.Models.WebSearchToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the web search tool. One of:<br/>
    /// - `web_search_preview`<br/>
    /// - `web_search_preview_2025_03_11`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchToolType
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
    public static class WebSearchToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolType value)
        {
            return value switch
            {
                WebSearchToolType.WebSearchPreview => "web_search_preview",
                WebSearchToolType.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview" => WebSearchToolType.WebSearchPreview,
                "web_search_preview_2025_03_11" => WebSearchToolType.WebSearchPreview20250311,
                _ => null,
            };
        }
    }
}