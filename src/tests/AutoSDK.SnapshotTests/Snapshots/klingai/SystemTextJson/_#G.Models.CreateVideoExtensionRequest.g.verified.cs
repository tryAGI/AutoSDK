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
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// Optional text prompt to guide the extension. Max 2500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Negative prompt to exclude unwanted content. Max 2500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Classifier-free guidance scale. Range [0, 1]. Default 0.5.<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfg_scale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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