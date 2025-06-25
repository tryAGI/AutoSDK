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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningItemSummaryItemTypeJsonConverter))]
        public global::G.ReasoningItemSummaryItemType Type { get; set; }

        /// <summary>
        /// A short summary of the reasoning used by the model when generating<br/>
        /// the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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