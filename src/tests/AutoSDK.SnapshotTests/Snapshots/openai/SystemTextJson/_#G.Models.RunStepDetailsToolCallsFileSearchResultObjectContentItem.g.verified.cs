//HintName: G.Models.RunStepDetailsToolCallsFileSearchResultObjectContentItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchResultObjectContentItem
    {
        /// <summary>
        /// The type of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStepDetailsToolCallsFileSearchResultObjectContentItemTypeJsonConverter))]
        public global::G.RunStepDetailsToolCallsFileSearchResultObjectContentItemType? Type { get; set; }

        /// <summary>
        /// The text content of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchResultObjectContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the content.
        /// </param>
        /// <param name="text">
        /// The text content of the file.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDetailsToolCallsFileSearchResultObjectContentItem(
            global::G.RunStepDetailsToolCallsFileSearchResultObjectContentItemType? type,
            string? text)
        {
            this.Type = type;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchResultObjectContentItem" /> class.
        /// </summary>
        public RunStepDetailsToolCallsFileSearchResultObjectContentItem()
        {
        }
    }
}