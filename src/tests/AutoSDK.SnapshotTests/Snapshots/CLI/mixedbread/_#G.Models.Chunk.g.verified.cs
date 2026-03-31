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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The content of the chunk to embed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_to_embed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentToEmbed { get; set; }

        /// <summary>
        /// List of elements contained in this chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChunkElement> Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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