//HintName: G.Models.ReasoningItemSummaryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReasoningItemSummaryItem
    {
        /// <summary>
        /// The type of the object. Always `summary_text`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ReasoningItemSummaryItemType Type { get; set; }

        /// <summary>
        /// A short summary of the reasoning used by the model when generating<br/>
        /// the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemSummaryItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `summary_text`.
        /// </param>
        /// <param name="text">
        /// A short summary of the reasoning used by the model when generating<br/>
        /// the response.
        /// </param>
        public ReasoningItemSummaryItem(
            string text,
            global::G.ReasoningItemSummaryItemType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemSummaryItem" /> class.
        /// </summary>
        public ReasoningItemSummaryItem()
        {
        }
    }
}