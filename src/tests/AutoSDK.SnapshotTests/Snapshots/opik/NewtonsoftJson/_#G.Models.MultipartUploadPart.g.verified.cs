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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("e_tag", Required = global::Newtonsoft.Json.Required.Always)]
        public string ETag { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int PartNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadPart" /> class.
        /// </summary>
        /// <param name="eTag"></param>
        /// <param name="partNumber"></param>
        public MultipartUploadPart(
            string eTag,
            int partNumber)
        {
            this.ETag = eTag ?? throw new global::System.ArgumentNullException(nameof(eTag));
            this.PartNumber = partNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadPart" /> class.
        /// </summary>
        public MultipartUploadPart()
        {
        }
    }
}