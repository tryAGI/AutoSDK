//HintName: G.Models.VideoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoResponse
    {
        /// <summary>
        /// Downloadable captions files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("captions")]
        public global::G.VideoAssetCaptionTypesResponse? Captions { get; set; }

        /// <summary>
        /// Optional folder ID. If provided, the new video will be created under this folder and inherit its permissions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folderId")]
        public global::System.Guid? FolderId { get; set; }

        /// <summary>
        /// Aspect ratio of the video. Default is `landscape (16:9)`.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspectRatio")]
        public global::G.VideoResponseAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Settings for a call-to-action button.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ctaSettings")]
        public global::G.CtaSettings? CtaSettings { get; set; }

        /// <summary>
        /// Use callback ID to link videos back to the initial request. For example, if you are making a personalized video for a customer, you could enter the customer's email as a callback ID. This way, you can tell who the video is for, once its generated..
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callbackId")]
        public string? CallbackId { get; set; }

        /// <summary>
        /// Description of the video to be shown on the share page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An array of objects that each describe a clip of a multi-clip video. You can think of the clips as different scenes in the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Input> Input { get; set; } = default!;

        /// <summary>
        /// soundtrack option is supported for backward compatibility. You should use the templates functionality for rich videos.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soundtrack")]
        public global::G.VideoResponseSoundtrack? Soundtrack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soundSettings")]
        public global::G.ParentSoundSettings? SoundSettings { get; set; }

        /// <summary>
        /// Test videos are free and not counted towards your quota. If you create a video in the “test” mode, we will overlay a watermark over your video.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Title of the video to be shown on the share page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Public videos will be visible to anyone with a share URL.<br/>
        /// Private videos can only be downloaded via a time-limited download link. See Retrieve a video for details.<br/>
        /// Visibility can be changed also once the video is created via Update a video.<br/>
        /// Default Value: private
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        public global::G.VideoResponseVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download")]
        public string? Download { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUpdatedAt")]
        public int? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.VideoResponseStatus? Status { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail")]
        public global::G.VideoThumbnailTypesResponse? Thumbnail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResponse" /> class.
        /// </summary>
        /// <param name="input">
        /// An array of objects that each describe a clip of a multi-clip video. You can think of the clips as different scenes in the video.
        /// </param>
        /// <param name="captions">
        /// Downloadable captions files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="folderId">
        /// Optional folder ID. If provided, the new video will be created under this folder and inherit its permissions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the video. Default is `landscape (16:9)`.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="ctaSettings">
        /// Settings for a call-to-action button.
        /// </param>
        /// <param name="callbackId">
        /// Use callback ID to link videos back to the initial request. For example, if you are making a personalized video for a customer, you could enter the customer's email as a callback ID. This way, you can tell who the video is for, once its generated..
        /// </param>
        /// <param name="description">
        /// Description of the video to be shown on the share page.
        /// </param>
        /// <param name="soundtrack">
        /// soundtrack option is supported for backward compatibility. You should use the templates functionality for rich videos.
        /// </param>
        /// <param name="soundSettings"></param>
        /// <param name="test">
        /// Test videos are free and not counted towards your quota. If you create a video in the “test” mode, we will overlay a watermark over your video.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="title">
        /// Title of the video to be shown on the share page.
        /// </param>
        /// <param name="visibility">
        /// Public videos will be visible to anyone with a share URL.<br/>
        /// Private videos can only be downloaded via a time-limited download link. See Retrieve a video for details.<br/>
        /// Visibility can be changed also once the video is created via Update a video.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="download"></param>
        /// <param name="duration"></param>
        /// <param name="id"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="status"></param>
        /// <param name="thumbnail">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public VideoResponse(
            global::System.Collections.Generic.IList<global::G.Input> input,
            global::G.VideoAssetCaptionTypesResponse? captions,
            global::System.Guid? folderId,
            global::G.VideoResponseAspectRatio? aspectRatio,
            global::G.CtaSettings? ctaSettings,
            string? callbackId,
            string? description,
            global::G.VideoResponseSoundtrack? soundtrack,
            global::G.ParentSoundSettings? soundSettings,
            bool? test,
            string? title,
            global::G.VideoResponseVisibility? visibility,
            int? createdAt,
            string? download,
            string? duration,
            global::System.Guid? id,
            int? lastUpdatedAt,
            global::G.VideoResponseStatus? status,
            global::G.VideoThumbnailTypesResponse? thumbnail)
        {
            this.Captions = captions;
            this.FolderId = folderId;
            this.AspectRatio = aspectRatio;
            this.CtaSettings = ctaSettings;
            this.CallbackId = callbackId;
            this.Description = description;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Soundtrack = soundtrack;
            this.SoundSettings = soundSettings;
            this.Test = test;
            this.Title = title;
            this.Visibility = visibility;
            this.CreatedAt = createdAt;
            this.Download = download;
            this.Duration = duration;
            this.Id = id;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Status = status;
            this.Thumbnail = thumbnail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResponse" /> class.
        /// </summary>
        public VideoResponse()
        {
        }
    }
}