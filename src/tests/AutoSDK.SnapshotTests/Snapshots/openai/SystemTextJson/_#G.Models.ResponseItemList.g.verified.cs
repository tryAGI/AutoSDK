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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ItemResource> Data { get; set; }

        /// <summary>
        /// The ID of the first item in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// Whether there are more items available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The ID of the last item in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// The type of object returned, must be `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseItemListObjectJsonConverter))]
        public global::G.ResponseItemListObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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