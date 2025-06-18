//HintName: G.Models.ReasoningItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A description of the chain of thought used by a reasoning model while generating<br/>
    /// a response. Be sure to include these items in your `input` to the Responses API<br/>
    /// for subsequent turns of a conversation if you are manually <br/>
    /// [managing context](/docs/guides/conversation-state).
    /// </summary>
    public sealed partial class ReasoningItem
    {
        /// <summary>
        /// The type of the object. Always `reasoning`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ReasoningItemType Type { get; set; }

        /// <summary>
        /// The unique identifier of the reasoning content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The encrypted content of the reasoning item - populated when a response is<br/>
        /// generated with `reasoning.encrypted_content` in the `include` parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// Reasoning text contents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ReasoningItemSummaryItem> Summary { get; set; } = default!;

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ReasoningItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `reasoning`.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the reasoning content.
        /// </param>
        /// <param name="encryptedContent">
        /// The encrypted content of the reasoning item - populated when a response is<br/>
        /// generated with `reasoning.encrypted_content` in the `include` parameter.
        /// </param>
        /// <param name="summary">
        /// Reasoning text contents.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
        public ReasoningItem(
            string id,
            global::System.Collections.Generic.IList<global::G.ReasoningItemSummaryItem> summary,
            global::G.ReasoningItemType type,
            string? encryptedContent,
            global::G.ReasoningItemStatus? status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Type = type;
            this.EncryptedContent = encryptedContent;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        public ReasoningItem()
        {
        }
    }
}