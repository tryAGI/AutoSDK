//HintName: G.Models.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The unique slug identifier of the meta tool to execute<br/>
    /// Example: COMPOSIO_MANAGE_CONNECTIONS
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteMetaRequestSlug
    {
        /// <summary>
        /// 
        /// </summary>
        ComposioGetRecipe,
        /// <summary>
        /// 
        /// </summary>
        ComposioGetToolSchemas,
        /// <summary>
        /// 
        /// </summary>
        ComposioManageConnections,
        /// <summary>
        /// 
        /// </summary>
        ComposioMultiExecuteTool,
        /// <summary>
        /// 
        /// </summary>
        ComposioRemoteBashTool,
        /// <summary>
        /// 
        /// </summary>
        ComposioRemoteWorkbench,
        /// <summary>
        /// 
        /// </summary>
        ComposioSearchTools,
        /// <summary>
        /// 
        /// </summary>
        ComposioUpsertRecipe,
        /// <summary>
        /// 
        /// </summary>
        ComposioWaitForConnections,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteMetaRequestSlugExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteMetaRequestSlug value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioGetRecipe => "COMPOSIO_GET_RECIPE",
                PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioGetToolSchemas => "COMPOSIO_GET_TOOL_SCHEMAS",
                PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioManageConnections => "COMPOSIO_MANAGE_CONNECTIONS",
                PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioMultiExecuteTool => "COMPOSIO_MULTI_EXECUTE_TOOL",
                PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioRemoteBashTool => "COMPOSIO_REMOTE_BASH_TOOL",
                PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioRemoteWorkbench => "COMPOSIO_REMOTE_WORKBENCH",
                PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioSearchTools => "COMPOSIO_SEARCH_TOOLS",
                PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioUpsertRecipe => "COMPOSIO_UPSERT_RECIPE",
                PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioWaitForConnections => "COMPOSIO_WAIT_FOR_CONNECTIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaRequestSlug? ToEnum(string value)
        {
            return value switch
            {
                "COMPOSIO_GET_RECIPE" => PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioGetRecipe,
                "COMPOSIO_GET_TOOL_SCHEMAS" => PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioGetToolSchemas,
                "COMPOSIO_MANAGE_CONNECTIONS" => PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioManageConnections,
                "COMPOSIO_MULTI_EXECUTE_TOOL" => PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioMultiExecuteTool,
                "COMPOSIO_REMOTE_BASH_TOOL" => PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioRemoteBashTool,
                "COMPOSIO_REMOTE_WORKBENCH" => PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioRemoteWorkbench,
                "COMPOSIO_SEARCH_TOOLS" => PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioSearchTools,
                "COMPOSIO_UPSERT_RECIPE" => PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioUpsertRecipe,
                "COMPOSIO_WAIT_FOR_CONNECTIONS" => PostToolRouterSessionBySessionIdExecuteMetaRequestSlug.ComposioWaitForConnections,
                _ => null,
            };
        }
    }
}