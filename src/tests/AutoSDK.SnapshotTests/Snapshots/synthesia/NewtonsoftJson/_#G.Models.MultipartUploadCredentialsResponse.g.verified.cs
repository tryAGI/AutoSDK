//HintName: G.Models.MultipartUploadCredentialsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartUploadCredentialsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessKeyId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secretAccessKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string SecretAccessKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionToken", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket", Required = global::Newtonsoft.Json.Required.Always)]
        public string Bucket { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadCredentialsResponse" /> class.
        /// </summary>
        /// <param name="accessKeyId"></param>
        /// <param name="secretAccessKey"></param>
        /// <param name="sessionToken"></param>
        /// <param name="bucket"></param>
        /// <param name="key"></param>
        public MultipartUploadCredentialsResponse(
            string accessKeyId,
            string secretAccessKey,
            string sessionToken,
            string bucket,
            string key)
        {
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.SecretAccessKey = secretAccessKey ?? throw new global::System.ArgumentNullException(nameof(secretAccessKey));
            this.SessionToken = sessionToken ?? throw new global::System.ArgumentNullException(nameof(sessionToken));
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadCredentialsResponse" /> class.
        /// </summary>
        public MultipartUploadCredentialsResponse()
        {
        }
    }
}