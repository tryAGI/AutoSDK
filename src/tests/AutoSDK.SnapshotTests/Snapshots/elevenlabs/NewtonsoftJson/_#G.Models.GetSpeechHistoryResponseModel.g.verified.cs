//HintName: G.Models.GetSpeechHistoryResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"has_more":true,"history":[{"character_count_change_from":17189,"character_count_change_to":17231,"content_type":"audio/mpeg","date_unix":1714650306,"history_item_id":"ja9xsmfGhxYcymxGcOGB","model_id":"eleven_multilingual_v2","request_id":"BF0BZg4IwLGBlaVjv9Im","settings":{"similarity_boost":0.5,"stability":0.71,"style":0,"use_speaker_boost":true},"source":"TTS","state":"created","text":"Hello, world!","voice_category":"premade","voice_id":"21m00Tcm4TlvDq8ikWAM","voice_name":"Rachel"}],"last_history_item_id":"ja9xsmfGhxYcymxGcOGB"}
    /// </summary>
    public sealed partial class GetSpeechHistoryResponseModel
    {
        /// <summary>
        /// A list of speech history items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("history", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SpeechHistoryItemResponseModel> History { get; set; } = default!;

        /// <summary>
        /// The ID of the last history item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_history_item_id")]
        public string? LastHistoryItemId { get; set; }

        /// <summary>
        /// Whether there are more history items to fetch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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