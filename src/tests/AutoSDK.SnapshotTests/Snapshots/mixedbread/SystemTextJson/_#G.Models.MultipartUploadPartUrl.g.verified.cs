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
        [global::System.Text.Json.Serialization.JsonPropertyName("part_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartNumber { get; set; }

        /// <summary>
        /// Presigned URL for uploading this part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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