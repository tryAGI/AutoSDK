//HintName: G.Models.GetPresenterDriversByIdResponseClipsDriver.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPresenterDriversByIdResponseClipsDriver
    {
        /// <summary>
        /// Example: jack-Pt27VkP3hW
        /// </summary>
        /// <example>jack-Pt27VkP3hW</example>
        [global::Newtonsoft.Json.JsonProperty("presenter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PresenterId { get; set; } = default!;

        /// <summary>
        /// Example: Vcq0R4a8F0
        /// </summary>
        /// <example>Vcq0R4a8F0</example>
        [global::Newtonsoft.Json.JsonProperty("driver_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DriverId { get; set; } = default!;

        /// <summary>
        /// The gender of the presenter.<br/>
        /// male / female / other
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender", Required = global::Newtonsoft.Json.Required.Always)]
        public string Gender { get; set; } = default!;

        /// <summary>
        /// Creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The owner id of the driver
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// Last modified time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// The video width in pixels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public double Width { get; set; } = default!;

        /// <summary>
        /// The video height in pixels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public double Height { get; set; } = default!;

        /// <summary>
        /// High resolution image of the driver image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("driver_image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DriverImageUrl { get; set; } = default!;

        /// <summary>
        /// A low resolution image representing the presenter in the video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// A short video, trimmed from the original driver in high resolution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string VideoUrl { get; set; } = default!;

        /// <summary>
        /// A short gif, trimmed from the original driver in low resolution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviewUrl { get; set; } = default!;

        /// <summary>
        /// A cdn url to the talking preview url of the driver
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("talking_preview_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TalkingPreviewUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chroma_key_similarity")]
        public double? ChromaKeySimilarity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chroma_key_blend")]
        public double? ChromaKeyBlend { get; set; }

        /// <summary>
        /// A user friendly name for the driver<br/>
        /// Example: Amy
        /// </summary>
        /// <example>Amy</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates if the driver is a support transparent background
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_greenscreen")]
        public bool? IsGreenscreen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresenterDriversByIdResponseClipsDriver" /> class.
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
        public GetPresenterDriversByIdResponseClipsDriver(
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
        /// Initializes a new instance of the <see cref="GetPresenterDriversByIdResponseClipsDriver" /> class.
        /// </summary>
        public GetPresenterDriversByIdResponseClipsDriver()
        {
        }
    }
}