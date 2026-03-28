//HintName: G.Models.ProjectExternalAudioResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectExternalAudioResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_audio_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalAudioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OffsetMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrackId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAtMs { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_gain_db")]
        public double? VolumeGainDb { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("muted")]
        public bool? Muted { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fade_in_ms")]
        public int? FadeInMs { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fade_out_ms")]
        public int? FadeOutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_external_audio_id")]
        public string? SourceExternalAudioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_asset_id")]
        public string? SourceAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_block_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PendingBlockIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_external_audio_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PendingExternalAudioIds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_imported")]
        public bool? SpeechImported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_task")]
        public global::G.PendingClipTask? PendingTask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_snapshot_id")]
        public string? CurrentSnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_context")]
        public global::G.SourceContextVariant1? SourceContext { get; set; }

        /// <summary>
        /// Default Value: audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_speech_progress")]
        public double? ImportSpeechProgress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExternalAudioResponseModel" /> class.
        /// </summary>
        /// <param name="externalAudioId"></param>
        /// <param name="filename"></param>
        /// <param name="signedUrl"></param>
        /// <param name="offsetMs"></param>
        /// <param name="durationMs"></param>
        /// <param name="startTimeMs"></param>
        /// <param name="endTimeMs"></param>
        /// <param name="order"></param>
        /// <param name="trackId"></param>
        /// <param name="createdAtMs"></param>
        /// <param name="updatedAtMs"></param>
        /// <param name="pendingBlockIds"></param>
        /// <param name="pendingExternalAudioIds"></param>
        /// <param name="volumeGainDb">
        /// Default Value: 0F
        /// </param>
        /// <param name="muted">
        /// Default Value: false
        /// </param>
        /// <param name="fadeInMs">
        /// Default Value: 0
        /// </param>
        /// <param name="fadeOutMs">
        /// Default Value: 0
        /// </param>
        /// <param name="sourceExternalAudioId"></param>
        /// <param name="sourceAssetId"></param>
        /// <param name="speechImported">
        /// Default Value: false
        /// </param>
        /// <param name="pendingTask"></param>
        /// <param name="currentSnapshotId"></param>
        /// <param name="sourceContext"></param>
        /// <param name="type">
        /// Default Value: audio
        /// </param>
        /// <param name="importSpeechProgress">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectExternalAudioResponseModel(
            string externalAudioId,
            string filename,
            string signedUrl,
            int offsetMs,
            int durationMs,
            int startTimeMs,
            int endTimeMs,
            string order,
            string trackId,
            int createdAtMs,
            int updatedAtMs,
            global::System.Collections.Generic.IList<string> pendingBlockIds,
            global::System.Collections.Generic.IList<string> pendingExternalAudioIds,
            double? volumeGainDb,
            bool? muted,
            int? fadeInMs,
            int? fadeOutMs,
            string? sourceExternalAudioId,
            string? sourceAssetId,
            bool? speechImported,
            global::G.PendingClipTask? pendingTask,
            string? currentSnapshotId,
            global::G.SourceContextVariant1? sourceContext,
            string? type,
            double? importSpeechProgress)
        {
            this.ExternalAudioId = externalAudioId ?? throw new global::System.ArgumentNullException(nameof(externalAudioId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
            this.OffsetMs = offsetMs;
            this.DurationMs = durationMs;
            this.StartTimeMs = startTimeMs;
            this.EndTimeMs = endTimeMs;
            this.Order = order ?? throw new global::System.ArgumentNullException(nameof(order));
            this.TrackId = trackId ?? throw new global::System.ArgumentNullException(nameof(trackId));
            this.CreatedAtMs = createdAtMs;
            this.UpdatedAtMs = updatedAtMs;
            this.VolumeGainDb = volumeGainDb;
            this.Muted = muted;
            this.FadeInMs = fadeInMs;
            this.FadeOutMs = fadeOutMs;
            this.SourceExternalAudioId = sourceExternalAudioId;
            this.SourceAssetId = sourceAssetId;
            this.PendingBlockIds = pendingBlockIds ?? throw new global::System.ArgumentNullException(nameof(pendingBlockIds));
            this.PendingExternalAudioIds = pendingExternalAudioIds ?? throw new global::System.ArgumentNullException(nameof(pendingExternalAudioIds));
            this.SpeechImported = speechImported;
            this.PendingTask = pendingTask;
            this.CurrentSnapshotId = currentSnapshotId;
            this.SourceContext = sourceContext;
            this.Type = type;
            this.ImportSpeechProgress = importSpeechProgress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExternalAudioResponseModel" /> class.
        /// </summary>
        public ProjectExternalAudioResponseModel()
        {
        }
    }
}