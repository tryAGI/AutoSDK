//HintName: G.Models.FileCitationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation to a file.
    /// </summary>
    public sealed partial class FileCitationBody
    {
        /// <summary>
        /// The type of the file citation. Always `file_citation`.<br/>
        /// Default Value: file_citation
        /// </summary>
        /// <default>global::G.FileCitationBodyType.FileCitation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileCitationBodyTypeJsonConverter))]
        public global::G.FileCitationBodyType Type { get; set; } = global::G.FileCitationBodyType.FileCitation;

        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The index of the file in the list of files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitationBody" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the file citation. Always `file_citation`.<br/>
        /// Default Value: file_citation
        /// </param>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="index">
        /// The index of the file in the list of files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileCitationBody(
            string fileId,
            int index,
            global::G.FileCitationBodyType type = global::G.FileCitationBodyType.FileCitation)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitationBody" /> class.
        /// </summary>
        public FileCitationBody()
        {
        }
    }
}