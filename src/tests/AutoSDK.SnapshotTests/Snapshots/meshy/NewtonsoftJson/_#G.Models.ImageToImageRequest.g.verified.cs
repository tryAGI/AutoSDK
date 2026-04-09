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
        [global::Newtonsoft.Json.JsonProperty("ai_model", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ImageAiModelJsonConverter))]
        public global::G.ImageAiModel AiModel { get; set; } = default!;

        /// <summary>
        /// Transformation description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// 1-5 reference images
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_image_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ReferenceImageUrls { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generate_multi_view")]
        public bool? GenerateMultiView { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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