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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ElementTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ElementType Type { get; set; }

        /// <summary>
        /// The confidence score of the extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The bounding box coordinates [x1, y1, x2, y2]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Bbox { get; set; }

        /// <summary>
        /// The page number where the element was found
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// The extracted text content of the element
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// A brief summary of the element's content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The base64-encoded image data for figure elements
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkElement(
            global::G.ElementType type,
            double confidence,
            byte[] bbox,
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