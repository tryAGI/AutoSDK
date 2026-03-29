//HintName: G.Models.MemoriesCreateResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesCreateResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MemoriesCreateResponseItemData Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MemoriesCreateResponseItemEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MemoriesCreateResponseItemEvent Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesCreateResponseItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesCreateResponseItem(
            string id,
            global::G.MemoriesCreateResponseItemData data,
            global::G.MemoriesCreateResponseItemEvent @event)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesCreateResponseItem" /> class.
        /// </summary>
        public MemoriesCreateResponseItem()
        {
        }
    }
}