//HintName: G.Models.UploadAnImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAnImageRequest
    {
        /// <summary>
        /// The binary data of the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The binary data of the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detect_faces")]
        public string? DetectFaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// A URL to upload the image to. If provided, the image will be uploaded to this URL instead of the default bucket. Should be an https presigned URL. S3 presigned urls should have the putObject permission with content type matching the uploaded image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAnImageRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The binary data of the image
        /// </param>
        /// <param name="imagename">
        /// The binary data of the image
        /// </param>
        /// <param name="detectFaces"></param>
        /// <param name="metadata"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="resultUrl">
        /// A URL to upload the image to. If provided, the image will be uploaded to this URL instead of the default bucket. Should be an https presigned URL. S3 presigned urls should have the putObject permission with content type matching the uploaded image.
        /// </param>
        public UploadAnImageRequest(
            byte[]? image,
            string? imagename,
            string? detectFaces,
            string? metadata,
            string? sourceUrl,
            string? resultUrl)
        {
            this.Image = image;
            this.Imagename = imagename;
            this.DetectFaces = detectFaces;
            this.Metadata = metadata;
            this.SourceUrl = sourceUrl;
            this.ResultUrl = resultUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAnImageRequest" /> class.
        /// </summary>
        public UploadAnImageRequest()
        {
        }
    }
}