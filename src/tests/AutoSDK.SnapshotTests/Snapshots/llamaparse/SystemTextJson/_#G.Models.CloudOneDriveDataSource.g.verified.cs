//HintName: G.Models.CloudOneDriveDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudOneDriveDataSource
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The user principal name to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_principal_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrincipalName { get; set; }

        /// <summary>
        /// The path of the OneDrive folder to read from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_path")]
        public string? FolderPath { get; set; }

        /// <summary>
        /// The ID of the OneDrive folder to read from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// The client ID to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// The client secret to use for authentication.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// The tenant ID to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// The list of required file extensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_exts")]
        public global::System.Collections.Generic.IList<string>? RequiredExts { get; set; }

        /// <summary>
        /// Default Value: CloudOneDriveDataSource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudOneDriveDataSource" /> class.
        /// </summary>
        /// <param name="userPrincipalName">
        /// The user principal name to use for authentication.
        /// </param>
        /// <param name="clientId">
        /// The client ID to use for authentication.
        /// </param>
        /// <param name="tenantId">
        /// The tenant ID to use for authentication.
        /// </param>
        /// <param name="supportsAccessControl">
        /// Default Value: true
        /// </param>
        /// <param name="folderPath">
        /// The path of the OneDrive folder to read from.
        /// </param>
        /// <param name="folderId">
        /// The ID of the OneDrive folder to read from.
        /// </param>
        /// <param name="clientSecret">
        /// The client secret to use for authentication.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="requiredExts">
        /// The list of required file extensions.
        /// </param>
        /// <param name="className">
        /// Default Value: CloudOneDriveDataSource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudOneDriveDataSource(
            string userPrincipalName,
            string clientId,
            string tenantId,
            bool? supportsAccessControl,
            string? folderPath,
            string? folderId,
            string? clientSecret,
            global::System.Collections.Generic.IList<string>? requiredExts,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.UserPrincipalName = userPrincipalName ?? throw new global::System.ArgumentNullException(nameof(userPrincipalName));
            this.FolderPath = folderPath;
            this.FolderId = folderId;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.RequiredExts = requiredExts;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudOneDriveDataSource" /> class.
        /// </summary>
        public CloudOneDriveDataSource()
        {
        }
    }
}