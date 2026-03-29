//HintName: G.Models.TextInputChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextInputChunk
    {
        /// <summary>
        /// position of the chunk in a file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChunkIndex { get; set; } = default!;

        /// <summary>
        /// mime type of the chunk<br/>
        /// Default Value: text/plain
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// metadata of the chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_metadata")]
        public global::G.GeneratedMetadataVariant13? GeneratedMetadata { get; set; }

        /// <summary>
        /// model used for this chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Input type identifier<br/>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The offset of the text in the file relative to the start of the file.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Text content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInputChunk" /> class.
        /// </summary>
        /// <param name="chunkIndex">
        /// position of the chunk in a file
        /// </param>
        /// <param name="mimeType">
        /// mime type of the chunk<br/>
        /// Default Value: text/plain
        /// </param>
        /// <param name="generatedMetadata">
        /// metadata of the chunk
        /// </param>
        /// <param name="model">
        /// model used for this chunk
        /// </param>
        /// <param name="type">
        /// Input type identifier<br/>
        /// Default Value: text
        /// </param>
        /// <param name="offset">
        /// The offset of the text in the file relative to the start of the file.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="text">
        /// Text content
        /// </param>
        public TextInputChunk(
            int chunkIndex,
            string? mimeType,
            global::G.GeneratedMetadataVariant13? generatedMetadata,
            string? model,
            string? type,
            int? offset,
            string? text)
        {
            this.ChunkIndex = chunkIndex;
            this.MimeType = mimeType;
            this.GeneratedMetadata = generatedMetadata;
            this.Model = model;
            this.Type = type;
            this.Offset = offset;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInputChunk" /> class.
        /// </summary>
        public TextInputChunk()
        {
        }
    }
}