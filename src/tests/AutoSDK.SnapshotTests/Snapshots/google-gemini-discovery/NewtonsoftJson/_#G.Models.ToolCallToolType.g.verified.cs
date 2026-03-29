//HintName: G.Models.ToolCallToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. The type of tool that was called.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolCallToolType
    {
        /// <summary>
        /// File search tool, maps to Tool.file_search.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_SEARCH")]
        FileSearch,
        /// <summary>
        /// Google maps tool, maps to Tool.google_maps.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GOOGLE_MAPS")]
        GoogleMaps,
        /// <summary>
        /// Image search tool, maps to Tool.google_search.search_types.image_search.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GOOGLE_SEARCH_IMAGE")]
        GoogleSearchImage,
        /// <summary>
        /// Google search tool, maps to Tool.google_search.search_types.web_search.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GOOGLE_SEARCH_WEB")]
        GoogleSearchWeb,
        /// <summary>
        /// Unspecified tool type.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOOL_TYPE_UNSPECIFIED")]
        ToolTypeUnspecified,
        /// <summary>
        /// URL context tool, maps to Tool.url_context.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="URL_CONTEXT")]
        UrlContext,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallToolType value)
        {
            return value switch
            {
                ToolCallToolType.FileSearch => "FILE_SEARCH",
                ToolCallToolType.GoogleMaps => "GOOGLE_MAPS",
                ToolCallToolType.GoogleSearchImage => "GOOGLE_SEARCH_IMAGE",
                ToolCallToolType.GoogleSearchWeb => "GOOGLE_SEARCH_WEB",
                ToolCallToolType.ToolTypeUnspecified => "TOOL_TYPE_UNSPECIFIED",
                ToolCallToolType.UrlContext => "URL_CONTEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallToolType? ToEnum(string value)
        {
            return value switch
            {
                "FILE_SEARCH" => ToolCallToolType.FileSearch,
                "GOOGLE_MAPS" => ToolCallToolType.GoogleMaps,
                "GOOGLE_SEARCH_IMAGE" => ToolCallToolType.GoogleSearchImage,
                "GOOGLE_SEARCH_WEB" => ToolCallToolType.GoogleSearchWeb,
                "TOOL_TYPE_UNSPECIFIED" => ToolCallToolType.ToolTypeUnspecified,
                "URL_CONTEXT" => ToolCallToolType.UrlContext,
                _ => null,
            };
        }
    }
}