//HintName: G.Models.TurnTokenData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Token data for a single LLM generation turn in a multi-turn agent interaction.<br/>
    /// Used for RL training to track token IDs and logprobs across all LLM calls,<br/>
    /// not just the final one. Tool results are included so the client can tokenize<br/>
    /// them with loss_mask=0 (non-trainable).
    /// </summary>
    public sealed partial class TurnTokenData
    {
        /// <summary>
        /// Role of this turn: 'assistant' for LLM generations (trainable), 'tool' for tool results (non-trainable).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TurnTokenDataRole Role { get; set; } = default!;

        /// <summary>
        /// Token IDs from SGLang native endpoint. Only present for assistant turns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_ids")]
        public global::System.Collections.Generic.IList<int>? OutputIds { get; set; }

        /// <summary>
        /// Logprobs from SGLang: [[logprob, token_id, top_logprob_or_null], ...]. Only present for assistant turns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_token_logprobs")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? OutputTokenLogprobs { get; set; }

        /// <summary>
        /// Text content. For tool turns, client tokenizes this with loss_mask=0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Name of the tool called. Only present for tool turns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnTokenData" /> class.
        /// </summary>
        /// <param name="role">
        /// Role of this turn: 'assistant' for LLM generations (trainable), 'tool' for tool results (non-trainable).
        /// </param>
        /// <param name="outputIds">
        /// Token IDs from SGLang native endpoint. Only present for assistant turns.
        /// </param>
        /// <param name="outputTokenLogprobs">
        /// Logprobs from SGLang: [[logprob, token_id, top_logprob_or_null], ...]. Only present for assistant turns.
        /// </param>
        /// <param name="content">
        /// Text content. For tool turns, client tokenizes this with loss_mask=0.
        /// </param>
        /// <param name="toolName">
        /// Name of the tool called. Only present for tool turns.
        /// </param>
        public TurnTokenData(
            global::G.TurnTokenDataRole role,
            global::System.Collections.Generic.IList<int>? outputIds,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? outputTokenLogprobs,
            string? content,
            string? toolName)
        {
            this.Role = role;
            this.OutputIds = outputIds;
            this.OutputTokenLogprobs = outputTokenLogprobs;
            this.Content = content;
            this.ToolName = toolName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnTokenData" /> class.
        /// </summary>
        public TurnTokenData()
        {
        }
    }
}