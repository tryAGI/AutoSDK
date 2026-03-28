//HintName: G.Models.CompletionResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"completion":" Hello! My name is Claude.","id":"compl_018CKm6gsux7P8yMcwZbeCPw","model":"claude-2.1","stop_reason":"stop_sequence","type":"completion"}
    /// </summary>
    public sealed partial class CompletionResponse
    {
        /// <summary>
        /// Object type.<br/>
        /// For Text Completions, this is always `"completion"`.<br/>
        /// Default Value: completion
        /// </summary>
        /// <default>global::G.CompletionResponseType.Completion</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompletionResponseTypeJsonConverter))]
        public global::G.CompletionResponseType Type { get; set; } = global::G.CompletionResponseType.Completion;

        /// <summary>
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The resulting completion up to and excluding the stop sequences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Completion { get; set; }

        /// <summary>
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// * `"stop_sequence"`: we reached a stop sequence — either provided by you via the `stop_sequences` parameter, or a stop sequence built into the model<br/>
        /// * `"max_tokens"`: we exceeded `max_tokens_to_sample` or the model's maximum
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        public string? StopReason { get; set; }

        /// <summary>
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Model Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="completion">
        /// The resulting completion up to and excluding the stop sequences.
        /// </param>
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="stopReason">
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// * `"stop_sequence"`: we reached a stop sequence — either provided by you via the `stop_sequences` parameter, or a stop sequence built into the model<br/>
        /// * `"max_tokens"`: we exceeded `max_tokens_to_sample` or the model's maximum
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Text Completions, this is always `"completion"`.<br/>
        /// Default Value: completion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionResponse(
            string id,
            string completion,
            global::G.Model model,
            string? stopReason,
            global::G.CompletionResponseType type = global::G.CompletionResponseType.Completion)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.StopReason = stopReason;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        public CompletionResponse()
        {
        }
    }
}