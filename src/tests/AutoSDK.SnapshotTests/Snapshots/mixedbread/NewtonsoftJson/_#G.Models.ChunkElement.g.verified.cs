//HintName: G.Models.ChunkElement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an extracted element from a document with its content and metadata.
    /// </summary>
    public sealed partial class ChunkElement
    {
        /// <summary>
        /// The type of the extracted element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ElementType Type { get; set; } = default!;

        /// <summary>
        /// The confidence score of the extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// The bounding box coordinates [x1, y1, x2, y2]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bbox", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Bbox { get; set; } = default!;

        /// <summary>
        /// The page number where the element was found
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page", Required = global::Newtonsoft.Json.Required.Always)]
        public int Page { get; set; } = default!;

        /// <summary>
        /// The extracted text content of the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// A brief summary of the element's content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The base64-encoded image data for figure elements
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkElement" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the extracted element
        /// </param>
        /// <param name="confidence">
        /// The confidence score of the extraction
        /// </param>
        /// <param name="bbox">
        /// The bounding box coordinates [x1, y1, x2, y2]
        /// </param>
        /// <param name="page">
        /// The page number where the element was found
        /// </param>
        /// <param name="content">
        /// The extracted text content of the element
        /// </param>
        /// <param name="summary">
        /// A brief summary of the element's content
        /// </param>
        /// <param name="image">
        /// The base64-encoded image data for figure elements
        /// </param>
        public ChunkElement(
            global::G.ElementType type,
            double confidence,
            global::System.Collections.Generic.IList<double> bbox,
            int page,
            string content,
            string? summary,
            string? image)
        {
            this.Type = type;
            this.Confidence = confidence;
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.Page = page;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Summary = summary;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkElement" /> class.
        /// </summary>
        public ChunkElement()
        {
        }
    }
}