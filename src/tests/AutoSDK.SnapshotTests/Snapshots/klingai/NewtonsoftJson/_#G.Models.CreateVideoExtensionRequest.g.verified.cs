//HintName: G.Models.CreateVideoExtensionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoExtensionRequest
    {
        /// <summary>
        /// ID of the video to extend.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VideoId { get; set; } = default!;

        /// <summary>
        /// Optional text prompt to guide the extension. Max 2500 characters.
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
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoExtensionRequest" /> class.
        /// </summary>
        /// <param name="videoId">
        /// ID of the video to extend.
        /// </param>
        /// <param name="prompt">
        /// Optional text prompt to guide the extension. Max 2500 characters.
        /// </param>
        /// <param name="negativePrompt">
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </param>
        /// <param name="cfgScale">
        /// Classifier-free guidance scale. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        public CreateVideoExtensionRequest(
            string videoId,
            string? prompt,
            string? negativePrompt,
            double? cfgScale,
            string? callbackUrl)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Prompt = prompt;
            this.NegativePrompt = negativePrompt;
            this.CfgScale = cfgScale;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoExtensionRequest" /> class.
        /// </summary>
        public CreateVideoExtensionRequest()
        {
        }
    }
}