//HintName: G.Models.MultipartUploadPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartUploadPart
    {
        /// <summary>
        /// 1-based part number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartNumber { get; set; }

        /// <summary>
        /// ETag returned by the storage backend after uploading the part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Etag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadPart" /> class.
        /// </summary>
        /// <param name="partNumber">
        /// 1-based part number
        /// </param>
        /// <param name="etag">
        /// ETag returned by the storage backend after uploading the part
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipartUploadPart(
            int partNumber,
            string etag)
        {
            this.PartNumber = partNumber;
            this.Etag = etag ?? throw new global::System.ArgumentNullException(nameof(etag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadPart" /> class.
        /// </summary>
        public MultipartUploadPart()
        {
        }
    }
}