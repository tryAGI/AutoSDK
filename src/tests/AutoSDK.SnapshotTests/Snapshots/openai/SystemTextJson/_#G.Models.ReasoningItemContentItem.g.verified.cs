//HintName: G.Models.ReasoningItemContentItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReasoningItemContentItem
    {
        /// <summary>
        /// A short summary of the reasoning used by the model when generating<br/>
        /// the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the object. Always `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningItemContentItemTypeJsonConverter))]
        public global::G.ReasoningItemContentItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemContentItem" /> class.
        /// </summary>
        /// <param name="text">
        /// A short summary of the reasoning used by the model when generating<br/>
        /// the response.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningItemContentItem(
            string text,
            global::G.ReasoningItemContentItemType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemContentItem" /> class.
        /// </summary>
        public ReasoningItemContentItem()
        {
        }
    }
}