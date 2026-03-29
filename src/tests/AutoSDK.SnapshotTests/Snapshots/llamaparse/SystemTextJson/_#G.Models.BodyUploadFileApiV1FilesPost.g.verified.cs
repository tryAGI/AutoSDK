//HintName: G.Models.BodyUploadFileApiV1FilesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadFileApiV1FilesPost
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFileApiV1FilesPost" /> class.
        /// </summary>
        /// <param name="uploadFile"></param>
        /// <param name="uploadFilename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadFileApiV1FilesPost(
            byte[] uploadFile,
            string uploadFilename)
        {
            this.UploadFile = uploadFile ?? throw new global::System.ArgumentNullException(nameof(uploadFile));
            this.UploadFilename = uploadFilename ?? throw new global::System.ArgumentNullException(nameof(uploadFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFileApiV1FilesPost" /> class.
        /// </summary>
        public BodyUploadFileApiV1FilesPost()
        {
        }
    }
}