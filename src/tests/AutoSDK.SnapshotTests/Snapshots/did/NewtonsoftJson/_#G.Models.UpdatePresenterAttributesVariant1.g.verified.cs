//HintName: G.Models.UpdatePresenterAttributesVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class UpdatePresenterAttributesVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity__modified_at")]
        public string? EntityModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at")]
        public string? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show")]
        public bool? Show { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("talking_preview_url")]
        public string? TalkingPreviewUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.UpdatePresenterAttributesVariant1VoiceMicrosoft, global::G.UpdatePresenterAttributesVariant1VoiceElevenLabs, global::G.UpdatePresenterAttributesVariant1VoiceAmazon, global::G.UpdatePresenterAttributesVariant1VoiceGoogle, global::G.UpdatePresenterAttributesVariant1VoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_streamable")]
        public bool? IsStreamable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_greenscreen")]
        public bool? IsGreenscreen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idle_video")]
        public string? IdleVideo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("a2e_model")]
        public global::G.UpdatePresenterAttributesVariant1A2eModel? A2eModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("face_rect")]
        public global::G.UpdatePresenterAttributesVariant1FaceRect? FaceRect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesVariant1" /> class.
        /// </summary>
        /// <param name="entityModifiedAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="show"></param>
        /// <param name="imageUrl"></param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="videoUrl"></param>
        /// <param name="previewUrl"></param>
        /// <param name="talkingPreviewUrl"></param>
        /// <param name="gender"></param>
        /// <param name="name"></param>
        /// <param name="voice"></param>
        /// <param name="isStreamable"></param>
        /// <param name="isGreenscreen"></param>
        /// <param name="idleVideo"></param>
        /// <param name="a2eModel"></param>
        /// <param name="labels"></param>
        /// <param name="faceRect"></param>
        public UpdatePresenterAttributesVariant1(
            string? entityModifiedAt,
            string? modifiedAt,
            bool? show,
            string? imageUrl,
            string? thumbnailUrl,
            string? videoUrl,
            string? previewUrl,
            string? talkingPreviewUrl,
            string? gender,
            string? name,
            global::G.AnyOf<global::G.UpdatePresenterAttributesVariant1VoiceMicrosoft, global::G.UpdatePresenterAttributesVariant1VoiceElevenLabs, global::G.UpdatePresenterAttributesVariant1VoiceAmazon, global::G.UpdatePresenterAttributesVariant1VoiceGoogle, global::G.UpdatePresenterAttributesVariant1VoiceOpenAI>? voice,
            bool? isStreamable,
            bool? isGreenscreen,
            string? idleVideo,
            global::G.UpdatePresenterAttributesVariant1A2eModel? a2eModel,
            global::System.Collections.Generic.IList<string>? labels,
            global::G.UpdatePresenterAttributesVariant1FaceRect? faceRect)
        {
            this.EntityModifiedAt = entityModifiedAt;
            this.ModifiedAt = modifiedAt;
            this.Show = show;
            this.ImageUrl = imageUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.VideoUrl = videoUrl;
            this.PreviewUrl = previewUrl;
            this.TalkingPreviewUrl = talkingPreviewUrl;
            this.Gender = gender;
            this.Name = name;
            this.Voice = voice;
            this.IsStreamable = isStreamable;
            this.IsGreenscreen = isGreenscreen;
            this.IdleVideo = idleVideo;
            this.A2eModel = a2eModel;
            this.Labels = labels;
            this.FaceRect = faceRect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesVariant1" /> class.
        /// </summary>
        public UpdatePresenterAttributesVariant1()
        {
        }
    }
}