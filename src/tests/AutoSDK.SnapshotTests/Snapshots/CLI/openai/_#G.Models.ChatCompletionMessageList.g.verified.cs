//HintName: G.Models.ChatCompletionMessageList.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An object representing a list of chat completion messages.
    /// </summary>
    public sealed partial class ChatCompletionMessageList
    {
        /// <summary>
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </summary>
        /// <default>global::G.ChatCompletionMessageListObject.List</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageListObjectJsonConverter))]
        public global::G.ChatCompletionMessageListObject Object { get; set; } = global::G.ChatCompletionMessageListObject.List;

        /// <summary>
        /// An array of chat completion message objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AllOf<global::G.ChatCompletionResponseMessage, global::G.ChatCompletionMessageListDataItem>> Data { get; set; }

        /// <summary>
        /// The identifier of the first chat message in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// The identifier of the last chat message in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// Indicates whether there are more chat messages available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageList" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </param>
        /// <param name="data">
        /// An array of chat completion message objects.
        /// </param>
        /// <param name="firstId">
        /// The identifier of the first chat message in the data array.
        /// </param>
        /// <param name="lastId">
        /// The identifier of the last chat message in the data array.
        /// </param>
        /// <param name="hasMore">
        /// Indicates whether there are more chat messages available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageList(
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.ChatCompletionResponseMessage, global::G.ChatCompletionMessageListDataItem>> data,
            string firstId,
            string lastId,
            bool hasMore,
            global::G.ChatCompletionMessageListObject @object = global::G.ChatCompletionMessageListObject.List)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.HasMore = hasMore;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageList" /> class.
        /// </summary>
        public ChatCompletionMessageList()
        {
        }
    }
}