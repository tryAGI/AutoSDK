//HintName: G.Models.GenerateChatCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response class for the chat endpoint.
    /// </summary>
    public sealed partial class GenerateChatCompletionResponse
    {
        /// <summary>
        /// A message in the chat endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Message Message { get; set; } = default!;

        /// <summary>
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: llama3.2
        /// </summary>
        /// <example>llama3.2</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Date on which a model was created.<br/>
        /// Example: 2023-08-04T19:22:45.4991270+00:00
        /// </summary>
        /// <example>2023-08-04T19:22:45.4991270+00:00</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Whether the response has completed.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("done", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Done { get; set; } = default!;

        /// <summary>
        /// Reason why the model is done generating a response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("done_reason")]
        public global::G.DoneReason? DoneReason { get; set; }

        /// <summary>
        /// Time spent generating the response.<br/>
        /// Example: 5589157167
        /// </summary>
        /// <example>5589157167</example>
        [global::Newtonsoft.Json.JsonProperty("total_duration")]
        public long? TotalDuration { get; set; }

        /// <summary>
        /// Time spent in nanoseconds loading the model.<br/>
        /// Example: 3013701500
        /// </summary>
        /// <example>3013701500</example>
        [global::Newtonsoft.Json.JsonProperty("load_duration")]
        public long? LoadDuration { get; set; }

        /// <summary>
        /// Number of tokens in the prompt.<br/>
        /// Example: 46
        /// </summary>
        /// <example>46</example>
        [global::Newtonsoft.Json.JsonProperty("prompt_eval_count")]
        public int? PromptEvalCount { get; set; }

        /// <summary>
        /// Time spent in nanoseconds evaluating the prompt.<br/>
        /// Example: 1160282000
        /// </summary>
        /// <example>1160282000</example>
        [global::Newtonsoft.Json.JsonProperty("prompt_eval_duration")]
        public long? PromptEvalDuration { get; set; }

        /// <summary>
        /// Number of tokens the response.<br/>
        /// Example: 113
        /// </summary>
        /// <example>113</example>
        [global::Newtonsoft.Json.JsonProperty("eval_count")]
        public int? EvalCount { get; set; }

        /// <summary>
        /// Time in nanoseconds spent generating the response.<br/>
        /// Example: 1325948000
        /// </summary>
        /// <example>1325948000</example>
        [global::Newtonsoft.Json.JsonProperty("eval_duration")]
        public long? EvalDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// A message in the chat endpoint
        /// </param>
        /// <param name="model">
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: llama3.2
        /// </param>
        /// <param name="createdAt">
        /// Date on which a model was created.<br/>
        /// Example: 2023-08-04T19:22:45.4991270+00:00
        /// </param>
        /// <param name="done">
        /// Whether the response has completed.<br/>
        /// Example: true
        /// </param>
        /// <param name="doneReason">
        /// Reason why the model is done generating a response.
        /// </param>
        /// <param name="totalDuration">
        /// Time spent generating the response.<br/>
        /// Example: 5589157167
        /// </param>
        /// <param name="loadDuration">
        /// Time spent in nanoseconds loading the model.<br/>
        /// Example: 3013701500
        /// </param>
        /// <param name="promptEvalCount">
        /// Number of tokens in the prompt.<br/>
        /// Example: 46
        /// </param>
        /// <param name="promptEvalDuration">
        /// Time spent in nanoseconds evaluating the prompt.<br/>
        /// Example: 1160282000
        /// </param>
        /// <param name="evalCount">
        /// Number of tokens the response.<br/>
        /// Example: 113
        /// </param>
        /// <param name="evalDuration">
        /// Time in nanoseconds spent generating the response.<br/>
        /// Example: 1325948000
        /// </param>
        public GenerateChatCompletionResponse(
            global::G.Message message,
            string model,
            global::System.DateTime createdAt,
            bool done,
            global::G.DoneReason? doneReason,
            long? totalDuration,
            long? loadDuration,
            int? promptEvalCount,
            long? promptEvalDuration,
            int? evalCount,
            long? evalDuration)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.CreatedAt = createdAt;
            this.Done = done;
            this.DoneReason = doneReason;
            this.TotalDuration = totalDuration;
            this.LoadDuration = loadDuration;
            this.PromptEvalCount = promptEvalCount;
            this.PromptEvalDuration = promptEvalDuration;
            this.EvalCount = evalCount;
            this.EvalDuration = evalDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateChatCompletionResponse" /> class.
        /// </summary>
        public GenerateChatCompletionResponse()
        {
        }
    }
}