//HintName: G.Models.MultipartUploadPartUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartUploadPartUrl
    {
        /// <summary>
        /// 1-based part number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PartNumber { get; set; } = default!;

        /// <summary>
        /// Presigned URL for uploading this part
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadPartUrl" /> class.
        /// </summary>
        /// <param name="partNumber">
        /// 1-based part number
        /// </param>
        /// <param name="url">
        /// Presigned URL for uploading this part
        /// </param>
        public MultipartUploadPartUrl(
            int partNumber,
            string url)
        {
            this.PartNumber = partNumber;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadPartUrl" /> class.
        /// </summary>
        public MultipartUploadPartUrl()
        {
        }
    }
}