//HintName: G.Models.GcpKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GcpKey
    {
        /// <summary>
        /// This is the type of the key. Most likely, this is "service_account".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// This is the ID of the Google Cloud project associated with this key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the private key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privateKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PrivateKeyId { get; set; } = default!;

        /// <summary>
        /// This is the private key in PEM format.<br/>
        /// Note: This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privateKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string PrivateKey { get; set; } = default!;

        /// <summary>
        /// This is the email address associated with the service account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientEmail", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientEmail { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// This is the URI for the auth provider's authorization endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authUri", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthUri { get; set; } = default!;

        /// <summary>
        /// This is the URI for the auth provider's token endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenUri", Required = global::Newtonsoft.Json.Required.Always)]
        public string TokenUri { get; set; } = default!;

        /// <summary>
        /// This is the URL of the public x509 certificate for the auth provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authProviderX509CertUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthProviderX509CertUrl { get; set; } = default!;

        /// <summary>
        /// This is the URL of the public x509 certificate for the client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientX509CertUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientX509CertUrl { get; set; } = default!;

        /// <summary>
        /// This is the domain associated with the universe this service account belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("universeDomain", Required = global::Newtonsoft.Json.Required.Always)]
        public string UniverseDomain { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpKey" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of the key. Most likely, this is "service_account".
        /// </param>
        /// <param name="projectId">
        /// This is the ID of the Google Cloud project associated with this key.
        /// </param>
        /// <param name="privateKeyId">
        /// This is the unique identifier for the private key.
        /// </param>
        /// <param name="privateKey">
        /// This is the private key in PEM format.<br/>
        /// Note: This is not returned in the API.
        /// </param>
        /// <param name="clientEmail">
        /// This is the email address associated with the service account.
        /// </param>
        /// <param name="clientId">
        /// This is the unique identifier for the client.
        /// </param>
        /// <param name="authUri">
        /// This is the URI for the auth provider's authorization endpoint.
        /// </param>
        /// <param name="tokenUri">
        /// This is the URI for the auth provider's token endpoint.
        /// </param>
        /// <param name="authProviderX509CertUrl">
        /// This is the URL of the public x509 certificate for the auth provider.
        /// </param>
        /// <param name="clientX509CertUrl">
        /// This is the URL of the public x509 certificate for the client.
        /// </param>
        /// <param name="universeDomain">
        /// This is the domain associated with the universe this service account belongs to.
        /// </param>
        public GcpKey(
            string type,
            string projectId,
            string privateKeyId,
            string privateKey,
            string clientEmail,
            string clientId,
            string authUri,
            string tokenUri,
            string authProviderX509CertUrl,
            string clientX509CertUrl,
            string universeDomain)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.PrivateKeyId = privateKeyId ?? throw new global::System.ArgumentNullException(nameof(privateKeyId));
            this.PrivateKey = privateKey ?? throw new global::System.ArgumentNullException(nameof(privateKey));
            this.ClientEmail = clientEmail ?? throw new global::System.ArgumentNullException(nameof(clientEmail));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.AuthUri = authUri ?? throw new global::System.ArgumentNullException(nameof(authUri));
            this.TokenUri = tokenUri ?? throw new global::System.ArgumentNullException(nameof(tokenUri));
            this.AuthProviderX509CertUrl = authProviderX509CertUrl ?? throw new global::System.ArgumentNullException(nameof(authProviderX509CertUrl));
            this.ClientX509CertUrl = clientX509CertUrl ?? throw new global::System.ArgumentNullException(nameof(clientX509CertUrl));
            this.UniverseDomain = universeDomain ?? throw new global::System.ArgumentNullException(nameof(universeDomain));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpKey" /> class.
        /// </summary>
        public GcpKey()
        {
        }
    }
}