//HintName: G.Models.ReasoningItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A description of the chain of thought used by a reasoning model while generating<br/>
    /// a response.
    /// </summary>
    public sealed partial class ReasoningItem
    {
        /// <summary>
        /// Reasoning text contents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ReasoningItemContentItem> Content { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the reasoning content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ReasoningItemStatus? Status { get; set; }

        /// <summary>
        /// The type of the object. Always `reasoning`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ReasoningItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        /// <param name="content">
        /// Reasoning text contents.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the reasoning content.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `reasoning`.
        /// </param>
        public ReasoningItem(
            global::System.Collections.Generic.IList<global::G.ReasoningItemContentItem> content,
            string id,
            global::G.ReasoningItemStatus? status,
            global::G.ReasoningItemType type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        public ReasoningItem()
        {
        }
    }
}