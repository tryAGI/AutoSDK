//HintName: G.Models.ResponseFileCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation to a file.
    /// </summary>
    public sealed partial class ResponseFileCitation
    {
        /// <summary>
        /// The type of the annotation. Always `file_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFileCitationTypeJsonConverter))]
        public global::G.ResponseFileCitationType Type { get; set; }

        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The index of the citation in the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFileCitation" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="type">
        /// The type of the annotation. Always `file_citation`.
        /// </param>
        /// <param name="index">
        /// The index of the citation in the text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFileCitation(
            string fileId,
            global::G.ResponseFileCitationType type,
            int? index)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFileCitation" /> class.
        /// </summary>
        public ResponseFileCitation()
        {
        }
    }
}