//HintName: G.Models.GetPresentersResponsePresenter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPresentersResponsePresenter
    {
        /// <summary>
        /// Example: jack-Pt27VkP3hW
        /// </summary>
        /// <example>jack-Pt27VkP3hW</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresenterId { get; set; }

        /// <summary>
        /// Example: Amy
        /// </summary>
        /// <example>Amy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: Vcq0R4a8F0
        /// </summary>
        /// <example>Vcq0R4a8F0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_id")]
        public string? DriverId { get; set; }

        /// <summary>
        /// The gender of the presenter.<br/>
        /// male / female / other
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gender { get; set; }

        /// <summary>
        /// The owner id of the driver
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// A short gif, trimmed from the original driver in low resolution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewUrl { get; set; }

        /// <summary>
        /// A short clip which is an example of a video that could be generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("talking_preview_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TalkingPreviewUrl { get; set; }

        /// <summary>
        /// Presenter modified at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModifiedAt { get; set; }

        /// <summary>
        /// A short video, trimmed from the original driver in high resolution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.GetPresentersResponsePresenterVoiceMicrosoft, global::G.GetPresentersResponsePresenterVoiceElevenLabs, global::G.GetPresentersResponsePresenterVoiceAmazon, global::G.GetPresentersResponsePresenterVoiceGoogle, global::G.GetPresentersResponsePresenterVoiceOpenAI>))]
        public global::G.AnyOf<global::G.GetPresentersResponsePresenterVoiceMicrosoft, global::G.GetPresentersResponsePresenterVoiceElevenLabs, global::G.GetPresentersResponsePresenterVoiceAmazon, global::G.GetPresentersResponsePresenterVoiceGoogle, global::G.GetPresentersResponsePresenterVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Whether or not the presenter is streamable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_streamable")]
        public bool? IsStreamable { get; set; }

        /// <summary>
        /// Indicates if the presenter supports transparent background
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_greenscreen")]
        public bool? IsGreenscreen { get; set; }

        /// <summary>
        /// The status of the presenter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetPresentersResponsePresenterStatusJsonConverter))]
        public global::G.GetPresentersResponsePresenterStatus? Status { get; set; }

        /// <summary>
        /// The face rect of the presenter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_rect")]
        public global::G.GetPresentersResponsePresenterFaceRect? FaceRect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresentersResponsePresenter" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPresentersResponsePresenter(
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
            global::G.AnyOf<global::G.GetPresentersResponsePresenterVoiceMicrosoft, global::G.GetPresentersResponsePresenterVoiceElevenLabs, global::G.GetPresentersResponsePresenterVoiceAmazon, global::G.GetPresentersResponsePresenterVoiceGoogle, global::G.GetPresentersResponsePresenterVoiceOpenAI>? voice,
            bool? isStreamable,
            bool? isGreenscreen,
            global::G.GetPresentersResponsePresenterStatus? status,
            global::G.GetPresentersResponsePresenterFaceRect? faceRect)
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
        /// Initializes a new instance of the <see cref="GetPresentersResponsePresenter" /> class.
        /// </summary>
        public GetPresentersResponsePresenter()
        {
        }
    }
}