//HintName: G.Models.CreatePromptCompletionRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Note: Although hyperparameters are shown grouped here (like messages, max_completion_tokens, temperature, etc.), they should only be passed at the root level, alongside 'variables' and 'stream'. The `max_tokens` parameter is deprecated — use `max_completion_tokens` instead.
    /// </summary>
    public sealed partial class CreatePromptCompletionRequest2
    {
        /// <summary>
        /// Variables to substitute in the prompt template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Default: False. Set to True if you want to stream the response<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// **Note**: All hyperparameters are optional. Pass them at the root level, and not nested under `hyperparameters`. Their grouping here is for educational purposes only.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters")]
        public global::G.OneOf<global::G.CreateChatCompletionRequest, global::G.CreateCompletionRequest>? Hyperparameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptCompletionRequest2" /> class.
        /// </summary>
        /// <param name="variables">
        /// Variables to substitute in the prompt template
        /// </param>
        /// <param name="stream">
        /// Default: False. Set to True if you want to stream the response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="hyperparameters">
        /// **Note**: All hyperparameters are optional. Pass them at the root level, and not nested under `hyperparameters`. Their grouping here is for educational purposes only.
        /// </param>
        public CreatePromptCompletionRequest2(
            object? variables,
            bool? stream,
            global::G.OneOf<global::G.CreateChatCompletionRequest, global::G.CreateCompletionRequest>? hyperparameters)
        {
            this.Variables = variables;
            this.Stream = stream;
            this.Hyperparameters = hyperparameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptCompletionRequest2" /> class.
        /// </summary>
        public CreatePromptCompletionRequest2()
        {
        }
    }
}