//HintName: G.Models.BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credential_id")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account_file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] ServiceAccountFile { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account_filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServiceAccountFilename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost" /> class.
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="serviceAccountFile"></param>
        /// <param name="serviceAccountFilename"></param>
        public BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost(
            byte[] serviceAccountFile,
            string serviceAccountFilename,
            string? credentialId)
        {
            this.ServiceAccountFile = serviceAccountFile ?? throw new global::System.ArgumentNullException(nameof(serviceAccountFile));
            this.ServiceAccountFilename = serviceAccountFilename ?? throw new global::System.ArgumentNullException(nameof(serviceAccountFilename));
            this.CredentialId = credentialId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost" /> class.
        /// </summary>
        public BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost()
        {
        }
    }
}