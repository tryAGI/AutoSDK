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
        [global::Newtonsoft.Json.JsonProperty("billing_email")]
        public string? BillingEmail { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// The publicly visible email address.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The Twitter username of the company.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// The location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The shorthand name of the company.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the company. The maximum size is 160 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether an organization can use organization projects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_organization_projects")]
        public bool? HasOrganizationProjects { get; set; }

        /// <summary>
        /// Whether repositories that belong to the organization can use repository projects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_repository_projects")]
        public bool? HasRepositoryProjects { get; set; }

        /// <summary>
        /// Default permission level members have for organization repositories.<br/>
        /// Default Value: read
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_repository_permission")]
        public global::G.OrgsUpdateRequestDefaultRepositoryPermission? DefaultRepositoryPermission { get; set; } = global::G.OrgsUpdateRequestDefaultRepositoryPermission.Read;

        /// <summary>
        /// Whether of non-admin organization members can create repositories. **Note:** A parameter can override this parameter. See `members_allowed_repository_creation_type` in this table for details.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_repositories")]
        public bool? MembersCanCreateRepositories { get; set; } = true;

        /// <summary>
        /// Whether organization members can create internal repositories, which are visible to all enterprise members. You can only allow members to create internal repositories if your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see "[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)" in the GitHub Help documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_internal_repositories")]
        public bool? MembersCanCreateInternalRepositories { get; set; }

        /// <summary>
        /// Whether organization members can create private repositories, which are visible to organization members with permission. For more information, see "[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)" in the GitHub Help documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_private_repositories")]
        public bool? MembersCanCreatePrivateRepositories { get; set; }

        /// <summary>
        /// Whether organization members can create public repositories, which are visible to anyone. For more information, see "[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)" in the GitHub Help documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_public_repositories")]
        public bool? MembersCanCreatePublicRepositories { get; set; }

        /// <summary>
        /// Specifies which types of repositories non-admin organization members can create. `private` is only available to repositories that are part of an organization on GitHub Enterprise Cloud. <br/>
        /// **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in `members_can_create_repositories`. See the parameter deprecation notice in the operation description for details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_allowed_repository_creation_type")]
        public global::G.OrgsUpdateRequestMembersAllowedRepositoryCreationType? MembersAllowedRepositoryCreationType { get; set; }

        /// <summary>
        /// Whether organization members can create GitHub Pages sites. Existing published sites will not be impacted.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_pages")]
        public bool? MembersCanCreatePages { get; set; } = true;

        /// <summary>
        /// Whether organization members can create public GitHub Pages sites. Existing published sites will not be impacted.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_public_pages")]
        public bool? MembersCanCreatePublicPages { get; set; } = true;

        /// <summary>
        /// Whether organization members can create private GitHub Pages sites. Existing published sites will not be impacted.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_private_pages")]
        public bool? MembersCanCreatePrivatePages { get; set; } = true;

        /// <summary>
        /// Whether organization members can fork private organization repositories.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_can_fork_private_repositories")]
        public bool? MembersCanForkPrivateRepositories { get; set; } = false;

        /// <summary>
        /// Whether contributors to organization repositories are required to sign off on commits they make through GitHub's web interface.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; } = false;

        /// <summary>
        /// Example: "http://github.blog"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// Whether GitHub Advanced Security is automatically enabled for new repositories.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advanced_security_enabled_for_new_repositories")]
        public bool? AdvancedSecurityEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether Dependabot alerts is automatically enabled for new repositories.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot_alerts_enabled_for_new_repositories")]
        public bool? DependabotAlertsEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether Dependabot security updates is automatically enabled for new repositories.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot_security_updates_enabled_for_new_repositories")]
        public bool? DependabotSecurityUpdatesEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether dependency graph is automatically enabled for new repositories.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency_graph_enabled_for_new_repositories")]
        public bool? DependencyGraphEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether secret scanning is automatically enabled for new repositories.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_enabled_for_new_repositories")]
        public bool? SecretScanningEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether secret scanning push protection is automatically enabled for new repositories.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /orgs/{org}` request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_push_protection_enabled_for_new_repositories")]
        public bool? SecretScanningPushProtectionEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether a custom link is shown to contributors who are blocked from pushing a secret by push protection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_push_protection_custom_link_enabled")]
        public bool? SecretScanningPushProtectionCustomLinkEnabled { get; set; }

        /// <summary>
        /// If `secret_scanning_push_protection_custom_link_enabled` is true, the URL that will be displayed to contributors who are blocked from pushing a secret.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_push_protection_custom_link")]
        public string? SecretScanningPushProtectionCustomLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
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

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.OrgsUpdateRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.OrgsUpdateRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}