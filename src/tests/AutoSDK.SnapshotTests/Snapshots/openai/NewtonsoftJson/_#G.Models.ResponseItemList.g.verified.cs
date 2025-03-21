//HintName: G.Models.ResponseItemList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of Response items.
    /// </summary>
    public sealed partial class ResponseItemList
    {
        /// <summary>
        /// A list of items used to generate this response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ItemResource> Data { get; set; } = default!;

        /// <summary>
        /// The ID of the first item in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstId { get; set; } = default!;

        /// <summary>
        /// Whether there are more items available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// The ID of the last item in the list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastId { get; set; } = default!;

        /// <summary>
        /// The type of object returned, must be `list`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ResponseItemListObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemList" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of items used to generate this response.
        /// </param>
        /// <param name="firstId">
        /// The ID of the first item in the list.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more items available.
        /// </param>
        /// <param name="lastId">
        /// The ID of the last item in the list.
        /// </param>
        /// <param name="object">
        /// The type of object returned, must be `list`.
        /// </param>
        public ResponseItemList(
            global::System.Collections.Generic.IList<global::G.ItemResource> data,
            string firstId,
            bool hasMore,
            string lastId,
            global::G.ResponseItemListObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.HasMore = hasMore;
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItemList" /> class.
        /// </summary>
        public ResponseItemList()
        {
        }
    }
}