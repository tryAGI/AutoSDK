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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SpeechHistoryItemResponseModel> History { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_history_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastHistoryItemId { get; set; }

        /// <summary>
        /// 
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
        /// <param name="history"></param>
        /// <param name="lastHistoryItemId"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpeechHistoryResponseModel(
            global::System.Collections.Generic.IList<global::G.SpeechHistoryItemResponseModel> history,
            string lastHistoryItemId,
            bool hasMore)
        {
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
            this.LastHistoryItemId = lastHistoryItemId ?? throw new global::System.ArgumentNullException(nameof(lastHistoryItemId));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpeechHistoryResponseModel" /> class.
        /// </summary>
        public GetSpeechHistoryResponseModel()
        {
        }
    }
}