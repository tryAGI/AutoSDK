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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MemoriesCreateResponseItemData Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MemoriesCreateResponseItemEventJsonConverter))]
        public global::G.MemoriesCreateResponseItemEvent Event { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesCreateResponseItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="event"></param>
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