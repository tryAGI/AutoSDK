//HintName: G.Models.ChatCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type, always "chat.completion".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ChatCompletionResponseObject? Object { get; set; }

        /// <summary>
        /// The Unix timestamp of when the chat completion was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// The model used for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// A list of chat completion choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionChoice>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// System fingerprint for the model configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chat completion.
        /// </param>
        /// <param name="object">
        /// The object type, always "chat.completion".
        /// </param>
        /// <param name="created">
        /// The Unix timestamp of when the chat completion was created.
        /// </param>
        /// <param name="model">
        /// The model used for the chat completion.
        /// </param>
        /// <param name="choices">
        /// A list of chat completion choices.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="systemFingerprint">
        /// System fingerprint for the model configuration.
        /// </param>
        public ChatCompletionResponse(
            string? id,
            global::G.ChatCompletionResponseObject? @object,
            global::System.DateTimeOffset? created,
            string? model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionChoice>? choices,
            global::G.Usage? usage,
            string? systemFingerprint)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
            this.SystemFingerprint = systemFingerprint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        public ChatCompletionResponse()
        {
        }
    }
}