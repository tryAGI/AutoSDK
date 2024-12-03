//HintName: G.Models.InstallationToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication token for a GitHub App installed on a user or org.
    /// </summary>
    public sealed partial class InstallationToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The permissions granted to the user access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::G.AppPermissions? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection")]
        public global::G.InstallationTokenRepositorySelection? RepositorySelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories")]
        public global::System.Collections.Generic.IList<global::G.Repository>? Repositories { get; set; }

        /// <summary>
        /// Example: README.md
        /// </summary>
        /// <example>README.md</example>
        [global::Newtonsoft.Json.JsonProperty("single_file")]
        public string? SingleFile { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("has_multiple_single_files")]
        public bool? HasMultipleSingleFiles { get; set; }

        /// <summary>
        /// Example: [config.yml, .github/issue_TEMPLATE.md]
        /// </summary>
        /// <example>[config.yml, .github/issue_TEMPLATE.md]</example>
        [global::Newtonsoft.Json.JsonProperty("single_file_paths")]
        public global::System.Collections.Generic.IList<string>? SingleFilePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationToken" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="expiresAt"></param>
        /// <param name="permissions">
        /// The permissions granted to the user access token.
        /// </param>
        /// <param name="repositorySelection"></param>
        /// <param name="repositories"></param>
        /// <param name="singleFile">
        /// Example: README.md
        /// </param>
        /// <param name="hasMultipleSingleFiles">
        /// Example: true
        /// </param>
        /// <param name="singleFilePaths">
        /// Example: [config.yml, .github/issue_TEMPLATE.md]
        /// </param>
        public InstallationToken(
            string token,
            string expiresAt,
            global::G.AppPermissions? permissions,
            global::G.InstallationTokenRepositorySelection? repositorySelection,
            global::System.Collections.Generic.IList<global::G.Repository>? repositories,
            string? singleFile,
            bool? hasMultipleSingleFiles,
            global::System.Collections.Generic.IList<string>? singleFilePaths)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.Permissions = permissions;
            this.RepositorySelection = repositorySelection;
            this.Repositories = repositories;
            this.SingleFile = singleFile;
            this.HasMultipleSingleFiles = hasMultipleSingleFiles;
            this.SingleFilePaths = singleFilePaths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationToken" /> class.
        /// </summary>
        public InstallationToken()
        {
        }
    }
}