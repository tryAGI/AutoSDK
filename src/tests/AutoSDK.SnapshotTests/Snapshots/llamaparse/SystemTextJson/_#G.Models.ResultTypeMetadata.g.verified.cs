//HintName: G.Models.ResultTypeMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata about a specific result type stored in S3.
    /// </summary>
    public sealed partial class ResultTypeMetadata
    {
        /// <summary>
        /// Size of the result file in S3 (bytes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// Whether the result file exists in S3<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exists")]
        public bool? Exists { get; set; }

        /// <summary>
        /// Presigned URL to download the result file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presigned_url")]
        public string? PresignedUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultTypeMetadata" /> class.
        /// </summary>
        /// <param name="sizeBytes">
        /// Size of the result file in S3 (bytes)
        /// </param>
        /// <param name="exists">
        /// Whether the result file exists in S3<br/>
        /// Default Value: true
        /// </param>
        /// <param name="presignedUrl">
        /// Presigned URL to download the result file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultTypeMetadata(
            long sizeBytes,
            bool? exists,
            string? presignedUrl)
        {
            this.SizeBytes = sizeBytes;
            this.Exists = exists;
            this.PresignedUrl = presignedUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultTypeMetadata" /> class.
        /// </summary>
        public ResultTypeMetadata()
        {
        }
    }
}