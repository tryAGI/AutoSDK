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
        [global::Newtonsoft.Json.JsonProperty("upload_file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] UploadFile { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadFilename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFileApiV1FilesPost" /> class.
        /// </summary>
        /// <param name="uploadFile"></param>
        /// <param name="uploadFilename"></param>
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