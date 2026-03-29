//HintName: G.Models.BodyUploadFileApiV1BetaFilesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadFileApiV1BetaFilesPost
    {
        /// <summary>
        /// The intended purpose of the file. Valid values: 'user_data', 'parse', 'extract', 'split', 'classify', 'sheet', 'agent_app'. This determines the storage and retention policy for the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Purpose { get; set; }

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The ID of the file in the external system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_file_id")]
        public string? ExternalFileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFileApiV1BetaFilesPost" /> class.
        /// </summary>
        /// <param name="purpose">
        /// The intended purpose of the file. Valid values: 'user_data', 'parse', 'extract', 'split', 'classify', 'sheet', 'agent_app'. This determines the storage and retention policy for the file.
        /// </param>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="externalFileId">
        /// The ID of the file in the external system
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadFileApiV1BetaFilesPost(
            string purpose,
            byte[] file,
            string filename,
            string? externalFileId)
        {
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ExternalFileId = externalFileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFileApiV1BetaFilesPost" /> class.
        /// </summary>
        public BodyUploadFileApiV1BetaFilesPost()
        {
        }
    }
}