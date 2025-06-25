﻿//HintName: G.Models.AppPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions granted to the user access token.
    /// </summary>
    public sealed partial class AppPermissions
    {
        /// <summary>
        /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsActionsJsonConverter))]
        public global::G.AppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsAdministrationJsonConverter))]
        public global::G.AppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for checks on code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsChecksJsonConverter))]
        public global::G.AppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codespaces")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsCodespacesJsonConverter))]
        public global::G.AppPermissionsCodespaces? Codespaces { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsContentsJsonConverter))]
        public global::G.AppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// The leve of permission to grant the access token to manage Dependabot secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsDependabotSecretsJsonConverter))]
        public global::G.AppPermissionsDependabotSecrets? DependabotSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for deployments and deployment statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsDeploymentsJsonConverter))]
        public global::G.AppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing repository environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsEnvironmentsJsonConverter))]
        public global::G.AppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsIssuesJsonConverter))]
        public global::G.AppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsMetadataJsonConverter))]
        public global::G.AppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for packages published to GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsPackagesJsonConverter))]
        public global::G.AppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsPagesJsonConverter))]
        public global::G.AppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsPullRequestsJsonConverter))]
        public global::G.AppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_custom_properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsRepositoryCustomPropertiesJsonConverter))]
        public global::G.AppPermissionsRepositoryCustomProperties? RepositoryCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsRepositoryHooksJsonConverter))]
        public global::G.AppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository projects, columns, and cards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsRepositoryProjectsJsonConverter))]
        public global::G.AppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage secret scanning alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsSecretScanningAlertsJsonConverter))]
        public global::G.AppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsSecretsJsonConverter))]
        public global::G.AppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsSecurityEventsJsonConverter))]
        public global::G.AppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage just a single file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsSingleFileJsonConverter))]
        public global::G.AppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for commit statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsStatusesJsonConverter))]
        public global::G.AppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage Dependabot alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::G.AppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to update GitHub Actions workflow files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsWorkflowsJsonConverter))]
        public global::G.AppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization teams and members.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsMembersJsonConverter))]
        public global::G.AppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage access to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationAdministrationJsonConverter))]
        public global::G.AppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom repository roles management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_roles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationCustomRolesJsonConverter))]
        public global::G.AppPermissionsOrganizationCustomRoles? OrganizationCustomRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom organization roles management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_org_roles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationCustomOrgRolesJsonConverter))]
        public global::G.AppPermissionsOrganizationCustomOrgRoles? OrganizationCustomOrgRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom property management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationCustomPropertiesJsonConverter))]
        public global::G.AppPermissionsOrganizationCustomProperties? OrganizationCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in beta and is subject to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_copilot_seat_management")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationCopilotSeatManagementJsonConverter))]
        public global::G.AppPermissionsOrganizationCopilotSeatManagement? OrganizationCopilotSeatManagement { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage announcement banners for an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_announcement_banners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationAnnouncementBannersJsonConverter))]
        public global::G.AppPermissionsOrganizationAnnouncementBanners? OrganizationAnnouncementBanners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view events triggered by an activity in an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationEventsJsonConverter))]
        public global::G.AppPermissionsOrganizationEvents? OrganizationEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationHooksJsonConverter))]
        public global::G.AppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access token requests to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_personal_access_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationPersonalAccessTokensJsonConverter))]
        public global::G.AppPermissionsOrganizationPersonalAccessTokens? OrganizationPersonalAccessTokens { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_personal_access_token_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationPersonalAccessTokenRequestsJsonConverter))]
        public global::G.AppPermissionsOrganizationPersonalAccessTokenRequests? OrganizationPersonalAccessTokenRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing an organization's plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationPlanJsonConverter))]
        public global::G.AppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization projects and projects beta (where available).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationProjectsJsonConverter))]
        public global::G.AppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization packages published to GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationPackagesJsonConverter))]
        public global::G.AppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationSecretsJsonConverter))]
        public global::G.AppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::G.AppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage users blocked by the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::G.AppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage team discussions and related comments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsTeamDiscussionsJsonConverter))]
        public global::G.AppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the email addresses belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_addresses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsEmailAddressesJsonConverter))]
        public global::G.AppPermissionsEmailAddresses? EmailAddresses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the followers belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsFollowersJsonConverter))]
        public global::G.AppPermissionsFollowers? Followers { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage git SSH keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_ssh_keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsGitSshKeysJsonConverter))]
        public global::G.AppPermissionsGitSshKeys? GitSshKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpg_keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsGpgKeysJsonConverter))]
        public global::G.AppPermissionsGpgKeys? GpgKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage interaction limits on a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction_limits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsInteractionLimitsJsonConverter))]
        public global::G.AppPermissionsInteractionLimits? InteractionLimits { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the profile settings belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsProfileJsonConverter))]
        public global::G.AppPermissionsProfile? Profile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to list and manage repositories a user is starring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starring")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppPermissionsStarringJsonConverter))]
        public global::G.AppPermissionsStarring? Starring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPermissions" /> class.
        /// </summary>
        /// <param name="actions">
        /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
        /// </param>
        /// <param name="administration">
        /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
        /// </param>
        /// <param name="checks">
        /// The level of permission to grant the access token for checks on code.
        /// </param>
        /// <param name="codespaces">
        /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
        /// </param>
        /// <param name="contents">
        /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
        /// </param>
        /// <param name="dependabotSecrets">
        /// The leve of permission to grant the access token to manage Dependabot secrets.
        /// </param>
        /// <param name="deployments">
        /// The level of permission to grant the access token for deployments and deployment statuses.
        /// </param>
        /// <param name="environments">
        /// The level of permission to grant the access token for managing repository environments.
        /// </param>
        /// <param name="issues">
        /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
        /// </param>
        /// <param name="metadata">
        /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
        /// </param>
        /// <param name="packages">
        /// The level of permission to grant the access token for packages published to GitHub Packages.
        /// </param>
        /// <param name="pages">
        /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
        /// </param>
        /// <param name="pullRequests">
        /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
        /// </param>
        /// <param name="repositoryCustomProperties">
        /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
        /// </param>
        /// <param name="repositoryHooks">
        /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
        /// </param>
        /// <param name="repositoryProjects">
        /// The level of permission to grant the access token to manage repository projects, columns, and cards.
        /// </param>
        /// <param name="secretScanningAlerts">
        /// The level of permission to grant the access token to view and manage secret scanning alerts.
        /// </param>
        /// <param name="secrets">
        /// The level of permission to grant the access token to manage repository secrets.
        /// </param>
        /// <param name="securityEvents">
        /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
        /// </param>
        /// <param name="singleFile">
        /// The level of permission to grant the access token to manage just a single file.
        /// </param>
        /// <param name="statuses">
        /// The level of permission to grant the access token for commit statuses.
        /// </param>
        /// <param name="vulnerabilityAlerts">
        /// The level of permission to grant the access token to manage Dependabot alerts.
        /// </param>
        /// <param name="workflows">
        /// The level of permission to grant the access token to update GitHub Actions workflow files.
        /// </param>
        /// <param name="members">
        /// The level of permission to grant the access token for organization teams and members.
        /// </param>
        /// <param name="organizationAdministration">
        /// The level of permission to grant the access token to manage access to an organization.
        /// </param>
        /// <param name="organizationCustomRoles">
        /// The level of permission to grant the access token for custom repository roles management.
        /// </param>
        /// <param name="organizationCustomOrgRoles">
        /// The level of permission to grant the access token for custom organization roles management.
        /// </param>
        /// <param name="organizationCustomProperties">
        /// The level of permission to grant the access token for custom property management.
        /// </param>
        /// <param name="organizationCopilotSeatManagement">
        /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in beta and is subject to change.
        /// </param>
        /// <param name="organizationAnnouncementBanners">
        /// The level of permission to grant the access token to view and manage announcement banners for an organization.
        /// </param>
        /// <param name="organizationEvents">
        /// The level of permission to grant the access token to view events triggered by an activity in an organization.
        /// </param>
        /// <param name="organizationHooks">
        /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
        /// </param>
        /// <param name="organizationPersonalAccessTokens">
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access token requests to an organization.
        /// </param>
        /// <param name="organizationPersonalAccessTokenRequests">
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
        /// </param>
        /// <param name="organizationPlan">
        /// The level of permission to grant the access token for viewing an organization's plan.
        /// </param>
        /// <param name="organizationProjects">
        /// The level of permission to grant the access token to manage organization projects and projects beta (where available).
        /// </param>
        /// <param name="organizationPackages">
        /// The level of permission to grant the access token for organization packages published to GitHub Packages.
        /// </param>
        /// <param name="organizationSecrets">
        /// The level of permission to grant the access token to manage organization secrets.
        /// </param>
        /// <param name="organizationSelfHostedRunners">
        /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
        /// </param>
        /// <param name="organizationUserBlocking">
        /// The level of permission to grant the access token to view and manage users blocked by the organization.
        /// </param>
        /// <param name="teamDiscussions">
        /// The level of permission to grant the access token to manage team discussions and related comments.
        /// </param>
        /// <param name="emailAddresses">
        /// The level of permission to grant the access token to manage the email addresses belonging to a user.
        /// </param>
        /// <param name="followers">
        /// The level of permission to grant the access token to manage the followers belonging to a user.
        /// </param>
        /// <param name="gitSshKeys">
        /// The level of permission to grant the access token to manage git SSH keys.
        /// </param>
        /// <param name="gpgKeys">
        /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
        /// </param>
        /// <param name="interactionLimits">
        /// The level of permission to grant the access token to view and manage interaction limits on a repository.
        /// </param>
        /// <param name="profile">
        /// The level of permission to grant the access token to manage the profile settings belonging to a user.
        /// </param>
        /// <param name="starring">
        /// The level of permission to grant the access token to list and manage repositories a user is starring.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPermissions(
            global::G.AppPermissionsActions? actions,
            global::G.AppPermissionsAdministration? administration,
            global::G.AppPermissionsChecks? checks,
            global::G.AppPermissionsCodespaces? codespaces,
            global::G.AppPermissionsContents? contents,
            global::G.AppPermissionsDependabotSecrets? dependabotSecrets,
            global::G.AppPermissionsDeployments? deployments,
            global::G.AppPermissionsEnvironments? environments,
            global::G.AppPermissionsIssues? issues,
            global::G.AppPermissionsMetadata? metadata,
            global::G.AppPermissionsPackages? packages,
            global::G.AppPermissionsPages? pages,
            global::G.AppPermissionsPullRequests? pullRequests,
            global::G.AppPermissionsRepositoryCustomProperties? repositoryCustomProperties,
            global::G.AppPermissionsRepositoryHooks? repositoryHooks,
            global::G.AppPermissionsRepositoryProjects? repositoryProjects,
            global::G.AppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::G.AppPermissionsSecrets? secrets,
            global::G.AppPermissionsSecurityEvents? securityEvents,
            global::G.AppPermissionsSingleFile? singleFile,
            global::G.AppPermissionsStatuses? statuses,
            global::G.AppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::G.AppPermissionsWorkflows? workflows,
            global::G.AppPermissionsMembers? members,
            global::G.AppPermissionsOrganizationAdministration? organizationAdministration,
            global::G.AppPermissionsOrganizationCustomRoles? organizationCustomRoles,
            global::G.AppPermissionsOrganizationCustomOrgRoles? organizationCustomOrgRoles,
            global::G.AppPermissionsOrganizationCustomProperties? organizationCustomProperties,
            global::G.AppPermissionsOrganizationCopilotSeatManagement? organizationCopilotSeatManagement,
            global::G.AppPermissionsOrganizationAnnouncementBanners? organizationAnnouncementBanners,
            global::G.AppPermissionsOrganizationEvents? organizationEvents,
            global::G.AppPermissionsOrganizationHooks? organizationHooks,
            global::G.AppPermissionsOrganizationPersonalAccessTokens? organizationPersonalAccessTokens,
            global::G.AppPermissionsOrganizationPersonalAccessTokenRequests? organizationPersonalAccessTokenRequests,
            global::G.AppPermissionsOrganizationPlan? organizationPlan,
            global::G.AppPermissionsOrganizationProjects? organizationProjects,
            global::G.AppPermissionsOrganizationPackages? organizationPackages,
            global::G.AppPermissionsOrganizationSecrets? organizationSecrets,
            global::G.AppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::G.AppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::G.AppPermissionsTeamDiscussions? teamDiscussions,
            global::G.AppPermissionsEmailAddresses? emailAddresses,
            global::G.AppPermissionsFollowers? followers,
            global::G.AppPermissionsGitSshKeys? gitSshKeys,
            global::G.AppPermissionsGpgKeys? gpgKeys,
            global::G.AppPermissionsInteractionLimits? interactionLimits,
            global::G.AppPermissionsProfile? profile,
            global::G.AppPermissionsStarring? starring)
        {
            this.Actions = actions;
            this.Administration = administration;
            this.Checks = checks;
            this.Codespaces = codespaces;
            this.Contents = contents;
            this.DependabotSecrets = dependabotSecrets;
            this.Deployments = deployments;
            this.Environments = environments;
            this.Issues = issues;
            this.Metadata = metadata;
            this.Packages = packages;
            this.Pages = pages;
            this.PullRequests = pullRequests;
            this.RepositoryCustomProperties = repositoryCustomProperties;
            this.RepositoryHooks = repositoryHooks;
            this.RepositoryProjects = repositoryProjects;
            this.SecretScanningAlerts = secretScanningAlerts;
            this.Secrets = secrets;
            this.SecurityEvents = securityEvents;
            this.SingleFile = singleFile;
            this.Statuses = statuses;
            this.VulnerabilityAlerts = vulnerabilityAlerts;
            this.Workflows = workflows;
            this.Members = members;
            this.OrganizationAdministration = organizationAdministration;
            this.OrganizationCustomRoles = organizationCustomRoles;
            this.OrganizationCustomOrgRoles = organizationCustomOrgRoles;
            this.OrganizationCustomProperties = organizationCustomProperties;
            this.OrganizationCopilotSeatManagement = organizationCopilotSeatManagement;
            this.OrganizationAnnouncementBanners = organizationAnnouncementBanners;
            this.OrganizationEvents = organizationEvents;
            this.OrganizationHooks = organizationHooks;
            this.OrganizationPersonalAccessTokens = organizationPersonalAccessTokens;
            this.OrganizationPersonalAccessTokenRequests = organizationPersonalAccessTokenRequests;
            this.OrganizationPlan = organizationPlan;
            this.OrganizationProjects = organizationProjects;
            this.OrganizationPackages = organizationPackages;
            this.OrganizationSecrets = organizationSecrets;
            this.OrganizationSelfHostedRunners = organizationSelfHostedRunners;
            this.OrganizationUserBlocking = organizationUserBlocking;
            this.TeamDiscussions = teamDiscussions;
            this.EmailAddresses = emailAddresses;
            this.Followers = followers;
            this.GitSshKeys = gitSshKeys;
            this.GpgKeys = gpgKeys;
            this.InteractionLimits = interactionLimits;
            this.Profile = profile;
            this.Starring = starring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPermissions" /> class.
        /// </summary>
        public AppPermissions()
        {
        }
    }
}