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
        [global::Newtonsoft.Json.JsonProperty("history_item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string HistoryItemId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_category", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpeechHistoryItemResponseModelVoiceCategory VoiceCategory { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int DateUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_count_change_from", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharacterCountChangeFrom { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_count_change_to", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharacterCountChangeTo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpeechHistoryItemResponseModelState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings", Required = global::Newtonsoft.Json.Required.Always)]
        public object Settings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FeedbackResponseModel Feedback { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("share_link_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ShareLinkId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpeechHistoryItemResponseModelSource Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alignments")]
        public global::G.HistoryAlignmentsResponseModel? Alignments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.SpeechHistoryItemResponseModel? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SpeechHistoryItemResponseModel>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.SpeechHistoryItemResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.SpeechHistoryItemResponseModel?>(serializer.Deserialize<global::G.SpeechHistoryItemResponseModel>(jsonReader));
        }

    }
}