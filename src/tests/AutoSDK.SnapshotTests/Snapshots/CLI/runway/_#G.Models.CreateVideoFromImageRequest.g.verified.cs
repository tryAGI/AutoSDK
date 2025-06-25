//HintName: G.Models.CreateVideoFromImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoFromImageRequest
    {
        /// <summary>
        /// HTTPS URL of an image (JPEG, PNG, WebP, max 16MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptImage { get; set; }

        /// <summary>
        /// The model variant to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateVideoFromImageRequestModelJsonConverter))]
        public global::G.CreateVideoFromImageRequestModel Model { get; set; }

        /// <summary>
        /// Seed value for generating consistent results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A detailed description of the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Add a Runway watermark to the output.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public bool? Watermark { get; set; }

        /// <summary>
        /// Duration of the video in seconds.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Aspect ratio of the video.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateVideoFromImageRequestRatioJsonConverter))]
        public global::G.CreateVideoFromImageRequestRatio? Ratio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoFromImageRequest" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// HTTPS URL of an image (JPEG, PNG, WebP, max 16MB).
        /// </param>
        /// <param name="model">
        /// The model variant to use.
        /// </param>
        /// <param name="seed">
        /// Seed value for generating consistent results.
        /// </param>
        /// <param name="promptText">
        /// A detailed description of the output.
        /// </param>
        /// <param name="watermark">
        /// Add a Runway watermark to the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="ratio">
        /// Aspect ratio of the video.<br/>
        /// Default Value: 16:9
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoFromImageRequest(
            string promptImage,
            global::G.CreateVideoFromImageRequestModel model,
            int? seed,
            string? promptText,
            bool? watermark,
            int? duration,
            global::G.CreateVideoFromImageRequestRatio? ratio)
        {
            this.PromptImage = promptImage ?? throw new global::System.ArgumentNullException(nameof(promptImage));
            this.Model = model;
            this.Seed = seed;
            this.PromptText = promptText;
            this.Watermark = watermark;
            this.Duration = duration;
            this.Ratio = ratio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoFromImageRequest" /> class.
        /// </summary>
        public CreateVideoFromImageRequest()
        {
        }
    }
}