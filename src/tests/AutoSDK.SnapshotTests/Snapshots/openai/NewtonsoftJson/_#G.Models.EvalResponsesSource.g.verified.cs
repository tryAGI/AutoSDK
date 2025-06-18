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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EvalResponsesSourceType Type { get; set; }

        /// <summary>
        /// Metadata filter for the responses. This is a query parameter used to select responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The name of the model to find responses for. This is a query parameter used to select responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional string to search the 'instructions' field. This is a query parameter used to select responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions_search")]
        public string? InstructionsSearch { get; set; }

        /// <summary>
        /// Only include items created after this timestamp (inclusive). This is a query parameter used to select responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_after")]
        public int? CreatedAfter { get; set; }

        /// <summary>
        /// Only include items created before this timestamp (inclusive). This is a query parameter used to select responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_before")]
        public int? CreatedBefore { get; set; }

        /// <summary>
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        public global::G.ReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Sampling temperature. This is a query parameter used to select responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter. This is a query parameter used to select responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// List of user identifiers. This is a query parameter used to select responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// List of tool names. This is a query parameter used to select responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// Optional string to search the 'instructions' field. This is a query parameter used to select responses.
        /// </param>
        /// <param name="createdAfter">
        /// Only include items created after this timestamp (inclusive). This is a query parameter used to select responses.
        /// </param>
        /// <param name="createdBefore">
        /// Only include items created before this timestamp (inclusive). This is a query parameter used to select responses.
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
        /// <param name="tools">
        /// List of tool names. This is a query parameter used to select responses.
        /// </param>
        public EvalResponsesSource(
            global::G.EvalResponsesSourceType type,
            object? metadata,
            string? model,
            string? instructionsSearch,
            int? createdAfter,
            int? createdBefore,
            global::G.ReasoningEffort? reasoningEffort,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<string>? tools)
        {
            this.Type = type;
            this.Metadata = metadata;
            this.Model = model;
            this.InstructionsSearch = instructionsSearch;
            this.CreatedAfter = createdAfter;
            this.CreatedBefore = createdBefore;
            this.ReasoningEffort = reasoningEffort;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Users = users;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResponsesSource" /> class.
        /// </summary>
        public EvalResponsesSource()
        {
        }
    }
}