//HintName: G.Models.RagConfigWorkflowOverrideQueryRewritePromptOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom prompt for rewriting user queries before RAG retrieval. The conversation history will be automatically appended at the end. If not set, the default prompt will be used.
    /// </summary>
    public sealed partial class RagConfigWorkflowOverrideQueryRewritePromptOverride
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}