//HintName: G.Models.SpeechHistoryItemResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechHistoryItemResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HistoryItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechHistoryItemResponseModelVoiceCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpeechHistoryItemResponseModelVoiceCategory VoiceCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count_change_from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharacterCountChangeFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count_change_to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharacterCountChangeTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpeechHistoryItemResponseModelState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FeedbackResponseModel Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_link_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShareLinkId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechHistoryItemResponseModelSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpeechHistoryItemResponseModelSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignments")]
        public global::G.HistoryAlignmentsResponseModel? Alignments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechHistoryItemResponseModel" /> class.
        /// </summary>
        /// <param name="historyItemId"></param>
        /// <param name="requestId"></param>
        /// <param name="voiceId"></param>
        /// <param name="modelId"></param>
        /// <param name="voiceName"></param>
        /// <param name="voiceCategory"></param>
        /// <param name="text"></param>
        /// <param name="dateUnix"></param>
        /// <param name="characterCountChangeFrom"></param>
        /// <param name="characterCountChangeTo"></param>
        /// <param name="contentType"></param>
        /// <param name="state"></param>
        /// <param name="settings"></param>
        /// <param name="feedback"></param>
        /// <param name="shareLinkId"></param>
        /// <param name="source"></param>
        /// <param name="alignments"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SpeechHistoryItemResponseModel(
            string historyItemId,
            string requestId,
            string voiceId,
            string modelId,
            string voiceName,
            global::G.SpeechHistoryItemResponseModelVoiceCategory voiceCategory,
            string text,
            int dateUnix,
            int characterCountChangeFrom,
            int characterCountChangeTo,
            string contentType,
            global::G.SpeechHistoryItemResponseModelState state,
            object settings,
            global::G.FeedbackResponseModel feedback,
            string shareLinkId,
            global::G.SpeechHistoryItemResponseModelSource source,
            global::G.HistoryAlignmentsResponseModel? alignments)
        {
            this.HistoryItemId = historyItemId ?? throw new global::System.ArgumentNullException(nameof(historyItemId));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
            this.VoiceCategory = voiceCategory;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.DateUnix = dateUnix;
            this.CharacterCountChangeFrom = characterCountChangeFrom;
            this.CharacterCountChangeTo = characterCountChangeTo;
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.State = state;
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
            this.ShareLinkId = shareLinkId ?? throw new global::System.ArgumentNullException(nameof(shareLinkId));
            this.Source = source;
            this.Alignments = alignments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechHistoryItemResponseModel" /> class.
        /// </summary>
        public SpeechHistoryItemResponseModel()
        {
        }
    }
}