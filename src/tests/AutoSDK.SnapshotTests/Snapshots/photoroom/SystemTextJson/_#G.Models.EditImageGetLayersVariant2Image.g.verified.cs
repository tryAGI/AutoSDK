//HintName: G.Models.EditImageGetLayersVariant2Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetLayersVariant2Image
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontalAlignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EditImageGetLayersVariant2ImageHorizontalAlignmentJsonConverter))]
        public global::G.EditImageGetLayersVariant2ImageHorizontalAlignment? HorizontalAlignment { get; set; }

        /// <summary>
        /// Bytes of the main image used by the API. The POST endpoint accepts `imageFile` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to send the URL of an image, please instead use the GET endpoint with the argument `imageUrl`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFile")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// Bytes of the main image used by the API. The POST endpoint accepts `imageFile` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to send the URL of an image, please instead use the GET endpoint with the argument `imageUrl`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFilename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// Instead of providing an image, you can provide a prompt to generate an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFromPrompt")]
        public global::G.EditImageGetLayersVariant2ImageImageFromPrompt? ImageFromPrompt { get; set; }

        /// <summary>
        /// URL of the main image used by the API. The GET endpoint accepts `imageUrl` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to directly upload an image file, please instead use the POST endpoint with the argument `imageFile`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin")]
        public string? Margin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marginBottom")]
        public string? MarginBottom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marginLeft")]
        public string? MarginLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marginRight")]
        public string? MarginRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marginTop")]
        public string? MarginTop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("padding")]
        public string? Padding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paddingBottom")]
        public string? PaddingBottom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paddingLeft")]
        public string? PaddingLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paddingRight")]
        public string? PaddingRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paddingTop")]
        public string? PaddingTop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeBackground")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EditImageGetLayersVariant2ImageRemoveBackgroundJsonConverter))]
        public global::G.EditImageGetLayersVariant2ImageRemoveBackground? RemoveBackground { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation")]
        public global::G.EditImageGetLayersVariant2ImageSegmentation? Segmentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useForAIBackground")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EditImageGetLayersVariant2ImageUseForAIBackgroundJsonConverter))]
        public global::G.EditImageGetLayersVariant2ImageUseForAIBackground? UseForAIBackground { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verticalAlignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EditImageGetLayersVariant2ImageVerticalAlignmentJsonConverter))]
        public global::G.EditImageGetLayersVariant2ImageVerticalAlignment? VerticalAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant2Image" /> class.
        /// </summary>
        /// <param name="horizontalAlignment"></param>
        /// <param name="imageFile">
        /// Bytes of the main image used by the API. The POST endpoint accepts `imageFile` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to send the URL of an image, please instead use the GET endpoint with the argument `imageUrl`.
        /// </param>
        /// <param name="imageFilename">
        /// Bytes of the main image used by the API. The POST endpoint accepts `imageFile` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to send the URL of an image, please instead use the GET endpoint with the argument `imageUrl`.
        /// </param>
        /// <param name="imageFromPrompt">
        /// Instead of providing an image, you can provide a prompt to generate an image.
        /// </param>
        /// <param name="imageUrl">
        /// URL of the main image used by the API. The GET endpoint accepts `imageUrl` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to directly upload an image file, please instead use the POST endpoint with the argument `imageFile`.
        /// </param>
        /// <param name="margin"></param>
        /// <param name="marginBottom"></param>
        /// <param name="marginLeft"></param>
        /// <param name="marginRight"></param>
        /// <param name="marginTop"></param>
        /// <param name="padding"></param>
        /// <param name="paddingBottom"></param>
        /// <param name="paddingLeft"></param>
        /// <param name="paddingRight"></param>
        /// <param name="paddingTop"></param>
        /// <param name="removeBackground"></param>
        /// <param name="segmentation"></param>
        /// <param name="useForAIBackground"></param>
        /// <param name="verticalAlignment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageGetLayersVariant2Image(
            global::G.EditImageGetLayersVariant2ImageHorizontalAlignment? horizontalAlignment,
            byte[]? imageFile,
            string? imageFilename,
            global::G.EditImageGetLayersVariant2ImageImageFromPrompt? imageFromPrompt,
            string? imageUrl,
            string? margin,
            string? marginBottom,
            string? marginLeft,
            string? marginRight,
            string? marginTop,
            string? padding,
            string? paddingBottom,
            string? paddingLeft,
            string? paddingRight,
            string? paddingTop,
            global::G.EditImageGetLayersVariant2ImageRemoveBackground? removeBackground,
            global::G.EditImageGetLayersVariant2ImageSegmentation? segmentation,
            global::G.EditImageGetLayersVariant2ImageUseForAIBackground? useForAIBackground,
            global::G.EditImageGetLayersVariant2ImageVerticalAlignment? verticalAlignment)
        {
            this.HorizontalAlignment = horizontalAlignment;
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.ImageFromPrompt = imageFromPrompt;
            this.ImageUrl = imageUrl;
            this.Margin = margin;
            this.MarginBottom = marginBottom;
            this.MarginLeft = marginLeft;
            this.MarginRight = marginRight;
            this.MarginTop = marginTop;
            this.Padding = padding;
            this.PaddingBottom = paddingBottom;
            this.PaddingLeft = paddingLeft;
            this.PaddingRight = paddingRight;
            this.PaddingTop = paddingTop;
            this.RemoveBackground = removeBackground;
            this.Segmentation = segmentation;
            this.UseForAIBackground = useForAIBackground;
            this.VerticalAlignment = verticalAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant2Image" /> class.
        /// </summary>
        public EditImageGetLayersVariant2Image()
        {
        }
    }
}