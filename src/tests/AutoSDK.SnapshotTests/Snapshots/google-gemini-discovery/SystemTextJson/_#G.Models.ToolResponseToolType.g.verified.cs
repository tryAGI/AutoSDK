//HintName: G.Models.ToolResponseToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. The type of tool that was called, matching the `tool_type` in the corresponding `ToolCall`.
    /// </summary>
    public enum ToolResponseToolType
    {
        /// <summary>
        /// File search tool, maps to Tool.file_search.
        /// </summary>
        FileSearch,
        /// <summary>
        /// Google maps tool, maps to Tool.google_maps.
        /// </summary>
        GoogleMaps,
        /// <summary>
        /// Image search tool, maps to Tool.google_search.search_types.image_search.
        /// </summary>
        GoogleSearchImage,
        /// <summary>
        /// Google search tool, maps to Tool.google_search.search_types.web_search.
        /// </summary>
        GoogleSearchWeb,
        /// <summary>
        /// Unspecified tool type.
        /// </summary>
        ToolTypeUnspecified,
        /// <summary>
        /// URL context tool, maps to Tool.url_context.
        /// </summary>
        UrlContext,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolResponseToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolResponseToolType value)
        {
            return value switch
            {
                ToolResponseToolType.FileSearch => "FILE_SEARCH",
                ToolResponseToolType.GoogleMaps => "GOOGLE_MAPS",
                ToolResponseToolType.GoogleSearchImage => "GOOGLE_SEARCH_IMAGE",
                ToolResponseToolType.GoogleSearchWeb => "GOOGLE_SEARCH_WEB",
                ToolResponseToolType.ToolTypeUnspecified => "TOOL_TYPE_UNSPECIFIED",
                ToolResponseToolType.UrlContext => "URL_CONTEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolResponseToolType? ToEnum(string value)
        {
            return value switch
            {
                "FILE_SEARCH" => ToolResponseToolType.FileSearch,
                "GOOGLE_MAPS" => ToolResponseToolType.GoogleMaps,
                "GOOGLE_SEARCH_IMAGE" => ToolResponseToolType.GoogleSearchImage,
                "GOOGLE_SEARCH_WEB" => ToolResponseToolType.GoogleSearchWeb,
                "TOOL_TYPE_UNSPECIFIED" => ToolResponseToolType.ToolTypeUnspecified,
                "URL_CONTEXT" => ToolResponseToolType.UrlContext,
                _ => null,
            };
        }
    }
}