//HintName: G.Models.ImageToImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToImageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageAiModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageAiModel AiModel { get; set; }

        /// <summary>
        /// Transformation description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 1-5 reference images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ReferenceImageUrls { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_multi_view")]
        public bool? GenerateMultiView { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequest" /> class.
        /// </summary>
        /// <param name="aiModel"></param>
        /// <param name="prompt">
        /// Transformation description
        /// </param>
        /// <param name="referenceImageUrls">
        /// 1-5 reference images
        /// </param>
        /// <param name="generateMultiView">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToImageRequest(
            global::G.ImageAiModel aiModel,
            string prompt,
            global::System.Collections.Generic.IList<string> referenceImageUrls,
            bool? generateMultiView)
        {
            this.AiModel = aiModel;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ReferenceImageUrls = referenceImageUrls ?? throw new global::System.ArgumentNullException(nameof(referenceImageUrls));
            this.GenerateMultiView = generateMultiView;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequest" /> class.
        /// </summary>
        public ImageToImageRequest()
        {
        }
    }
}