//HintName: G.Models.GetSpeechHistoryResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpeechHistoryResponseModel
    {
        /// <summary>
        /// A list of speech history items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SpeechHistoryItemResponseModel> History { get; set; }

        /// <summary>
        /// The ID of the last history item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_history_item_id")]
        public string? LastHistoryItemId { get; set; }

        /// <summary>
        /// Whether there are more history items to fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpeechHistoryResponseModel" /> class.
        /// </summary>
        /// <param name="history">
        /// A list of speech history items.
        /// </param>
        /// <param name="lastHistoryItemId">
        /// The ID of the last history item.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more history items to fetch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpeechHistoryResponseModel(
            global::System.Collections.Generic.IList<global::G.SpeechHistoryItemResponseModel> history,
            bool hasMore,
            string? lastHistoryItemId)
        {
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
            this.HasMore = hasMore;
            this.LastHistoryItemId = lastHistoryItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpeechHistoryResponseModel" /> class.
        /// </summary>
        public GetSpeechHistoryResponseModel()
        {
        }
    }
}