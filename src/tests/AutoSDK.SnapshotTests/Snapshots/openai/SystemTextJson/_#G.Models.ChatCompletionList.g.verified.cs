//HintName: G.Models.ChatCompletionList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object representing a list of Chat Completions.
    /// </summary>
    public sealed partial class ChatCompletionList
    {
        /// <summary>
        /// An array of chat completion objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponse> Data { get; set; }

        /// <summary>
        /// The identifier of the first chat completion in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// Indicates whether there are more Chat Completions available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The identifier of the last chat completion in the data array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </summary>
        /// <default>global::G.ChatCompletionListObject.List</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionListObjectJsonConverter))]
        public global::G.ChatCompletionListObject Object { get; set; } = global::G.ChatCompletionListObject.List;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionList" /> class.
        /// </summary>
        /// <param name="data">
        /// An array of chat completion objects.
        /// </param>
        /// <param name="firstId">
        /// The identifier of the first chat completion in the data array.
        /// </param>
        /// <param name="hasMore">
        /// Indicates whether there are more Chat Completions available.
        /// </param>
        /// <param name="lastId">
        /// The identifier of the last chat completion in the data array.
        /// </param>
        /// <param name="object">
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionList(
            global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponse> data,
            string firstId,
            bool hasMore,
            string lastId,
            global::G.ChatCompletionListObject @object = global::G.ChatCompletionListObject.List)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.HasMore = hasMore;
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionList" /> class.
        /// </summary>
        public ChatCompletionList()
        {
        }
    }
}