//HintName: G.Models.Chunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A chunk of text extracted from a document page.
    /// </summary>
    public sealed partial class Chunk
    {
        /// <summary>
        /// The full content of the chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The content of the chunk to embed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_to_embed", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentToEmbed { get; set; } = default!;

        /// <summary>
        /// List of elements contained in this chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("elements", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChunkElement> Elements { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        /// <param name="contentToEmbed">
        /// The content of the chunk to embed
        /// </param>
        /// <param name="elements">
        /// List of elements contained in this chunk
        /// </param>
        /// <param name="content">
        /// The full content of the chunk
        /// </param>
        public Chunk(
            string contentToEmbed,
            global::System.Collections.Generic.IList<global::G.ChunkElement> elements,
            string? content)
        {
            this.Content = content;
            this.ContentToEmbed = contentToEmbed ?? throw new global::System.ArgumentNullException(nameof(contentToEmbed));
            this.Elements = elements ?? throw new global::System.ArgumentNullException(nameof(elements));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        public Chunk()
        {
        }
    }
}