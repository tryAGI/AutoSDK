//HintName: G.Models.NullableScopedInstallation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NullableScopedInstallation
    {
        /// <summary>
        /// The permissions granted to the user access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AppPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableScopedInstallationRepositorySelection RepositorySelection { get; set; } = default!;

        /// <summary>
        /// Example: config.yaml
        /// </summary>
        /// <example>config.yaml</example>
        [global::Newtonsoft.Json.JsonProperty("single_file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? SingleFileName { get; set; } = default!;

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
        /// Example: https://api.github.com/users/octocat/repos
        /// </summary>
        /// <example>https://api.github.com/users/octocat/repos</example>
        [global::Newtonsoft.Json.JsonProperty("repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Account { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableScopedInstallation" /> class.
        /// </summary>
        /// <param name="permissions">
        /// The permissions granted to the user access token.
        /// </param>
        /// <param name="repositorySelection">
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </param>
        /// <param name="singleFileName">
        /// Example: config.yaml
        /// </param>
        /// <param name="hasMultipleSingleFiles">
        /// Example: true
        /// </param>
        /// <param name="singleFilePaths">
        /// Example: [config.yml, .github/issue_TEMPLATE.md]
        /// </param>
        /// <param name="repositoriesUrl">
        /// Example: https://api.github.com/users/octocat/repos
        /// </param>
        /// <param name="account">
        /// A GitHub user.
        /// </param>
        public NullableScopedInstallation(
            global::G.AppPermissions permissions,
            global::G.NullableScopedInstallationRepositorySelection repositorySelection,
            string? singleFileName,
            string repositoriesUrl,
            global::G.SimpleUser account,
            bool? hasMultipleSingleFiles,
            global::System.Collections.Generic.IList<string>? singleFilePaths)
        {
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.RepositorySelection = repositorySelection;
            this.SingleFileName = singleFileName ?? throw new global::System.ArgumentNullException(nameof(singleFileName));
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.HasMultipleSingleFiles = hasMultipleSingleFiles;
            this.SingleFilePaths = singleFilePaths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableScopedInstallation" /> class.
        /// </summary>
        public NullableScopedInstallation()
        {
        }
    }
}