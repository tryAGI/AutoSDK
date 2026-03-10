//HintName: G.Models.ProjectVideoResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectVideoResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VideoId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signed_url")]
        public string? SignedUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signed_preview_url")]
        public string? SignedPreviewUrl { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("volume_gain_db", Required = global::Newtonsoft.Json.Required.Always)]
        public double VolumeGainDb { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("muted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Muted { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public int Width { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public int Height { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("codec", Required = global::Newtonsoft.Json.Required.Always)]
        public string Codec { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order", Required = global::Newtonsoft.Json.Required.Always)]
        public string Order { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_interval_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double ThumbnailIntervalSeconds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_size", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> ThumbnailSize { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_sheets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProjectVideoThumbnailSheetResponseModel> ThumbnailSheets { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("asset_preview_signed_url")]
        public string? AssetPreviewSignedUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_video_id")]
        public string? SourceVideoId { get; set; }

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
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_track_ready")]
        public bool? AudioTrackReady { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_format_ready")]
        public bool? ExportFormatReady { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_snapshot_id")]
        public string? CurrentSnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_context")]
        public global::G.GenerationSourceContext? SourceContext { get; set; }

        /// <summary>
        /// Default Value: video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Defines asset positioning and transformation on canvas.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canvas_placement")]
        public global::G.CanvasPlacement? CanvasPlacement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animation")]
        public global::G.ClipAnimation? Animation { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("playback_speed")]
        public double? PlaybackSpeed { get; set; }

        /// <summary>
        /// Default Value: v0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("track_id")]
        public string? TrackId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("preview_job_progress")]
        public double PreviewJobProgress { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ProjectVideoResponseModel" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="filename"></param>
        /// <param name="signedUrl"></param>
        /// <param name="signedPreviewUrl"></param>
        /// <param name="offsetMs"></param>
        /// <param name="durationMs"></param>
        /// <param name="volumeGainDb"></param>
        /// <param name="muted"></param>
        /// <param name="fadeInMs">
        /// Default Value: 0
        /// </param>
        /// <param name="fadeOutMs">
        /// Default Value: 0
        /// </param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="codec"></param>
        /// <param name="order"></param>
        /// <param name="createdAtMs"></param>
        /// <param name="updatedAtMs"></param>
        /// <param name="error"></param>
        /// <param name="thumbnailIntervalSeconds"></param>
        /// <param name="thumbnailSize"></param>
        /// <param name="thumbnailSheets"></param>
        /// <param name="startTimeMs"></param>
        /// <param name="endTimeMs"></param>
        /// <param name="assetPreviewSignedUrl"></param>
        /// <param name="sourceVideoId"></param>
        /// <param name="sourceAssetId"></param>
        /// <param name="pendingBlockIds"></param>
        /// <param name="pendingExternalAudioIds"></param>
        /// <param name="speechImported">
        /// Default Value: false
        /// </param>
        /// <param name="pendingTask"></param>
        /// <param name="audioTrackReady">
        /// Default Value: true
        /// </param>
        /// <param name="exportFormatReady">
        /// Default Value: true
        /// </param>
        /// <param name="currentSnapshotId"></param>
        /// <param name="sourceContext"></param>
        /// <param name="type">
        /// Default Value: video
        /// </param>
        /// <param name="canvasPlacement">
        /// Defines asset positioning and transformation on canvas.
        /// </param>
        /// <param name="animation"></param>
        /// <param name="playbackSpeed">
        /// Default Value: 1F
        /// </param>
        /// <param name="trackId">
        /// Default Value: v0
        /// </param>
        /// <param name="previewJobProgress">
        /// Included only in responses
        /// </param>
        /// <param name="importSpeechProgress">
        /// Included only in responses
        /// </param>
        public ProjectVideoResponseModel(
            string videoId,
            string filename,
            int offsetMs,
            int durationMs,
            double volumeGainDb,
            bool muted,
            int width,
            int height,
            string codec,
            string order,
            int createdAtMs,
            int updatedAtMs,
            double thumbnailIntervalSeconds,
            global::System.Collections.Generic.IList<int> thumbnailSize,
            global::System.Collections.Generic.IList<global::G.ProjectVideoThumbnailSheetResponseModel> thumbnailSheets,
            int startTimeMs,
            int endTimeMs,
            global::System.Collections.Generic.IList<string> pendingBlockIds,
            global::System.Collections.Generic.IList<string> pendingExternalAudioIds,
            string? signedUrl,
            string? signedPreviewUrl,
            int? fadeInMs,
            int? fadeOutMs,
            string? error,
            string? assetPreviewSignedUrl,
            string? sourceVideoId,
            string? sourceAssetId,
            bool? speechImported,
            global::G.PendingClipTask? pendingTask,
            bool? audioTrackReady,
            bool? exportFormatReady,
            string? currentSnapshotId,
            global::G.GenerationSourceContext? sourceContext,
            string? type,
            global::G.CanvasPlacement? canvasPlacement,
            global::G.ClipAnimation? animation,
            double? playbackSpeed,
            string? trackId,
            double? importSpeechProgress,
            double previewJobProgress = default!)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.OffsetMs = offsetMs;
            this.DurationMs = durationMs;
            this.VolumeGainDb = volumeGainDb;
            this.Muted = muted;
            this.Width = width;
            this.Height = height;
            this.Codec = codec ?? throw new global::System.ArgumentNullException(nameof(codec));
            this.Order = order ?? throw new global::System.ArgumentNullException(nameof(order));
            this.CreatedAtMs = createdAtMs;
            this.UpdatedAtMs = updatedAtMs;
            this.ThumbnailIntervalSeconds = thumbnailIntervalSeconds;
            this.ThumbnailSize = thumbnailSize ?? throw new global::System.ArgumentNullException(nameof(thumbnailSize));
            this.ThumbnailSheets = thumbnailSheets ?? throw new global::System.ArgumentNullException(nameof(thumbnailSheets));
            this.StartTimeMs = startTimeMs;
            this.EndTimeMs = endTimeMs;
            this.PendingBlockIds = pendingBlockIds ?? throw new global::System.ArgumentNullException(nameof(pendingBlockIds));
            this.PendingExternalAudioIds = pendingExternalAudioIds ?? throw new global::System.ArgumentNullException(nameof(pendingExternalAudioIds));
            this.SignedUrl = signedUrl;
            this.SignedPreviewUrl = signedPreviewUrl;
            this.FadeInMs = fadeInMs;
            this.FadeOutMs = fadeOutMs;
            this.Error = error;
            this.AssetPreviewSignedUrl = assetPreviewSignedUrl;
            this.SourceVideoId = sourceVideoId;
            this.SourceAssetId = sourceAssetId;
            this.SpeechImported = speechImported;
            this.PendingTask = pendingTask;
            this.AudioTrackReady = audioTrackReady;
            this.ExportFormatReady = exportFormatReady;
            this.CurrentSnapshotId = currentSnapshotId;
            this.SourceContext = sourceContext;
            this.Type = type;
            this.CanvasPlacement = canvasPlacement;
            this.Animation = animation;
            this.PlaybackSpeed = playbackSpeed;
            this.TrackId = trackId;
            this.PreviewJobProgress = previewJobProgress;
            this.ImportSpeechProgress = importSpeechProgress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVideoResponseModel" /> class.
        /// </summary>
        public ProjectVideoResponseModel()
        {
        }
    }
}