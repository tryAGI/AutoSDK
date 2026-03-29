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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploadUrl")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploadCredentials", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MultipartUploadCredentialsResponse UploadCredentials { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetMultipartUploadResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="uploadCredentials"></param>
        /// <param name="uploadUrl">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
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