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
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] ServiceAccountFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost" /> class.
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="serviceAccountFile"></param>
        /// <param name="serviceAccountFilename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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