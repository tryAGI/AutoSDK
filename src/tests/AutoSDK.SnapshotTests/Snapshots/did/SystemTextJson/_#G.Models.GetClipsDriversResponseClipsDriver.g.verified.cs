//HintName: G.Models.GetClipsDriversResponseClipsDriver.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClipsDriversResponseClipsDriver
    {
        /// <summary>
        /// Example: jack-Pt27VkP3hW
        /// </summary>
        /// <example>jack-Pt27VkP3hW</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresenterId { get; set; }

        /// <summary>
        /// Example: Vcq0R4a8F0
        /// </summary>
        /// <example>Vcq0R4a8F0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverId { get; set; }

        /// <summary>
        /// The gender of the presenter.<br/>
        /// male / female / other
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gender { get; set; }

        /// <summary>
        /// Creation time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The owner id of the driver
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Last modified time as iso-8601 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedAt { get; set; }

        /// <summary>
        /// The video width in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Width { get; set; }

        /// <summary>
        /// The video height in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Height { get; set; }

        /// <summary>
        /// High resolution image of the driver image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverImageUrl { get; set; }

        /// <summary>
        /// A low resolution image representing the presenter in the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThumbnailUrl { get; set; }

        /// <summary>
        /// A short video, trimmed from the original driver in high resolution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUrl { get; set; }

        /// <summary>
        /// A short gif, trimmed from the original driver in low resolution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewUrl { get; set; }

        /// <summary>
        /// A cdn url to the talking preview url of the driver
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("talking_preview_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TalkingPreviewUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chroma_key_similarity")]
        public double? ChromaKeySimilarity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chroma_key_blend")]
        public double? ChromaKeyBlend { get; set; }

        /// <summary>
        /// A user friendly name for the driver<br/>
        /// Example: Amy
        /// </summary>
        /// <example>Amy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates if the driver is a support transparent background
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_greenscreen")]
        public bool? IsGreenscreen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsDriversResponseClipsDriver" /> class.
        /// </summary>
        /// <param name="presenterId">
        /// Example: jack-Pt27VkP3hW
        /// </param>
        /// <param name="driverId">
        /// Example: Vcq0R4a8F0
        /// </param>
        /// <param name="gender">
        /// The gender of the presenter.<br/>
        /// male / female / other
        /// </param>
        /// <param name="createdAt">
        /// Creation time as iso-8601 string
        /// </param>
        /// <param name="ownerId">
        /// The owner id of the driver
        /// </param>
        /// <param name="modifiedAt">
        /// Last modified time as iso-8601 string
        /// </param>
        /// <param name="width">
        /// The video width in pixels
        /// </param>
        /// <param name="height">
        /// The video height in pixels
        /// </param>
        /// <param name="driverImageUrl">
        /// High resolution image of the driver image
        /// </param>
        /// <param name="thumbnailUrl">
        /// A low resolution image representing the presenter in the video
        /// </param>
        /// <param name="videoUrl">
        /// A short video, trimmed from the original driver in high resolution
        /// </param>
        /// <param name="previewUrl">
        /// A short gif, trimmed from the original driver in low resolution
        /// </param>
        /// <param name="talkingPreviewUrl">
        /// A cdn url to the talking preview url of the driver
        /// </param>
        /// <param name="chromaKeySimilarity"></param>
        /// <param name="chromaKeyBlend"></param>
        /// <param name="name">
        /// A user friendly name for the driver<br/>
        /// Example: Amy
        /// </param>
        /// <param name="isGreenscreen">
        /// Indicates if the driver is a support transparent background
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetClipsDriversResponseClipsDriver(
            string presenterId,
            string driverId,
            string gender,
            string createdAt,
            string ownerId,
            string modifiedAt,
            double width,
            double height,
            string driverImageUrl,
            string thumbnailUrl,
            string videoUrl,
            string previewUrl,
            string talkingPreviewUrl,
            double? chromaKeySimilarity,
            double? chromaKeyBlend,
            string? name,
            bool? isGreenscreen)
        {
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.DriverId = driverId ?? throw new global::System.ArgumentNullException(nameof(driverId));
            this.Gender = gender ?? throw new global::System.ArgumentNullException(nameof(gender));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.Width = width;
            this.Height = height;
            this.DriverImageUrl = driverImageUrl ?? throw new global::System.ArgumentNullException(nameof(driverImageUrl));
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
            this.PreviewUrl = previewUrl ?? throw new global::System.ArgumentNullException(nameof(previewUrl));
            this.TalkingPreviewUrl = talkingPreviewUrl ?? throw new global::System.ArgumentNullException(nameof(talkingPreviewUrl));
            this.ChromaKeySimilarity = chromaKeySimilarity;
            this.ChromaKeyBlend = chromaKeyBlend;
            this.Name = name;
            this.IsGreenscreen = isGreenscreen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsDriversResponseClipsDriver" /> class.
        /// </summary>
        public GetClipsDriversResponseClipsDriver()
        {
        }
    }
}