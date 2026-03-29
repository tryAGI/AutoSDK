//HintName: G.Models.ClipPresenterDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClipPresenterDto
    {
        /// <summary>
        /// Example: jack-Pt27VkP3hW
        /// </summary>
        /// <example>jack-Pt27VkP3hW</example>
        [global::Newtonsoft.Json.JsonProperty("presenter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PresenterId { get; set; } = default!;

        /// <summary>
        /// Example: Amy
        /// </summary>
        /// <example>Amy</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: Vcq0R4a8F0
        /// </summary>
        /// <example>Vcq0R4a8F0</example>
        [global::Newtonsoft.Json.JsonProperty("driver_id")]
        public string? DriverId { get; set; }

        /// <summary>
        /// The gender of the presenter.<br/>
        /// male / female / other
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender", Required = global::Newtonsoft.Json.Required.Always)]
        public string Gender { get; set; } = default!;

        /// <summary>
        /// The owner id of the driver
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// A short gif, trimmed from the original driver in low resolution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviewUrl { get; set; } = default!;

        /// <summary>
        /// A short clip which is an example of a video that could be generated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("talking_preview_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TalkingPreviewUrl { get; set; } = default!;

        /// <summary>
        /// Presenter modified at
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModifiedAt { get; set; } = default!;

        /// <summary>
        /// A short video, trimmed from the original driver in high resolution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.ClipPresenterDtoVoiceMicrosoft, global::G.ClipPresenterDtoVoiceElevenLabs, global::G.ClipPresenterDtoVoiceAmazon, global::G.ClipPresenterDtoVoiceGoogle, global::G.ClipPresenterDtoVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Whether or not the presenter is streamable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_streamable")]
        public bool? IsStreamable { get; set; }

        /// <summary>
        /// Indicates if the presenter supports transparent background
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_greenscreen")]
        public bool? IsGreenscreen { get; set; }

        /// <summary>
        /// The status of the presenter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ClipPresenterDtoStatus? Status { get; set; }

        /// <summary>
        /// The face rect of the presenter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("face_rect")]
        public global::G.ClipPresenterDtoFaceRect? FaceRect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipPresenterDto" /> class.
        /// </summary>
        /// <param name="presenterId">
        /// Example: jack-Pt27VkP3hW
        /// </param>
        /// <param name="gender">
        /// The gender of the presenter.<br/>
        /// male / female / other
        /// </param>
        /// <param name="ownerId">
        /// The owner id of the driver
        /// </param>
        /// <param name="previewUrl">
        /// A short gif, trimmed from the original driver in low resolution
        /// </param>
        /// <param name="talkingPreviewUrl">
        /// A short clip which is an example of a video that could be generated
        /// </param>
        /// <param name="modifiedAt">
        /// Presenter modified at
        /// </param>
        /// <param name="name">
        /// Example: Amy
        /// </param>
        /// <param name="driverId">
        /// Example: Vcq0R4a8F0
        /// </param>
        /// <param name="videoUrl">
        /// A short video, trimmed from the original driver in high resolution
        /// </param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="imageUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="voice"></param>
        /// <param name="isStreamable">
        /// Whether or not the presenter is streamable
        /// </param>
        /// <param name="isGreenscreen">
        /// Indicates if the presenter supports transparent background
        /// </param>
        /// <param name="status">
        /// The status of the presenter
        /// </param>
        /// <param name="faceRect">
        /// The face rect of the presenter
        /// </param>
        public ClipPresenterDto(
            string presenterId,
            string gender,
            string ownerId,
            string previewUrl,
            string talkingPreviewUrl,
            string modifiedAt,
            string? name,
            string? driverId,
            string? videoUrl,
            string? thumbnailUrl,
            string? imageUrl,
            string? createdAt,
            global::G.AnyOf<global::G.ClipPresenterDtoVoiceMicrosoft, global::G.ClipPresenterDtoVoiceElevenLabs, global::G.ClipPresenterDtoVoiceAmazon, global::G.ClipPresenterDtoVoiceGoogle, global::G.ClipPresenterDtoVoiceOpenAI>? voice,
            bool? isStreamable,
            bool? isGreenscreen,
            global::G.ClipPresenterDtoStatus? status,
            global::G.ClipPresenterDtoFaceRect? faceRect)
        {
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Name = name;
            this.DriverId = driverId;
            this.Gender = gender ?? throw new global::System.ArgumentNullException(nameof(gender));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.PreviewUrl = previewUrl ?? throw new global::System.ArgumentNullException(nameof(previewUrl));
            this.TalkingPreviewUrl = talkingPreviewUrl ?? throw new global::System.ArgumentNullException(nameof(talkingPreviewUrl));
            this.ModifiedAt = modifiedAt ?? throw new global::System.ArgumentNullException(nameof(modifiedAt));
            this.VideoUrl = videoUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.ImageUrl = imageUrl;
            this.CreatedAt = createdAt;
            this.Voice = voice;
            this.IsStreamable = isStreamable;
            this.IsGreenscreen = isGreenscreen;
            this.Status = status;
            this.FaceRect = faceRect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipPresenterDto" /> class.
        /// </summary>
        public ClipPresenterDto()
        {
        }
    }
}