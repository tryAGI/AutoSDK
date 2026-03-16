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
        [global::Newtonsoft.Json.JsonProperty("image_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageId { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("thumbnail_signed_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThumbnailSignedUrl { get; set; } = default!;

        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long FileSizeBytes { get; set; } = default!;

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
        /// Default Value: v0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("track_id")]
        public string? TrackId { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("order", Required = global::Newtonsoft.Json.Required.Always)]
        public string Order { get; set; } = default!;

        /// <summary>
        /// Defines asset positioning and transformation on canvas.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canvas_placement", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CanvasPlacement CanvasPlacement { get; set; } = default!;

        /// <summary>
        /// Default Value: {"enter_effect":"none","enter_duration_ms":0,"exit_effect":"none","exit_duration_ms":0}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animation")]
        public global::G.ClipAnimation? Animation { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("current_snapshot_id")]
        public string? CurrentSnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_asset_id")]
        public string? SourceAssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public ProjectImageResponseModel(
            string imageId,
            string filename,
            string signedUrl,
            string thumbnailSignedUrl,
            long fileSizeBytes,
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