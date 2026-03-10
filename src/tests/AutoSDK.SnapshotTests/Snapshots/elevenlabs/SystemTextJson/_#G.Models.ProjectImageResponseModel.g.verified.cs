//HintName: G.Models.ProjectImageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectImageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_signed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThumbnailSignedUrl { get; set; }

        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FileSizeBytes { get; set; }

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
        /// Default Value: v0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        public string? TrackId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Order { get; set; }

        /// <summary>
        /// Defines asset positioning and transformation on canvas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canvas_placement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CanvasPlacement CanvasPlacement { get; set; }

        /// <summary>
        /// Default Value: {"enter_effect":"none","enter_duration_ms":0,"exit_effect":"none","exit_duration_ms":0}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animation")]
        public global::G.ClipAnimation? Animation { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("current_snapshot_id")]
        public string? CurrentSnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_asset_id")]
        public string? SourceAssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectImageResponseModel" /> class.
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="filename"></param>
        /// <param name="signedUrl"></param>
        /// <param name="thumbnailSignedUrl"></param>
        /// <param name="type">
        /// Default Value: image
        /// </param>
        /// <param name="source">
        /// Default Value: upload
        /// </param>
        /// <param name="fileSizeBytes"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="trackId">
        /// Default Value: v0
        /// </param>
        /// <param name="offsetMs"></param>
        /// <param name="durationMs"></param>
        /// <param name="order"></param>
        /// <param name="canvasPlacement">
        /// Defines asset positioning and transformation on canvas.
        /// </param>
        /// <param name="animation">
        /// Default Value: {"enter_effect":"none","enter_duration_ms":0,"exit_effect":"none","exit_duration_ms":0}
        /// </param>
        /// <param name="createdAtMs"></param>
        /// <param name="updatedAtMs"></param>
        /// <param name="currentSnapshotId"></param>
        /// <param name="sourceAssetId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectImageResponseModel(
            string imageId,
            string filename,
            string signedUrl,
            string thumbnailSignedUrl,
            int fileSizeBytes,
            int width,
            int height,
            int offsetMs,
            int durationMs,
            string order,
            global::G.CanvasPlacement canvasPlacement,
            int createdAtMs,
            int updatedAtMs,
            string? type,
            string? source,
            string? trackId,
            global::G.ClipAnimation? animation,
            string? currentSnapshotId,
            string? sourceAssetId)
        {
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
            this.ThumbnailSignedUrl = thumbnailSignedUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailSignedUrl));
            this.FileSizeBytes = fileSizeBytes;
            this.Width = width;
            this.Height = height;
            this.OffsetMs = offsetMs;
            this.DurationMs = durationMs;
            this.Order = order ?? throw new global::System.ArgumentNullException(nameof(order));
            this.CanvasPlacement = canvasPlacement ?? throw new global::System.ArgumentNullException(nameof(canvasPlacement));
            this.CreatedAtMs = createdAtMs;
            this.UpdatedAtMs = updatedAtMs;
            this.Type = type;
            this.Source = source;
            this.TrackId = trackId;
            this.Animation = animation;
            this.CurrentSnapshotId = currentSnapshotId;
            this.SourceAssetId = sourceAssetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectImageResponseModel" /> class.
        /// </summary>
        public ProjectImageResponseModel()
        {
        }
    }
}