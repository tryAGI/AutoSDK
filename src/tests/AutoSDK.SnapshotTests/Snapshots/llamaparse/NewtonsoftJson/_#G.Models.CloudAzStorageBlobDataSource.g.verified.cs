//HintName: G.Models.CloudAzStorageBlobDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudAzStorageBlobDataSource
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The name of the Azure Storage Blob container to read from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContainerName { get; set; } = default!;

        /// <summary>
        /// The Azure Storage Blob account URL to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccountUrl { get; set; } = default!;

        /// <summary>
        /// The blob name to read from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blob")]
        public string? Blob { get; set; }

        /// <summary>
        /// The prefix of the Azure Storage Blob objects to read from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// The Azure Storage Blob account name to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_name")]
        public string? AccountName { get; set; }

        /// <summary>
        /// The Azure Storage Blob account key to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_key")]
        public string? AccountKey { get; set; }

        /// <summary>
        /// The Azure AD tenant ID to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// The Azure AD client ID to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The Azure AD client secret to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Default Value: CloudAzStorageBlobDataSource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAzStorageBlobDataSource" /> class.
        /// </summary>
        /// <param name="containerName">
        /// The name of the Azure Storage Blob container to read from.
        /// </param>
        /// <param name="accountUrl">
        /// The Azure Storage Blob account URL to use for authentication.
        /// </param>
        /// <param name="supportsAccessControl">
        /// Default Value: false
        /// </param>
        /// <param name="blob">
        /// The blob name to read from.
        /// </param>
        /// <param name="prefix">
        /// The prefix of the Azure Storage Blob objects to read from.
        /// </param>
        /// <param name="accountName">
        /// The Azure Storage Blob account name to use for authentication.
        /// </param>
        /// <param name="accountKey">
        /// The Azure Storage Blob account key to use for authentication.
        /// </param>
        /// <param name="tenantId">
        /// The Azure AD tenant ID to use for authentication.
        /// </param>
        /// <param name="clientId">
        /// The Azure AD client ID to use for authentication.
        /// </param>
        /// <param name="clientSecret">
        /// The Azure AD client secret to use for authentication.
        /// </param>
        /// <param name="className">
        /// Default Value: CloudAzStorageBlobDataSource
        /// </param>
        public CloudAzStorageBlobDataSource(
            string containerName,
            string accountUrl,
            bool? supportsAccessControl,
            string? blob,
            string? prefix,
            string? accountName,
            string? accountKey,
            string? tenantId,
            string? clientId,
            string? clientSecret,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.ContainerName = containerName ?? throw new global::System.ArgumentNullException(nameof(containerName));
            this.AccountUrl = accountUrl ?? throw new global::System.ArgumentNullException(nameof(accountUrl));
            this.Blob = blob;
            this.Prefix = prefix;
            this.AccountName = accountName;
            this.AccountKey = accountKey;
            this.TenantId = tenantId;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAzStorageBlobDataSource" /> class.
        /// </summary>
        public CloudAzStorageBlobDataSource()
        {
        }
    }
}