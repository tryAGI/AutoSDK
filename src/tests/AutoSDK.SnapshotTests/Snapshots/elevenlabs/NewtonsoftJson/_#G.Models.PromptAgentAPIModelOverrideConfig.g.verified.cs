//HintName: G.Models.PromptAgentAPIModelOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentAPIModelOverrideConfig
    {
        /// <summary>
        /// Whether to allow overriding the prompt field.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public bool? Prompt { get; set; }

        /// <summary>
        /// Whether to allow overriding the llm field.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm")]
        public bool? Llm { get; set; }

        /// <summary>
        /// Whether to allow overriding the native_mcp_server_ids field.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("native_mcp_server_ids")]
        public bool? NativeMcpServerIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverrideConfig" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Whether to allow overriding the prompt field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="llm">
        /// Whether to allow overriding the llm field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="nativeMcpServerIds">
        /// Whether to allow overriding the native_mcp_server_ids field.<br/>
        /// Default Value: false
        /// </param>
        public PromptAgentAPIModelOverrideConfig(
            bool? prompt,
            bool? llm,
            bool? nativeMcpServerIds)
        {
            this.Prompt = prompt;
            this.Llm = llm;
            this.NativeMcpServerIds = nativeMcpServerIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverrideConfig" /> class.
        /// </summary>
        public PromptAgentAPIModelOverrideConfig()
        {
        }
    }
}