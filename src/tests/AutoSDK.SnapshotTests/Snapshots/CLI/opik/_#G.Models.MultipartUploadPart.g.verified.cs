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
        [global::System.Text.Json.Serialization.JsonPropertyName("e_tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ETag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadPart" /> class.
        /// </summary>
        /// <param name="eTag"></param>
        /// <param name="partNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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