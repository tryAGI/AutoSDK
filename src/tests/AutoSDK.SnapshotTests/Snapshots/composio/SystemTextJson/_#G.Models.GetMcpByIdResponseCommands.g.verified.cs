//HintName: G.Models.GetMcpByIdResponseCommands.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Set of command line instructions for connecting various clients to this MCP server
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetMcpByIdResponseCommands
    {
        /// <summary>
        /// Command line instruction for Cursor client setup<br/>
        /// Example: npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client cursor
        /// </summary>
        /// <example>npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client cursor</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Cursor { get; set; }

        /// <summary>
        /// Command line instruction for Claude client setup<br/>
        /// Example: npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client claude
        /// </summary>
        /// <example>npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client claude</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("claude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Claude { get; set; }

        /// <summary>
        /// Command line instruction for Windsurf client setup<br/>
        /// Example: npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client windsurf
        /// </summary>
        /// <example>npx @composio/mcp@latest setup "https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john" --client windsurf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("windsurf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Windsurf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpByIdResponseCommands" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMcpByIdResponseCommands(
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