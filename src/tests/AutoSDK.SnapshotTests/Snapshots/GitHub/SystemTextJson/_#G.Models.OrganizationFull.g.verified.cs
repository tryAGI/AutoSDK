//HintName: G.Models.OrganizationFull.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organization Full
    /// </summary>
    public sealed partial class OrganizationFull
    {
        /// <summary>
        /// Example: github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/repos
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReposUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/hooks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HooksUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuesUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/members{/member}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembersUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/public_members{/member}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicMembersUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// Example: A great organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// Example: github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: GitHub
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Example: https://github.com/blog
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// Example: San Francisco
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_verified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_organization_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasOrganizationProjects { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_repository_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasRepositoryProjects { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicRepos { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_gists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicGists { get; set; }

        /// <summary>
        /// Example: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Followers { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("following")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Following { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: Organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_private_repos")]
        public int? TotalPrivateRepos { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_private_repos")]
        public int? OwnedPrivateRepos { get; set; }

        /// <summary>
        /// Example: 81
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_gists")]
        public int? PrivateGists { get; set; }

        /// <summary>
        /// Example: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_usage")]
        public int? DiskUsage { get; set; }

        /// <summary>
        /// Example: org@example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_email")]
        public string? BillingEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public global::G.OrganizationFullPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_repository_permission")]
        public string? DefaultRepositoryPermission { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_repositories")]
        public bool? MembersCanCreateRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("two_factor_requirement_enabled")]
        public bool? TwoFactorRequirementEnabled { get; set; }

        /// <summary>
        /// Example: all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_allowed_repository_creation_type")]
        public string? MembersAllowedRepositoryCreationType { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_public_repositories")]
        public bool? MembersCanCreatePublicRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_private_repositories")]
        public bool? MembersCanCreatePrivateRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_internal_repositories")]
        public bool? MembersCanCreateInternalRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_pages")]
        public bool? MembersCanCreatePages { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_public_pages")]
        public bool? MembersCanCreatePublicPages { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_private_pages")]
        public bool? MembersCanCreatePrivatePages { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_fork_private_repositories")]
        public bool? MembersCanForkPrivateRepositories { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether GitHub Advanced Security is enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? AdvancedSecurityEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether Dependabot alerts are automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependabotAlertsEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether Dependabot security updates are automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependabotSecurityUpdatesEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether dependency graph is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependencyGraphEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether secret scanning is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SecretScanningEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether secret scanning push protection is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SecretScanningPushProtectionEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether a custom link is shown to contributors who are blocked from pushing a secret by push protection.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection_custom_link_enabled")]
        public bool? SecretScanningPushProtectionCustomLinkEnabled { get; set; }

        /// <summary>
        /// An optional URL string to display to contributors who are blocked from pushing a secret.<br/>
        /// Example: https://github.com/test-org/test-repo/blob/main/README.md
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection_custom_link")]
        public string? SecretScanningPushProtectionCustomLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.OrganizationFull? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.OrganizationFull),
                jsonSerializerContext) as global::G.OrganizationFull;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.OrganizationFull? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.OrganizationFull>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.OrganizationFull?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.OrganizationFull),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.OrganizationFull;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.OrganizationFull?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.OrganizationFull?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}