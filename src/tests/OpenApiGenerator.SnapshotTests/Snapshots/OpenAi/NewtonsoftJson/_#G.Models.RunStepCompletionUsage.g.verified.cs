//HintName: G.Models.RunStepCompletionUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage statistics related to the run step. This value will be `null` while the run step's status is `in_progress`.
    /// </summary>
    public sealed partial class RunStepCompletionUsage
    {
        /// <summary>
        /// Number of completion tokens used over the course of the run step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Number of prompt tokens used over the course of the run step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// Total number of tokens used (prompt + completion).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}