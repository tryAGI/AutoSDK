//HintName: G.Models.EvalResponsesSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A EvalResponsesSource object describing a run data source configuration.
    /// </summary>
    public sealed partial class EvalResponsesSource
    {
        /// <summary>
        /// The type of run data source. Always `responses`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalResponsesSourceTypeJsonConverter))]
        public global::G.EvalResponsesSourceType Type { get; set; }

        /// <summary>
        /// Metadata filter for the responses. This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The name of the model to find responses for. This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional search string for instructions. This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions_search")]
        public string? InstructionsSearch { get; set; }

        /// <summary>
        /// Only include items created after this timestamp (inclusive). This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_after")]
        public int? CreatedAfter { get; set; }

        /// <summary>
        /// Only include items created before this timestamp (inclusive). This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_before")]
        public int? CreatedBefore { get; set; }

        /// <summary>
        /// Whether the response has tool calls. This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_tool_calls")]
        public bool? HasToolCalls { get; set; }

        /// <summary>
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningEffortJsonConverter))]
        public global::G.ReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Sampling temperature. This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter. This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// List of user identifiers. This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// Whether to allow parallel tool calls. This is a query parameter used to select responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_parallel_tool_calls")]
        public bool? AllowParallelToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResponsesSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of run data source. Always `responses`.
        /// </param>
        /// <param name="metadata">
        /// Metadata filter for the responses. This is a query parameter used to select responses.
        /// </param>
        /// <param name="model">
        /// The name of the model to find responses for. This is a query parameter used to select responses.
        /// </param>
        /// <param name="instructionsSearch">
        /// Optional search string for instructions. This is a query parameter used to select responses.
        /// </param>
        /// <param name="createdAfter">
        /// Only include items created after this timestamp (inclusive). This is a query parameter used to select responses.
        /// </param>
        /// <param name="createdBefore">
        /// Only include items created before this timestamp (inclusive). This is a query parameter used to select responses.
        /// </param>
        /// <param name="hasToolCalls">
        /// Whether the response has tool calls. This is a query parameter used to select responses.
        /// </param>
        /// <param name="reasoningEffort">
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature. This is a query parameter used to select responses.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter. This is a query parameter used to select responses.
        /// </param>
        /// <param name="users">
        /// List of user identifiers. This is a query parameter used to select responses.
        /// </param>
        /// <param name="allowParallelToolCalls">
        /// Whether to allow parallel tool calls. This is a query parameter used to select responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalResponsesSource(
            global::G.EvalResponsesSourceType type,
            object? metadata,
            string? model,
            string? instructionsSearch,
            int? createdAfter,
            int? createdBefore,
            bool? hasToolCalls,
            global::G.ReasoningEffort? reasoningEffort,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<string>? users,
            bool? allowParallelToolCalls)
        {
            this.Type = type;
            this.Metadata = metadata;
            this.Model = model;
            this.InstructionsSearch = instructionsSearch;
            this.CreatedAfter = createdAfter;
            this.CreatedBefore = createdBefore;
            this.HasToolCalls = hasToolCalls;
            this.ReasoningEffort = reasoningEffort;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Users = users;
            this.AllowParallelToolCalls = allowParallelToolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResponsesSource" /> class.
        /// </summary>
        public EvalResponsesSource()
        {
        }
    }
}