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
        [global::Newtonsoft.Json.JsonProperty("part_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PartNumber { get; set; } = default!;

        /// <summary>
        /// ETag returned by the storage backend after uploading the part
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("etag", Required = global::Newtonsoft.Json.Required.Always)]
        public string Etag { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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