//HintName: G.Models.AgentsCompletionRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCompletionRequest
    {
        /// <summary>
        /// The ID of the agent to use for this completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The prompt(s) to generate completions for, encoded as a list of dict with role and content.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MessagesItem> Messages { get; set; }

        /// <summary>
        /// The minimum number of tokens to generate in the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_tokens")]
        public int? MinTokens { get; set; }

        /// <summary>
        /// The seed to use for random sampling. If set, different calls will generate deterministic results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random_seed")]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Stop generation if this token is detected. Or if one of these tokens is detected when providing an array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-side events as they become available, with the stream terminated by a data: [DONE] message. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ToolChoice3, global::G.ToolChoiceEnum?>))]
        public global::G.AnyOf<global::G.ToolChoice3, global::G.ToolChoiceEnum?>? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCompletionRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent to use for this completion.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// </param>
        /// <param name="messages">
        /// The prompt(s) to generate completions for, encoded as a list of dict with role and content.<br/>
        /// Example: []
        /// </param>
        /// <param name="minTokens">
        /// The minimum number of tokens to generate in the completion.
        /// </param>
        /// <param name="randomSeed">
        /// The seed to use for random sampling. If set, different calls will generate deterministic results.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="stop">
        /// Stop generation if this token is detected. Or if one of these tokens is detected when providing an array
        /// </param>
        /// <param name="stream">
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-side events as they become available, with the stream terminated by a data: [DONE] message. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="toolChoice">
        /// Default Value: auto
        /// </param>
        /// <param name="tools"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AgentsCompletionRequest(
            string agentId,
            global::System.Collections.Generic.IList<global::G.MessagesItem> messages,
            int? maxTokens,
            int? minTokens,
            int? randomSeed,
            global::G.ResponseFormat? responseFormat,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop,
            bool? stream,
            global::G.AnyOf<global::G.ToolChoice3, global::G.ToolChoiceEnum?>? toolChoice,
            global::System.Collections.Generic.IList<global::G.Tool>? tools)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxTokens = maxTokens;
            this.MinTokens = minTokens;
            this.RandomSeed = randomSeed;
            this.ResponseFormat = responseFormat;
            this.Stop = stop;
            this.Stream = stream;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCompletionRequest" /> class.
        /// </summary>
        public AgentsCompletionRequest()
        {
        }
    }
}