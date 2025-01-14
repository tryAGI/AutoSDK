﻿//HintName: G.Models.AgentsCompletionRequest.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The prompt(s) to generate completions for, encoded as a list of dict with role and content.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MessagesItem> Messages { get; set; } = default!;

        /// <summary>
        /// The minimum number of tokens to generate in the completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_tokens")]
        public int? MinTokens { get; set; }

        /// <summary>
        /// The seed to use for random sampling. If set, different calls will generate deterministic results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("random_seed")]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Stop generation if this token is detected. Or if one of these tokens is detected when providing an array
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-side events as they become available, with the stream terminated by a data: [DONE] message. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.AnyOf<global::G.ToolChoice3, global::G.ToolChoiceEnum?>? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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