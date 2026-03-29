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
        [global::Newtonsoft.Json.JsonProperty("purpose", Required = global::Newtonsoft.Json.Required.Always)]
        public string Purpose { get; set; } = default!;

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The ID of the file in the external system
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_file_id")]
        public string? ExternalFileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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