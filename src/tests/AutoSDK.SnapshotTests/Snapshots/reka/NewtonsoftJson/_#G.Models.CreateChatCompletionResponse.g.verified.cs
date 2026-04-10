//HintName: G.Models.CreateChatCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The model used for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The object type (e.g., "chat.completion").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unix timestamp of when the completion was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// System fingerprint for the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// A list of chat completion choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Choice> Choices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Usage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chat completion.
        /// </param>
        /// <param name="model">
        /// The model used for the chat completion.
        /// </param>
        /// <param name="choices">
        /// A list of chat completion choices.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="object">
        /// The object type (e.g., "chat.completion").
        /// </param>
        /// <param name="created">
        /// Unix timestamp of when the completion was created.
        /// </param>
        /// <param name="systemFingerprint">
        /// System fingerprint for the response.
        /// </param>
        public CreateChatCompletionResponse(
            string id,
            string model,
            global::System.Collections.Generic.IList<global::G.Choice> choices,
            global::G.Usage usage,
            string? @object,
            global::System.DateTimeOffset? created,
            string? systemFingerprint)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.Created = created;
            this.SystemFingerprint = systemFingerprint;
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponse" /> class.
        /// </summary>
        public CreateChatCompletionResponse()
        {
        }
    }
}