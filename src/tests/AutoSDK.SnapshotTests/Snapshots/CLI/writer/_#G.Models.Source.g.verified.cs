//HintName: G.Models.Source.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A source snippet containing text and fileId from Knowledge Graph content.
    /// </summary>
    public sealed partial class Source
    {
        /// <summary>
        /// The unique identifier of the file in your Writer account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The exact text snippet from the source document that was used to support the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Snippet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier of the file in your Writer account.
        /// </param>
        /// <param name="snippet">
        /// The exact text snippet from the source document that was used to support the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Source(
            string fileId,
            string snippet)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Snippet = snippet ?? throw new global::System.ArgumentNullException(nameof(snippet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        public Source()
        {
        }
    }
}