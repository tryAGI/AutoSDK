//HintName: G.Models.PostCliCodactFailuresRequestCtx.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary failure context from the CLI.<br/>
    /// Example: {"invalid_tool_slug":"GITHUB_MAKE_ISSUE","candidate_tool_slugs":["GITHUB_CREATE_ISSUE"]}
    /// </summary>
    public sealed partial class PostCliCodactFailuresRequestCtx
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}