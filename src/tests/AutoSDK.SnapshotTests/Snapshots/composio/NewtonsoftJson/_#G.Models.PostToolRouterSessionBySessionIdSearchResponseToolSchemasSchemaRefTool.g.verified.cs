//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool to call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPOSIO_GET_TOOL_SCHEMAS")]
        ComposioGetToolSchemas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefToolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool.ComposioGetToolSchemas => "COMPOSIO_GET_TOOL_SCHEMAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool? ToEnum(string value)
        {
            return value switch
            {
                "COMPOSIO_GET_TOOL_SCHEMAS" => PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool.ComposioGetToolSchemas,
                _ => null,
            };
        }
    }
}