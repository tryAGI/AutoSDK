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
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// The binary data of the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_faces")]
        public string? DetectFaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// A URL to upload the image to. If provided, the image will be uploaded to this URL instead of the default bucket. Should be an https presigned URL. S3 presigned urls should have the putObject permission with content type matching the uploaded image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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