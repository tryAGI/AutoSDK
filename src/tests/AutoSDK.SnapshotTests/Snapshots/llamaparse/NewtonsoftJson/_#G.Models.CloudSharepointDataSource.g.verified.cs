//HintName: G.Models.CloudSharepointDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudSharepointDataSource
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The name of the SharePoint site to download from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("site_name")]
        public string? SiteName { get; set; }

        /// <summary>
        /// The ID of the SharePoint site to download from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("site_id")]
        public string? SiteId { get; set; }

        /// <summary>
        /// The path of the Sharepoint folder to read from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_path")]
        public string? FolderPath { get; set; }

        /// <summary>
        /// The ID of the Sharepoint folder to read from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// The name of the Sharepoint drive to read from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("drive_name")]
        public string? DriveName { get; set; }

        /// <summary>
        /// The client ID to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// The client secret to use for authentication.<br/>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// The tenant ID to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TenantId { get; set; } = default!;

        /// <summary>
        /// The list of required file extensions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_exts")]
        public global::System.Collections.Generic.IList<string>? RequiredExts { get; set; }

        /// <summary>
        /// Whether to get permissions for the sharepoint site.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("get_permissions")]
        public bool? GetPermissions { get; set; }

        /// <summary>
        /// List of regex patterns for file paths to include. Full paths (including filename) must match at least one pattern to be included. Example: ['/reports/', '/docs/.*\.pdf$', '^Report.*\.pdf$']
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_path_patterns")]
        public global::System.Collections.Generic.IList<string>? IncludePathPatterns { get; set; }

        /// <summary>
        /// List of regex patterns for file paths to exclude. Files whose paths (including filename) match any pattern will be excluded. Example: ['/temp/', '/backup/', '\.git/', '\.tmp$', '^~']
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_path_patterns")]
        public global::System.Collections.Generic.IList<string>? ExcludePathPatterns { get; set; }

        /// <summary>
        /// Default Value: CloudSharepointDataSource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudSharepointDataSource" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The client ID to use for authentication.
        /// </param>
        /// <param name="tenantId">
        /// The tenant ID to use for authentication.
        /// </param>
        /// <param name="supportsAccessControl">
        /// Default Value: true
        /// </param>
        /// <param name="siteName">
        /// The name of the SharePoint site to download from.
        /// </param>
        /// <param name="siteId">
        /// The ID of the SharePoint site to download from.
        /// </param>
        /// <param name="folderPath">
        /// The path of the Sharepoint folder to read from.
        /// </param>
        /// <param name="folderId">
        /// The ID of the Sharepoint folder to read from.
        /// </param>
        /// <param name="driveName">
        /// The name of the Sharepoint drive to read from.
        /// </param>
        /// <param name="clientSecret">
        /// The client secret to use for authentication.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="requiredExts">
        /// The list of required file extensions.
        /// </param>
        /// <param name="getPermissions">
        /// Whether to get permissions for the sharepoint site.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includePathPatterns">
        /// List of regex patterns for file paths to include. Full paths (including filename) must match at least one pattern to be included. Example: ['/reports/', '/docs/.*\.pdf$', '^Report.*\.pdf$']
        /// </param>
        /// <param name="excludePathPatterns">
        /// List of regex patterns for file paths to exclude. Files whose paths (including filename) match any pattern will be excluded. Example: ['/temp/', '/backup/', '\.git/', '\.tmp$', '^~']
        /// </param>
        /// <param name="className">
        /// Default Value: CloudSharepointDataSource
        /// </param>
        public CloudSharepointDataSource(
            string clientId,
            string tenantId,
            bool? supportsAccessControl,
            string? siteName,
            string? siteId,
            string? folderPath,
            string? folderId,
            string? driveName,
            string? clientSecret,
            global::System.Collections.Generic.IList<string>? requiredExts,
            bool? getPermissions,
            global::System.Collections.Generic.IList<string>? includePathPatterns,
            global::System.Collections.Generic.IList<string>? excludePathPatterns,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.SiteName = siteName;
            this.SiteId = siteId;
            this.FolderPath = folderPath;
            this.FolderId = folderId;
            this.DriveName = driveName;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.RequiredExts = requiredExts;
            this.GetPermissions = getPermissions;
            this.IncludePathPatterns = includePathPatterns;
            this.ExcludePathPatterns = excludePathPatterns;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudSharepointDataSource" /> class.
        /// </summary>
        public CloudSharepointDataSource()
        {
        }
    }
}