//HintName: G.Models.BulkExportDestinationS3Credentials.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportDestinationS3Credentials
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessKeyId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_access_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string SecretAccessKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationS3Credentials" /> class.
        /// </summary>
        /// <param name="accessKeyId"></param>
        /// <param name="secretAccessKey"></param>
        public BulkExportDestinationS3Credentials(
            string accessKeyId,
            string secretAccessKey)
        {
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.SecretAccessKey = secretAccessKey ?? throw new global::System.ArgumentNullException(nameof(secretAccessKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationS3Credentials" /> class.
        /// </summary>
        public BulkExportDestinationS3Credentials()
        {
        }
    }
}