//HintName: G.Models.CreateTextToVideoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToVideoRequest
    {
        /// <summary>
        /// Model to use for generation.<br/>
        /// Default Value: kling-v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public global::G.CreateTextToVideoRequestModelName? ModelName { get; set; }

        /// <summary>
        /// Text prompt for video generation. Max 2500 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

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
        public global::G.CreateTextToVideoRequestMode? Mode { get; set; }

        /// <summary>
        /// Aspect ratio of the output video.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        public global::G.CreateTextToVideoRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Duration of the video in seconds.<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public global::G.CreateTextToVideoRequestDuration? Duration { get; set; }

        /// <summary>
        /// Whether to generate audio for the video.<br/>
        /// Default Value: off
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sound")]
        public global::G.CreateTextToVideoRequestSound? Sound { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for video generation. Max 2500 characters.
        /// </param>
        /// <param name="modelName">
        /// Model to use for generation.<br/>
        /// Default Value: kling-v1
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
        /// <param name="cameraControl"></param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="externalTaskId">
        /// External task ID for tracking purposes.
        /// </param>
        public CreateTextToVideoRequest(
            string prompt,
            global::G.CreateTextToVideoRequestModelName? modelName,
            string? negativePrompt,
            double? cfgScale,
            global::G.CreateTextToVideoRequestMode? mode,
            global::G.CreateTextToVideoRequestAspectRatio? aspectRatio,
            global::G.CreateTextToVideoRequestDuration? duration,
            global::G.CreateTextToVideoRequestSound? sound,
            global::G.CameraControl? cameraControl,
            string? callbackUrl,
            string? externalTaskId)
        {
            this.ModelName = modelName;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.CfgScale = cfgScale;
            this.Mode = mode;
            this.AspectRatio = aspectRatio;
            this.Duration = duration;
            this.Sound = sound;
            this.CameraControl = cameraControl;
            this.CallbackUrl = callbackUrl;
            this.ExternalTaskId = externalTaskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToVideoRequest" /> class.
        /// </summary>
        public CreateTextToVideoRequest()
        {
        }
    }
}