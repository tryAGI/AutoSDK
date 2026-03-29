//HintName: G.Models.CreateAssetMultipartUploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetMultipartUploadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadUrl")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadCredentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MultipartUploadCredentialsResponse UploadCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetMultipartUploadResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="uploadCredentials"></param>
        /// <param name="uploadUrl">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetMultipartUploadResponse(
            string id,
            global::G.MultipartUploadCredentialsResponse uploadCredentials,
            string? uploadUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UploadUrl = uploadUrl;
            this.UploadCredentials = uploadCredentials ?? throw new global::System.ArgumentNullException(nameof(uploadCredentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetMultipartUploadResponse" /> class.
        /// </summary>
        public CreateAssetMultipartUploadResponse()
        {
        }
    }
}