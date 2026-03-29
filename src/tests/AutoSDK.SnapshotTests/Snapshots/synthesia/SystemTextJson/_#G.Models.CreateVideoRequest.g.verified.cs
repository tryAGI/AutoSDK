//HintName: G.Models.CreateVideoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoRequest
    {
        /// <summary>
        /// Optional folder ID. If provided, the new video will be created under this folder and inherit its permissions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderId")]
        public global::System.Guid? FolderId { get; set; }

        /// <summary>
        /// Aspect ratio of the video. Default is `landscape (16:9)`.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateVideoRequestAspectRatioJsonConverter))]
        public global::G.CreateVideoRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Settings for a call-to-action button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ctaSettings")]
        public global::G.CtaSettings? CtaSettings { get; set; }

        /// <summary>
        /// Use callback ID to link videos back to the initial request. For example, if you are making a personalized video for a customer, you could enter the customer's email as a callback ID. This way, you can tell who the video is for, once its generated..
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackId")]
        public string? CallbackId { get; set; }

        /// <summary>
        /// Description of the video to be shown on the share page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An array of objects that each describe a clip of a multi-clip video. You can think of the clips as different scenes in the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Input> Input { get; set; }

        /// <summary>
        /// soundtrack option is supported for backward compatibility. You should use the templates functionality for rich videos.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soundtrack")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateVideoRequestSoundtrackJsonConverter))]
        public global::G.CreateVideoRequestSoundtrack? Soundtrack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soundSettings")]
        public global::G.ParentSoundSettings? SoundSettings { get; set; }

        /// <summary>
        /// Test videos are free and not counted towards your quota. If you create a video in the “test” mode, we will overlay a watermark over your video.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Title of the video to be shown on the share page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Public videos will be visible to anyone with a share URL.<br/>
        /// Private videos can only be downloaded via a time-limited download link. See Retrieve a video for details.<br/>
        /// Visibility can be changed also once the video is created via Update a video.<br/>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateVideoRequestVisibilityJsonConverter))]
        public global::G.CreateVideoRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// An array of objects that each describe a clip of a multi-clip video. You can think of the clips as different scenes in the video.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoRequest(
            global::System.Collections.Generic.IList<global::G.Input> input,
            global::System.Guid? folderId,
            global::G.CreateVideoRequestAspectRatio? aspectRatio,
            global::G.CtaSettings? ctaSettings,
            string? callbackId,
            string? description,
            global::G.CreateVideoRequestSoundtrack? soundtrack,
            global::G.ParentSoundSettings? soundSettings,
            bool? test,
            string? title,
            global::G.CreateVideoRequestVisibility? visibility)
        {
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoRequest" /> class.
        /// </summary>
        public CreateVideoRequest()
        {
        }
    }
}