//HintName: G.Models.FilePath.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A path to a file.
    /// </summary>
    public sealed partial class FilePath
    {
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
        /// The type of the file path. Always `file_path`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilePathTypeJsonConverter))]
        public global::G.FilePathType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePath" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="index">
        /// The index of the file in the list of files.
        /// </param>
        /// <param name="type">
        /// The type of the file path. Always `file_path`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilePath(
            string fileId,
            int index,
            global::G.FilePathType type)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePath" /> class.
        /// </summary>
        public FilePath()
        {
        }
    }
}