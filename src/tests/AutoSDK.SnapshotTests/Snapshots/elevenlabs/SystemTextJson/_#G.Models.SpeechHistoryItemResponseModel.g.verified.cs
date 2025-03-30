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
        /// The ID of the history item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HistoryItemId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The ID of the voice used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// The ID of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceName { get; set; }

        /// <summary>
        /// The category of the voice. Either 'premade', 'cloned', 'generated' or 'professional'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechHistoryItemResponseModelVoiceCategoryJsonConverter))]
        public global::G.SpeechHistoryItemResponseModelVoiceCategory? VoiceCategory { get; set; }

        /// <summary>
        /// The text used to generate the audio item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Unix timestamp of when the item was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset DateUnix { get; set; }

        /// <summary>
        /// The character count change from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count_change_from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharacterCountChangeFrom { get; set; }

        /// <summary>
        /// The character count change to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count_change_to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharacterCountChangeTo { get; set; }

        /// <summary>
        /// The content type of the generated item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The state of the history item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechHistoryItemResponseModelStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpeechHistoryItemResponseModelState State { get; set; }

        /// <summary>
        /// The settings of the history item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::G.FeedbackResponseModel? Feedback { get; set; }

        /// <summary>
        /// The ID of the share link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_link_id")]
        public string? ShareLinkId { get; set; }

        /// <summary>
        /// The source of the history item. Either TTS (text to speech), STS (speech to text) or STT (speech to text).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechHistoryItemResponseModelSourceJsonConverter))]
        public global::G.SpeechHistoryItemResponseModelSource? Source { get; set; }

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
        /// <param name="historyItemId">
        /// The ID of the history item.
        /// </param>
        /// <param name="requestId">
        /// The ID of the request.
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice used.
        /// </param>
        /// <param name="modelId">
        /// The ID of the model.
        /// </param>
        /// <param name="voiceName">
        /// The name of the voice.
        /// </param>
        /// <param name="voiceCategory">
        /// The category of the voice. Either 'premade', 'cloned', 'generated' or 'professional'.
        /// </param>
        /// <param name="text">
        /// The text used to generate the audio item.
        /// </param>
        /// <param name="dateUnix">
        /// Unix timestamp of when the item was created.
        /// </param>
        /// <param name="characterCountChangeFrom">
        /// The character count change from.
        /// </param>
        /// <param name="characterCountChangeTo">
        /// The character count change to.
        /// </param>
        /// <param name="contentType">
        /// The content type of the generated item.
        /// </param>
        /// <param name="state">
        /// The state of the history item.
        /// </param>
        /// <param name="settings">
        /// The settings of the history item.
        /// </param>
        /// <param name="feedback"></param>
        /// <param name="shareLinkId">
        /// The ID of the share link.
        /// </param>
        /// <param name="source">
        /// The source of the history item. Either TTS (text to speech), STS (speech to text) or STT (speech to text).
        /// </param>
        /// <param name="alignments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechHistoryItemResponseModel(
            string historyItemId,
            string voiceId,
            string voiceName,
            string text,
            global::System.DateTimeOffset dateUnix,
            int characterCountChangeFrom,
            int characterCountChangeTo,
            string contentType,
            global::G.SpeechHistoryItemResponseModelState state,
            string? requestId,
            string? modelId,
            global::G.SpeechHistoryItemResponseModelVoiceCategory? voiceCategory,
            object? settings,
            global::G.FeedbackResponseModel? feedback,
            string? shareLinkId,
            global::G.SpeechHistoryItemResponseModelSource? source,
            global::G.HistoryAlignmentsResponseModel? alignments)
        {
            this.HistoryItemId = historyItemId ?? throw new global::System.ArgumentNullException(nameof(historyItemId));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.DateUnix = dateUnix;
            this.CharacterCountChangeFrom = characterCountChangeFrom;
            this.CharacterCountChangeTo = characterCountChangeTo;
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.State = state;
            this.RequestId = requestId;
            this.ModelId = modelId;
            this.VoiceCategory = voiceCategory;
            this.Settings = settings;
            this.Feedback = feedback;
            this.ShareLinkId = shareLinkId;
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