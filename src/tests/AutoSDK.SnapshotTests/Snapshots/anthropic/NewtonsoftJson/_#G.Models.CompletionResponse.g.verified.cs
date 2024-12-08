//HintName: G.Models.CompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionResponse
    {
        /// <summary>
        /// Object type.<br/>
        /// For Text Completions, this is always `"completion"`.<br/>
        /// Default Value: completion
        /// </summary>
        /// <default>global::G.CompletionResponseType.Completion</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CompletionResponseType Type { get; set; } = global::G.CompletionResponseType.Completion;

        /// <summary>
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The resulting completion up to and excluding the stop sequences.<br/>
        /// Example:  Hello! My name is Claude.
        /// </summary>
        /// <example> Hello! My name is Claude.</example>
        [global::Newtonsoft.Json.JsonProperty("completion", Required = global::Newtonsoft.Json.Required.Always)]
        public string Completion { get; set; } = default!;

        /// <summary>
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// * `"stop_sequence"`: we reached a stop sequence — either provided by you via the `stop_sequences` parameter, or a stop sequence built into the model<br/>
        /// * `"max_tokens"`: we exceeded `max_tokens_to_sample` or the model's maximum<br/>
        /// Example: stop_sequence
        /// </summary>
        /// <example>stop_sequence</example>
        [global::Newtonsoft.Json.JsonProperty("stop_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string? StopReason { get; set; } = default!;

        /// <summary>
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Model Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Object type.<br/>
        /// For Text Completions, this is always `"completion"`.<br/>
        /// Default Value: completion
        /// </param>
        /// <param name="id">
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="completion">
        /// The resulting completion up to and excluding the stop sequences.<br/>
        /// Example:  Hello! My name is Claude.
        /// </param>
        /// <param name="stopReason">
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// * `"stop_sequence"`: we reached a stop sequence — either provided by you via the `stop_sequences` parameter, or a stop sequence built into the model<br/>
        /// * `"max_tokens"`: we exceeded `max_tokens_to_sample` or the model's maximum<br/>
        /// Example: stop_sequence
        /// </param>
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        public CompletionResponse(
            string id,
            string completion,
            string? stopReason,
            global::G.Model model,
            global::G.CompletionResponseType type = global::G.CompletionResponseType.Completion)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.StopReason = stopReason ?? throw new global::System.ArgumentNullException(nameof(stopReason));
            this.Model = model;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        public CompletionResponse()
        {
        }
    }
}