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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponse> Data { get; set; } = default!;

        /// <summary>
        /// The identifier of the first chat completion in the data array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstId { get; set; } = default!;

        /// <summary>
        /// Indicates whether there are more Chat Completions available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// The identifier of the last chat completion in the data array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastId { get; set; } = default!;

        /// <summary>
        /// The type of this object. It is always set to "list".<br/>
        /// Default Value: list
        /// </summary>
        /// <default>global::G.ChatCompletionListObject.List</default>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ChatCompletionListObject Object { get; set; } = global::G.ChatCompletionListObject.List;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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