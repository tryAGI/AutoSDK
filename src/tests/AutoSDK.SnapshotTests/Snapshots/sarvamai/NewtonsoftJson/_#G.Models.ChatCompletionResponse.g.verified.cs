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
        /// Unique completion identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Object type (always "chat.completion")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unix timestamp of creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Model used for the completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// List of completion choices
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionChoice>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.ChatCompletionUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique completion identifier
        /// </param>
        /// <param name="object">
        /// Object type (always "chat.completion")
        /// </param>
        /// <param name="created">
        /// Unix timestamp of creation
        /// </param>
        /// <param name="model">
        /// Model used for the completion
        /// </param>
        /// <param name="choices">
        /// List of completion choices
        /// </param>
        /// <param name="usage"></param>
        public ChatCompletionResponse(
            string? id,
            string? @object,
            global::System.DateTimeOffset? created,
            string? model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionChoice>? choices,
            global::G.ChatCompletionUsage? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        public ChatCompletionResponse()
        {
        }
    }
}