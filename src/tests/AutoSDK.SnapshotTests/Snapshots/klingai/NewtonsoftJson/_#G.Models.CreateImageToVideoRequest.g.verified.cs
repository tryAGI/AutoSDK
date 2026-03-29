//HintName: G.Models.CreateImageToVideoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequest
    {
        /// <summary>
        /// Model to use for generation.<br/>
        /// Default Value: kling-v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public global::G.CreateImageToVideoRequestModelName? ModelName { get; set; }

        /// <summary>
        /// Input image as Base64 string or URL. Formats supported are jpg, jpeg, png. Max size 10MB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public string? Image { get; set; }

        /// <summary>
        /// End frame image as Base64 string or URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_tail")]
        public string? ImageTail { get; set; }

        /// <summary>
        /// Text prompt for video generation guidance. Max 2500 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Classifier-free guidance scale. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cfg_scale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// Generation mode.<br/>
        /// Default Value: std
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.CreateImageToVideoRequestMode? Mode { get; set; }

        /// <summary>
        /// Aspect ratio of the output video.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        public global::G.CreateImageToVideoRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Duration of the video in seconds.<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public global::G.CreateImageToVideoRequestDuration? Duration { get; set; }

        /// <summary>
        /// Whether to generate audio for the video.<br/>
        /// Default Value: off
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sound")]
        public global::G.CreateImageToVideoRequestSound? Sound { get; set; }

        /// <summary>
        /// Static mask image as Base64 string or URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("static_mask")]
        public string? StaticMask { get; set; }

        /// <summary>
        /// Array of dynamic mask groups. Max 6 groups.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_masks")]
        public global::System.Collections.Generic.IList<global::G.DynamicMask>? DynamicMasks { get; set; }

        /// <summary>
        /// Array of voice items for audio. Max 2 voices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_list")]
        public global::System.Collections.Generic.IList<global::G.VoiceItem>? VoiceList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("camera_control")]
        public global::G.CameraControl? CameraControl { get; set; }

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// External task ID for tracking purposes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_task_id")]
        public string? ExternalTaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequest" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Model to use for generation.<br/>
        /// Default Value: kling-v1
        /// </param>
        /// <param name="image">
        /// Input image as Base64 string or URL. Formats supported are jpg, jpeg, png. Max size 10MB.
        /// </param>
        /// <param name="imageTail">
        /// End frame image as Base64 string or URL.
        /// </param>
        /// <param name="prompt">
        /// Text prompt for video generation guidance. Max 2500 characters.
        /// </param>
        /// <param name="negativePrompt">
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </param>
        /// <param name="cfgScale">
        /// Classifier-free guidance scale. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="mode">
        /// Generation mode.<br/>
        /// Default Value: std
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the output video.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="sound">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: off
        /// </param>
        /// <param name="staticMask">
        /// Static mask image as Base64 string or URL.
        /// </param>
        /// <param name="dynamicMasks">
        /// Array of dynamic mask groups. Max 6 groups.
        /// </param>
        /// <param name="voiceList">
        /// Array of voice items for audio. Max 2 voices.
        /// </param>
        /// <param name="cameraControl"></param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="externalTaskId">
        /// External task ID for tracking purposes.
        /// </param>
        public CreateImageToVideoRequest(
            global::G.CreateImageToVideoRequestModelName? modelName,
            string? image,
            string? imageTail,
            string? prompt,
            string? negativePrompt,
            double? cfgScale,
            global::G.CreateImageToVideoRequestMode? mode,
            global::G.CreateImageToVideoRequestAspectRatio? aspectRatio,
            global::G.CreateImageToVideoRequestDuration? duration,
            global::G.CreateImageToVideoRequestSound? sound,
            string? staticMask,
            global::System.Collections.Generic.IList<global::G.DynamicMask>? dynamicMasks,
            global::System.Collections.Generic.IList<global::G.VoiceItem>? voiceList,
            global::G.CameraControl? cameraControl,
            string? callbackUrl,
            string? externalTaskId)
        {
            this.ModelName = modelName;
            this.Image = image;
            this.ImageTail = imageTail;
            this.Prompt = prompt;
            this.NegativePrompt = negativePrompt;
            this.CfgScale = cfgScale;
            this.Mode = mode;
            this.AspectRatio = aspectRatio;
            this.Duration = duration;
            this.Sound = sound;
            this.StaticMask = staticMask;
            this.DynamicMasks = dynamicMasks;
            this.VoiceList = voiceList;
            this.CameraControl = cameraControl;
            this.CallbackUrl = callbackUrl;
            this.ExternalTaskId = externalTaskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequest" /> class.
        /// </summary>
        public CreateImageToVideoRequest()
        {
        }
    }
}