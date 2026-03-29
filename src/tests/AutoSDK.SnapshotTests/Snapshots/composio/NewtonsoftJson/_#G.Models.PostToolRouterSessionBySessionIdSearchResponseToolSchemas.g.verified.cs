//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseToolSchemas.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deduplicated tool definitions keyed by tool_slug for O(1) lookup. Each tool appears once even if used in multiple queries.
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseToolSchemas
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}