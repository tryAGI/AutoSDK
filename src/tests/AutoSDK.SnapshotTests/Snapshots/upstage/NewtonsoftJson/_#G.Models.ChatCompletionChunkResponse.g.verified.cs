//HintName: G.Models.ChatCompletionChunkResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChunkResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion chunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type, always "chat.completion.chunk".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionChunkResponseObjectJsonConverter))]
        public global::G.ChatCompletionChunkResponseObject? Object { get; set; }

        /// <summary>
        /// The Unix timestamp of when the chunk was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// The model used for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// A list of chat completion chunk choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionChunkChoice>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chat completion chunk.
        /// </param>
        /// <param name="object">
        /// The object type, always "chat.completion.chunk".
        /// </param>
        /// <param name="created">
        /// The Unix timestamp of when the chunk was created.
        /// </param>
        /// <param name="model">
        /// The model used for the chat completion.
        /// </param>
        /// <param name="choices">
        /// A list of chat completion chunk choices.
        /// </param>
        /// <param name="usage"></param>
        public ChatCompletionChunkResponse(
            string? id,
            global::G.ChatCompletionChunkResponseObject? @object,
            global::System.DateTimeOffset? created,
            string? model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionChunkChoice>? choices,
            global::G.Usage? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkResponse" /> class.
        /// </summary>
        public ChatCompletionChunkResponse()
        {
        }
    }
}