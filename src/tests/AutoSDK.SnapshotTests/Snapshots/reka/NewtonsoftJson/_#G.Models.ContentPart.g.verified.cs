//HintName: G.Models.ContentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentPart
    {
        /// <summary>
        /// The type of content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ContentPartTypeJsonConverter))]
        public global::G.ContentPartType Type { get; set; } = default!;

        /// <summary>
        /// The text content. Required when type is "text".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The image URL. Required when type is "image_url".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The video URL. Required when type is "video_url".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// The audio URL. Required when type is "audio_url".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// The PDF URL. Required when type is "pdf_url".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pdf_url")]
        public string? PdfUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content part.
        /// </param>
        /// <param name="text">
        /// The text content. Required when type is "text".
        /// </param>
        /// <param name="imageUrl">
        /// The image URL. Required when type is "image_url".
        /// </param>
        /// <param name="videoUrl">
        /// The video URL. Required when type is "video_url".
        /// </param>
        /// <param name="audioUrl">
        /// The audio URL. Required when type is "audio_url".
        /// </param>
        /// <param name="pdfUrl">
        /// The PDF URL. Required when type is "pdf_url".
        /// </param>
        public ContentPart(
            global::G.ContentPartType type,
            string? text,
            string? imageUrl,
            string? videoUrl,
            string? audioUrl,
            string? pdfUrl)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.VideoUrl = videoUrl;
            this.AudioUrl = audioUrl;
            this.PdfUrl = pdfUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        public ContentPart()
        {
        }
    }
}