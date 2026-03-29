//HintName: G.Models.AWSStsCredentials.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AWSStsCredentials
    {
        /// <summary>
        /// This is the access key ID for the AWS credential
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("AccessKeyId")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// This is the expiration date for the AWS credential
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Expiration")]
        public global::System.DateTime? Expiration { get; set; }

        /// <summary>
        /// This is the secret access key for the AWS credential
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SecretAccessKey")]
        public string? SecretAccessKey { get; set; }

        /// <summary>
        /// This is the session token for the AWS credential
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SessionToken")]
        public string? SessionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsCredentials" /> class.
        /// </summary>
        /// <param name="accessKeyId">
        /// This is the access key ID for the AWS credential
        /// </param>
        /// <param name="expiration">
        /// This is the expiration date for the AWS credential
        /// </param>
        /// <param name="secretAccessKey">
        /// This is the secret access key for the AWS credential
        /// </param>
        /// <param name="sessionToken">
        /// This is the session token for the AWS credential
        /// </param>
        public AWSStsCredentials(
            string? accessKeyId,
            global::System.DateTime? expiration,
            string? secretAccessKey,
            string? sessionToken)
        {
            this.AccessKeyId = accessKeyId;
            this.Expiration = expiration;
            this.SecretAccessKey = secretAccessKey;
            this.SessionToken = sessionToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsCredentials" /> class.
        /// </summary>
        public AWSStsCredentials()
        {
        }
    }
}