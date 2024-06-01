//HintName: G.Models.AppPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions granted to the user access token.
    /// <br/>Example: 
    /// </summary>
    public sealed partial class AppPermissions
    {
        /// <summary>
        /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsActionsJsonConverter))]
        public AppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsAdministrationJsonConverter))]
        public AppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for checks on code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsChecksJsonConverter))]
        public AppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codespaces")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsCodespacesJsonConverter))]
        public AppPermissionsCodespaces? Codespaces { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsContentsJsonConverter))]
        public AppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// The leve of permission to grant the access token to manage Dependabot secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsDependabotSecretsJsonConverter))]
        public AppPermissionsDependabotSecrets? DependabotSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for deployments and deployment statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsDeploymentsJsonConverter))]
        public AppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing repository environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsEnvironmentsJsonConverter))]
        public AppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsIssuesJsonConverter))]
        public AppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsMetadataJsonConverter))]
        public AppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for packages published to GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsPackagesJsonConverter))]
        public AppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsPagesJsonConverter))]
        public AppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsPullRequestsJsonConverter))]
        public AppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_custom_properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsRepositoryCustomPropertiesJsonConverter))]
        public AppPermissionsRepositoryCustomProperties? RepositoryCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsRepositoryHooksJsonConverter))]
        public AppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository projects, columns, and cards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsRepositoryProjectsJsonConverter))]
        public AppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage secret scanning alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsSecretScanningAlertsJsonConverter))]
        public AppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsSecretsJsonConverter))]
        public AppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsSecurityEventsJsonConverter))]
        public AppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage just a single file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsSingleFileJsonConverter))]
        public AppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for commit statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsStatusesJsonConverter))]
        public AppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage Dependabot alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsVulnerabilityAlertsJsonConverter))]
        public AppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to update GitHub Actions workflow files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsWorkflowsJsonConverter))]
        public AppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization teams and members.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsMembersJsonConverter))]
        public AppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage access to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationAdministrationJsonConverter))]
        public AppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom repository roles management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_roles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationCustomRolesJsonConverter))]
        public AppPermissionsOrganizationCustomRoles? OrganizationCustomRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom organization roles management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_org_roles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationCustomOrgRolesJsonConverter))]
        public AppPermissionsOrganizationCustomOrgRoles? OrganizationCustomOrgRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom property management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationCustomPropertiesJsonConverter))]
        public AppPermissionsOrganizationCustomProperties? OrganizationCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in beta and is subject to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_copilot_seat_management")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationCopilotSeatManagementJsonConverter))]
        public AppPermissionsOrganizationCopilotSeatManagement? OrganizationCopilotSeatManagement { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage announcement banners for an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_announcement_banners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationAnnouncementBannersJsonConverter))]
        public AppPermissionsOrganizationAnnouncementBanners? OrganizationAnnouncementBanners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view events triggered by an activity in an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationEventsJsonConverter))]
        public AppPermissionsOrganizationEvents? OrganizationEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationHooksJsonConverter))]
        public AppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access token requests to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_personal_access_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationPersonalAccessTokensJsonConverter))]
        public AppPermissionsOrganizationPersonalAccessTokens? OrganizationPersonalAccessTokens { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_personal_access_token_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationPersonalAccessTokenRequestsJsonConverter))]
        public AppPermissionsOrganizationPersonalAccessTokenRequests? OrganizationPersonalAccessTokenRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing an organization's plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationPlanJsonConverter))]
        public AppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization projects and projects beta (where available).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationProjectsJsonConverter))]
        public AppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization packages published to GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationPackagesJsonConverter))]
        public AppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationSecretsJsonConverter))]
        public AppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public AppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage users blocked by the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsOrganizationUserBlockingJsonConverter))]
        public AppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage team discussions and related comments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsTeamDiscussionsJsonConverter))]
        public AppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the email addresses belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_addresses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsEmailAddressesJsonConverter))]
        public AppPermissionsEmailAddresses? EmailAddresses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the followers belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsFollowersJsonConverter))]
        public AppPermissionsFollowers? Followers { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage git SSH keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_ssh_keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsGitSshKeysJsonConverter))]
        public AppPermissionsGitSshKeys? GitSshKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpg_keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsGpgKeysJsonConverter))]
        public AppPermissionsGpgKeys? GpgKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage interaction limits on a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction_limits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsInteractionLimitsJsonConverter))]
        public AppPermissionsInteractionLimits? InteractionLimits { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the profile settings belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsProfileJsonConverter))]
        public AppPermissionsProfile? Profile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to list and manage repositories a user is starring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starring")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AppPermissionsStarringJsonConverter))]
        public AppPermissionsStarring? Starring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}