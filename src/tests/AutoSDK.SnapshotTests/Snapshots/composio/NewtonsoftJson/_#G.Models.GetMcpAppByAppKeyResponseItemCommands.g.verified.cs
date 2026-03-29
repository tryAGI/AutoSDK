//HintName: G.Models.GetMcpAppByAppKeyResponseItemCommands.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Set of command line instructions for connecting various clients to this MCP server
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetMcpAppByAppKeyResponseItemCommands
    {
        /// <summary>
        /// Command line instruction for Cursor client setup<br/>
        /// Example: npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client cursor
        /// </summary>
        /// <example>npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client cursor</example>
        [global::Newtonsoft.Json.JsonProperty("cursor", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string Cursor { get; set; } = default!;

        /// <summary>
        /// Command line instruction for Claude client setup<br/>
        /// Example: npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client claude
        /// </summary>
        /// <example>npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client claude</example>
        [global::Newtonsoft.Json.JsonProperty("claude", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string Claude { get; set; } = default!;

        /// <summary>
        /// Command line instruction for Windsurf client setup<br/>
        /// Example: npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client windsurf
        /// </summary>
        /// <example>npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client windsurf</example>
        [global::Newtonsoft.Json.JsonProperty("windsurf", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string Windsurf { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpAppByAppKeyResponseItemCommands" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Command line instruction for Cursor client setup<br/>
        /// Example: npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client cursor
        /// </param>
        /// <param name="claude">
        /// Command line instruction for Claude client setup<br/>
        /// Example: npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client claude
        /// </param>
        /// <param name="windsurf">
        /// Command line instruction for Windsurf client setup<br/>
        /// Example: npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client windsurf
        /// </param>
        public GetMcpAppByAppKeyResponseItemCommands(
            string cursor,
            string claude,
            string windsurf)
        {
            this.Cursor = cursor ?? throw new global::System.ArgumentNullException(nameof(cursor));
            this.Claude = claude ?? throw new global::System.ArgumentNullException(nameof(claude));
            this.Windsurf = windsurf ?? throw new global::System.ArgumentNullException(nameof(windsurf));
        }
    }
}