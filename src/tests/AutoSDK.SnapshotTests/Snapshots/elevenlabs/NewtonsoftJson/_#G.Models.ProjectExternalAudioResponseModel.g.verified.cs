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
        [global::Newtonsoft.Json.JsonProperty("external_audio_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalAudioId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signed_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SignedUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int OffsetMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int DurationMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartTimeMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndTimeMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order", Required = global::Newtonsoft.Json.Required.Always)]
        public string Order { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("track_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrackId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int UpdatedAtMs { get; set; } = default!;

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume_gain_db")]
        public double? VolumeGainDb { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("muted")]
        public bool? Muted { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fade_in_ms")]
        public int? FadeInMs { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fade_out_ms")]
        public int? FadeOutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_external_audio_id")]
        public string? SourceExternalAudioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_asset_id")]
        public string? SourceAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_block_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> PendingBlockIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_external_audio_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> PendingExternalAudioIds { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speech_imported")]
        public bool? SpeechImported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_task")]
        public global::G.PendingClipTask? PendingTask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_snapshot_id")]
        public string? CurrentSnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_context")]
        public global::G.SourceContextVariant1? SourceContext { get; set; }

        /// <summary>
        /// Default Value: audio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("import_speech_progress")]
        public double? ImportSpeechProgress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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