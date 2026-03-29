//HintName: G.Models.BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] UploadFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_file_id")]
        public string? ExternalFileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost" /> class.
        /// </summary>
        /// <param name="uploadFile"></param>
        /// <param name="uploadFilename"></param>
        /// <param name="uniqueId"></param>
        /// <param name="displayName"></param>
        /// <param name="externalFileId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost(
            byte[] uploadFile,
            string uploadFilename,
            string? uniqueId,
            string? displayName,
            string? externalFileId)
        {
            this.UploadFile = uploadFile ?? throw new global::System.ArgumentNullException(nameof(uploadFile));
            this.UploadFilename = uploadFilename ?? throw new global::System.ArgumentNullException(nameof(uploadFilename));
            this.UniqueId = uniqueId;
            this.DisplayName = displayName;
            this.ExternalFileId = externalFileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost" /> class.
        /// </summary>
        public BodyUploadFileToDirectoryApiV1BetaDirectoriesDirectoryIdFilesUploadPost()
        {
        }
    }
}