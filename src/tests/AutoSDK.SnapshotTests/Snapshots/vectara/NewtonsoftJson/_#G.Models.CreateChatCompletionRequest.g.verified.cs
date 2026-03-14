//HintName: G.Models.CreateChatCompletionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The request object for creating a chat completion with an OpenAI-compatible interface. This object is compatible with OpenAI's chat completion schema and supports customizable parameters for response generation.
    /// </summary>
    public sealed partial class CreateChatCompletionRequest
    {
        /// <summary>
        /// The ID of the model to use. This field is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// An ordered array of messages that represent the full context of the conversation to date. Each message includes a `role` and `content`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Optional. When set to `true`, the API streams partial message deltas as they become available, similar to ChatGPT's streaming mode.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Specifies the format the model must output.<br/>
        /// - `text`: Plain text responses (default).<br/>
        /// - `json_object`: Ensures the response is valid JSON.<br/>
        /// - `json_schema`: Ensures the response conforms to the provided JSON schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The ID of the model to use. This field is required.
        /// </param>
        /// <param name="messages">
        /// An ordered array of messages that represent the full context of the conversation to date. Each message includes a `role` and `content`.
        /// </param>
        /// <param name="stream">
        /// Optional. When set to `true`, the API streams partial message deltas as they become available, similar to ChatGPT's streaming mode.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format the model must output.<br/>
        /// - `text`: Plain text responses (default).<br/>
        /// - `json_object`: Ensures the response is valid JSON.<br/>
        /// - `json_schema`: Ensures the response conforms to the provided JSON schema.
        /// </param>
        public CreateChatCompletionRequest(
            string model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            bool? stream,
            global::G.ResponseFormat? responseFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Stream = stream;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        public CreateChatCompletionRequest()
        {
        }
    }
}