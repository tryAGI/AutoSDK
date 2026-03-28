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
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

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
        public string? SignedUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_preview_url")]
        public string? SignedPreviewUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_gain_db")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VolumeGainDb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("muted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Muted { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Codec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Order { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_interval_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ThumbnailIntervalSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> ThumbnailSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_sheets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ProjectVideoThumbnailSheetResponseModel> ThumbnailSheets { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_preview_signed_url")]
        public string? AssetPreviewSignedUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_video_id")]
        public string? SourceVideoId { get; set; }

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
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_track_ready")]
        public bool? AudioTrackReady { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_format_ready")]
        public bool? ExportFormatReady { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_snapshot_id")]
        public string? CurrentSnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_context")]
        public global::G.GenerationSourceContext? SourceContext { get; set; }

        /// <summary>
        /// Default Value: video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Defines asset positioning and transformation on canvas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canvas_placement")]
        public global::G.CanvasPlacement? CanvasPlacement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animation")]
        public global::G.ClipAnimation? Animation { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playback_speed")]
        public double? PlaybackSpeed { get; set; }

        /// <summary>
        /// Default Value: v0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        public string? TrackId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_job_progress")]
        public double PreviewJobProgress { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ProjectVideoResponseModel" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="filename"></param>
        /// <param name="offsetMs"></param>
        /// <param name="durationMs"></param>
        /// <param name="volumeGainDb"></param>
        /// <param name="muted"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="codec"></param>
        /// <param name="order"></param>
        /// <param name="createdAtMs"></param>
        /// <param name="updatedAtMs"></param>
        /// <param name="thumbnailIntervalSeconds"></param>
        /// <param name="thumbnailSize"></param>
        /// <param name="thumbnailSheets"></param>
        /// <param name="startTimeMs"></param>
        /// <param name="endTimeMs"></param>
        /// <param name="pendingBlockIds"></param>
        /// <param name="pendingExternalAudioIds"></param>
        /// <param name="signedUrl"></param>
        /// <param name="signedPreviewUrl"></param>
        /// <param name="fadeInMs">
        /// Default Value: 0
        /// </param>
        /// <param name="fadeOutMs">
        /// Default Value: 0
        /// </param>
        /// <param name="error"></param>
        /// <param name="assetPreviewSignedUrl"></param>
        /// <param name="sourceVideoId"></param>
        /// <param name="sourceAssetId"></param>
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
        /// <param name="importSpeechProgress">
        /// Included only in responses
        /// </param>
        /// <param name="previewJobProgress">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
            this.SignedUrl = signedUrl;
            this.SignedPreviewUrl = signedPreviewUrl;
            this.OffsetMs = offsetMs;
            this.DurationMs = durationMs;
            this.VolumeGainDb = volumeGainDb;
            this.Muted = muted;
            this.FadeInMs = fadeInMs;
            this.FadeOutMs = fadeOutMs;
            this.Width = width;
            this.Height = height;
            this.Codec = codec ?? throw new global::System.ArgumentNullException(nameof(codec));
            this.Order = order ?? throw new global::System.ArgumentNullException(nameof(order));
            this.CreatedAtMs = createdAtMs;
            this.UpdatedAtMs = updatedAtMs;
            this.Error = error;
            this.ThumbnailIntervalSeconds = thumbnailIntervalSeconds;
            this.ThumbnailSize = thumbnailSize ?? throw new global::System.ArgumentNullException(nameof(thumbnailSize));
            this.ThumbnailSheets = thumbnailSheets ?? throw new global::System.ArgumentNullException(nameof(thumbnailSheets));
            this.StartTimeMs = startTimeMs;
            this.EndTimeMs = endTimeMs;
            this.AssetPreviewSignedUrl = assetPreviewSignedUrl;
            this.SourceVideoId = sourceVideoId;
            this.SourceAssetId = sourceAssetId;
            this.PendingBlockIds = pendingBlockIds ?? throw new global::System.ArgumentNullException(nameof(pendingBlockIds));
            this.PendingExternalAudioIds = pendingExternalAudioIds ?? throw new global::System.ArgumentNullException(nameof(pendingExternalAudioIds));
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