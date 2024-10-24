//HintName: G.Models.OrgsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsUpdateRequest
    {
        /// <summary>
        /// Billing email address. This address is not publicized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_email")]
        public string? BillingEmail { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// The publicly visible email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The Twitter username of the company.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// The location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The shorthand name of the company.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the company. The maximum size is 160 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether an organization can use organization projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_organization_projects")]
        public bool? HasOrganizationProjects { get; set; }

        /// <summary>
        /// Whether repositories that belong to the organization can use repository projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_repository_projects")]
        public bool? HasRepositoryProjects { get; set; }

        /// <summary>
        /// Default permission level members have for organization repositories.<br/>
        /// Default Value: read
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_repository_permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgsUpdateRequestDefaultRepositoryPermissionJsonConverter))]
        public global::G.OrgsUpdateRequestDefaultRepositoryPermission? DefaultRepositoryPermission { get; set; }

        /// <summary>
        /// Whether of non-admin organization members can create repositories. **Note:** A parameter can override this parameter. See `members_allowed_repository_creation_type` in this table for details.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_repositories")]
        public bool? MembersCanCreateRepositories { get; set; }

        /// <summary>
        /// Whether organization members can create internal repositories, which are visible to all enterprise members. You can only allow members to create internal repositories if your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see "[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)" in the GitHub Help documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_internal_repositories")]
        public bool? MembersCanCreateInternalRepositories { get; set; }

        /// <summary>
        /// Whether organization members can create private repositories, which are visible to organization members with permission. For more information, see "[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)" in the GitHub Help documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_private_repositories")]
        public bool? MembersCanCreatePrivateRepositories { get; set; }

        /// <summary>
        /// Whether organization members can create public repositories, which are visible to anyone. For more information, see "[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)" in the GitHub Help documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_public_repositories")]
        public bool? MembersCanCreatePublicRepositories { get; set; }

        /// <summary>
        /// Specifies which types of repositories non-admin organization members can create. `private` is only available to repositories that are part of an organization on GitHub Enterprise Cloud. <br/>
        /// **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in `members_can_create_repositories`. See the parameter deprecation notice in the operation description for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_allowed_repository_creation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgsUpdateRequestMembersAllowedRepositoryCreationTypeJsonConverter))]
        public global::G.OrgsUpdateRequestMembersAllowedRepositoryCreationType? MembersAllowedRepositoryCreationType { get; set; }

        /// <summary>
        /// Whether organization members can create GitHub Pages sites. Existing published sites will not be impacted.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_pages")]
        public bool? MembersCanCreatePages { get; set; }

        /// <summary>
        /// Whether organization members can create public GitHub Pages sites. Existing published sites will not be impacted.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_public_pages")]
        public bool? MembersCanCreatePublicPages { get; set; }

        /// <summary>
        /// Whether organization members can create private GitHub Pages sites. Existing published sites will not be impacted.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_private_pages")]
        public bool? MembersCanCreatePrivatePages { get; set; }

        /// <summary>
        /// Whether organization members can fork private organization repositories.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_fork_private_repositories")]
        public bool? MembersCanForkPrivateRepositories { get; set; }

        /// <summary>
        /// Whether contributors to organization repositories are required to sign off on commits they make through GitHub's web interface.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// Example: "http://github.blog"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether GitHub Advanced Security is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? AdvancedSecurityEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether Dependabot alerts are automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependabotAlertsEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether Dependabot security updates are automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependabotSecurityUpdatesEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether dependency graph is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependencyGraphEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether secret scanning is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SecretScanningEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether secret scanning push protection is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SecretScanningPushProtectionEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether a custom link is shown to contributors who are blocked from pushing a secret by push protection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection_custom_link_enabled")]
        public bool? SecretScanningPushProtectionCustomLinkEnabled { get; set; }

        /// <summary>
        /// If `secret_scanning_push_protection_custom_link_enabled` is true, the URL that will be displayed to contributors who are blocked from pushing a secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection_custom_link")]
        public string? SecretScanningPushProtectionCustomLink { get; set; }

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
        public static global::G.OrgsUpdateRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.OrgsUpdateRequest),
                jsonSerializerContext) as global::G.OrgsUpdateRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.OrgsUpdateRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.OrgsUpdateRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}