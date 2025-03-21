//HintName: G.Models.ChatCompletionDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionDeleted
    {
        /// <summary>
        /// Whether the chat completion was deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// The ID of the chat completion that was deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of object being deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ChatCompletionDeletedObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDeleted" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the chat completion was deleted.
        /// </param>
        /// <param name="id">
        /// The ID of the chat completion that was deleted.
        /// </param>
        /// <param name="object">
        /// The type of object being deleted.
        /// </param>
        public ChatCompletionDeleted(
            bool deleted,
            string id,
            global::G.ChatCompletionDeletedObject @object)
        {
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDeleted" /> class.
        /// </summary>
        public ChatCompletionDeleted()
        {
        }
    }
}