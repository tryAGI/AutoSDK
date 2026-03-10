//HintName: G.Models.PromptAgentAPIModelOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}
    /// </summary>
    public sealed partial class PromptAgentAPIModelOverride
    {
        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The LLM to query with the prompt and the chat history. If using data residency, the LLM must be supported in the data residency environment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm")]
        public global::G.Llm? Llm { get; set; }

        /// <summary>
        /// A list of Native MCP server ids to be used by the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("native_mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? NativeMcpServerIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverride" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
        /// <param name="llm">
        /// The LLM to query with the prompt and the chat history. If using data residency, the LLM must be supported in the data residency environment
        /// </param>
        /// <param name="nativeMcpServerIds">
        /// A list of Native MCP server ids to be used by the agent
        /// </param>
        public PromptAgentAPIModelOverride(
            string? prompt,
            global::G.Llm? llm,
            global::System.Collections.Generic.IList<string>? nativeMcpServerIds)
        {
            this.Prompt = prompt;
            this.Llm = llm;
            this.NativeMcpServerIds = nativeMcpServerIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverride" /> class.
        /// </summary>
        public PromptAgentAPIModelOverride()
        {
        }
    }
}