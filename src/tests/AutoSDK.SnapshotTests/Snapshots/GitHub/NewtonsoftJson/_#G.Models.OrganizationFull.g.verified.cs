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
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/repos
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReposUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/hooks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HooksUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/issues
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/members{/member}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/public_members{/member}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicMembersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// Example: A great organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Example: github
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: GitHub
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Example: https://github.com/blog
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// Example: San Francisco
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: github
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_verified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_organization_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasOrganizationProjects { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_repository_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasRepositoryProjects { get; set; } = default!;

        /// <summary>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicRepos { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_gists", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicGists { get; set; } = default!;

        /// <summary>
        /// Example: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers", Required = global::Newtonsoft.Json.Required.Always)]
        public int Followers { get; set; } = default!;

        /// <summary>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("following", Required = global::Newtonsoft.Json.Required.Always)]
        public int Following { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: Organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Example: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_private_repos")]
        public int? TotalPrivateRepos { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owned_private_repos")]
        public int? OwnedPrivateRepos { get; set; }

        /// <summary>
        /// Example: 81
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private_gists")]
        public int? PrivateGists { get; set; }

        /// <summary>
        /// Example: 10000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disk_usage")]
        public int? DiskUsage { get; set; }

        /// <summary>
        /// Example: org@example.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_email")]
        public string? BillingEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.OrganizationFullPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_repository_permission")]
        public string? DefaultRepositoryPermission { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_repositories")]
        public bool? MembersCanCreateRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("two_factor_requirement_enabled")]
        public bool? TwoFactorRequirementEnabled { get; set; }

        /// <summary>
        /// Example: all
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_allowed_repository_creation_type")]
        public string? MembersAllowedRepositoryCreationType { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_public_repositories")]
        public bool? MembersCanCreatePublicRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_private_repositories")]
        public bool? MembersCanCreatePrivateRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_internal_repositories")]
        public bool? MembersCanCreateInternalRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_pages")]
        public bool? MembersCanCreatePages { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_public_pages")]
        public bool? MembersCanCreatePublicPages { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_private_pages")]
        public bool? MembersCanCreatePrivatePages { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_fork_private_repositories")]
        public bool? MembersCanForkPrivateRepositories { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether GitHub Advanced Security is enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advanced_security_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? AdvancedSecurityEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether Dependabot alerts are automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot_alerts_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependabotAlertsEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether Dependabot security updates are automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot_security_updates_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependabotSecurityUpdatesEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether dependency graph is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency_graph_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependencyGraphEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether secret scanning is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SecretScanningEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether secret scanning push protection is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_push_protection_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SecretScanningPushProtectionEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether a custom link is shown to contributors who are blocked from pushing a secret by push protection.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_push_protection_custom_link_enabled")]
        public bool? SecretScanningPushProtectionCustomLinkEnabled { get; set; }

        /// <summary>
        /// An optional URL string to display to contributors who are blocked from pushing a secret.<br/>
        /// Example: https://github.com/test-org/test-repo/blob/main/README.md
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_push_protection_custom_link")]
        public string? SecretScanningPushProtectionCustomLink { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ArchivedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
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
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.OrganizationFull>(
                json,
                jsonSerializerOptions);
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
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.OrganizationFull?>(serializer.Deserialize<global::G.OrganizationFull>(jsonReader));
        }

    }
}