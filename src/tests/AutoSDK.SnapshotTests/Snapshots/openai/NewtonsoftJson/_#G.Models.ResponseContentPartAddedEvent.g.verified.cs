//HintName: G.Models.ResponseContentPartAddedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a new content part is added.
    /// </summary>
    public sealed partial class ResponseContentPartAddedEvent
    {
        /// <summary>
        /// The index of the content part that was added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the output item that the content part was added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the content part was added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OutputContent Part { get; set; } = default!;

        /// <summary>
        /// The type of the event. Always `response.content_part.added`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseContentPartAddedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseContentPartAddedEvent" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the content part that was added.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the content part was added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the content part was added to.
        /// </param>
        /// <param name="part"></param>
        /// <param name="type">
        /// The type of the event. Always `response.content_part.added`.
        /// </param>
        public ResponseContentPartAddedEvent(
            int contentIndex,
            string itemId,
            int outputIndex,
            global::G.OutputContent part,
            global::G.ResponseContentPartAddedEventType type)
        {
            this.ContentIndex = contentIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Part = part;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseContentPartAddedEvent" /> class.
        /// </summary>
        public ResponseContentPartAddedEvent()
        {
        }
    }
}