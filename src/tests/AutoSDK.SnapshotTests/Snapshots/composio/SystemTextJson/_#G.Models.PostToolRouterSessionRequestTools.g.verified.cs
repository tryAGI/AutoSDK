//HintName: G.Models.PostToolRouterSessionRequestTools.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool-level configuration per toolkit - either specify enable tools (whitelist), disable tools (blacklist), or filter by MCP tags for each toolkit<br/>
    /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slack_bot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestTools
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}