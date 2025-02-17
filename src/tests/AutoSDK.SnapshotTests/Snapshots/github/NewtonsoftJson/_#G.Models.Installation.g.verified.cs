﻿//HintName: G.Models.Installation.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Installation
    /// </summary>
    public sealed partial class Installation
    {
        /// <summary>
        /// The ID of the installation.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.SimpleUser, global::G.Enterprise>? Account { get; set; } = default!;

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InstallationRepositorySelection RepositorySelection { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/app/installations/1/access_tokens
        /// </summary>
        /// <example>https://api.github.com/app/installations/1/access_tokens</example>
        [global::Newtonsoft.Json.JsonProperty("access_tokens_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessTokensUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/installation/repositories
        /// </summary>
        /// <example>https://api.github.com/installation/repositories</example>
        [global::Newtonsoft.Json.JsonProperty("repositories_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoriesUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/organizations/github/settings/installations/1
        /// </summary>
        /// <example>https://github.com/organizations/github/settings/installations/1</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("app_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int AppId { get; set; } = default!;

        /// <summary>
        /// The ID of the user or organization this token is being scoped to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int TargetId { get; set; } = default!;

        /// <summary>
        /// Example: Organization
        /// </summary>
        /// <example>Organization</example>
        [global::Newtonsoft.Json.JsonProperty("target_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetType { get; set; } = default!;

        /// <summary>
        /// The permissions granted to the user access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AppPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Events { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

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
        /// Example: github-actions
        /// </summary>
        /// <example>github-actions</example>
        [global::Newtonsoft.Json.JsonProperty("app_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string AppSlug { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suspended_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? SuspendedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suspended_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? SuspendedAt { get; set; } = default!;

        /// <summary>
        /// Example: "test_13f1e99741e3e004@d7e1eb0bc0a1ba12.com"
        /// </summary>
        /// <example>"test_13f1e99741e3e004@d7e1eb0bc0a1ba12.com"</example>
        [global::Newtonsoft.Json.JsonProperty("contact_email")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Installation" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the installation.<br/>
        /// Example: 1
        /// </param>
        /// <param name="account"></param>
        /// <param name="repositorySelection">
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </param>
        /// <param name="accessTokensUrl">
        /// Example: https://api.github.com/app/installations/1/access_tokens
        /// </param>
        /// <param name="repositoriesUrl">
        /// Example: https://api.github.com/installation/repositories
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/organizations/github/settings/installations/1
        /// </param>
        /// <param name="appId">
        /// Example: 1
        /// </param>
        /// <param name="targetId">
        /// The ID of the user or organization this token is being scoped to.
        /// </param>
        /// <param name="targetType">
        /// Example: Organization
        /// </param>
        /// <param name="permissions">
        /// The permissions granted to the user access token.
        /// </param>
        /// <param name="events"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="singleFileName">
        /// Example: config.yaml
        /// </param>
        /// <param name="hasMultipleSingleFiles">
        /// Example: true
        /// </param>
        /// <param name="singleFilePaths">
        /// Example: [config.yml, .github/issue_TEMPLATE.md]
        /// </param>
        /// <param name="appSlug">
        /// Example: github-actions
        /// </param>
        /// <param name="suspendedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="suspendedAt"></param>
        /// <param name="contactEmail">
        /// Example: "test_13f1e99741e3e004@d7e1eb0bc0a1ba12.com"
        /// </param>
        public Installation(
            int id,
            global::G.AnyOf<global::G.SimpleUser, global::G.Enterprise>? account,
            global::G.InstallationRepositorySelection repositorySelection,
            string accessTokensUrl,
            string repositoriesUrl,
            string htmlUrl,
            int appId,
            int targetId,
            string targetType,
            global::G.AppPermissions permissions,
            global::System.Collections.Generic.IList<string> events,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? singleFileName,
            string appSlug,
            global::G.NullableSimpleUser? suspendedBy,
            global::System.DateTime? suspendedAt,
            bool? hasMultipleSingleFiles,
            global::System.Collections.Generic.IList<string>? singleFilePaths,
            string? contactEmail)
        {
            this.Id = id;
            this.Account = account;
            this.RepositorySelection = repositorySelection;
            this.AccessTokensUrl = accessTokensUrl ?? throw new global::System.ArgumentNullException(nameof(accessTokensUrl));
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.AppId = appId;
            this.TargetId = targetId;
            this.TargetType = targetType ?? throw new global::System.ArgumentNullException(nameof(targetType));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SingleFileName = singleFileName ?? throw new global::System.ArgumentNullException(nameof(singleFileName));
            this.AppSlug = appSlug ?? throw new global::System.ArgumentNullException(nameof(appSlug));
            this.SuspendedBy = suspendedBy ?? throw new global::System.ArgumentNullException(nameof(suspendedBy));
            this.SuspendedAt = suspendedAt;
            this.HasMultipleSingleFiles = hasMultipleSingleFiles;
            this.SingleFilePaths = singleFilePaths;
            this.ContactEmail = contactEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Installation" /> class.
        /// </summary>
        public Installation()
        {
        }
    }
}