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
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The ID of the chat completion that was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of object being deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionDeletedObjectJsonConverter))]
        public global::G.ChatCompletionDeletedObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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