//HintName: G.Models.AppPermissions.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("actions")]
        public global::G.AppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("administration")]
        public global::G.AppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for checks on code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checks")]
        public global::G.AppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("codespaces")]
        public global::G.AppPermissionsCodespaces? Codespaces { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public global::G.AppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// The leve of permission to grant the access token to manage Dependabot secrets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot_secrets")]
        public global::G.AppPermissionsDependabotSecrets? DependabotSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for deployments and deployment statuses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployments")]
        public global::G.AppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing repository environments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environments")]
        public global::G.AppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues")]
        public global::G.AppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.AppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for packages published to GitHub Packages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("packages")]
        public global::G.AppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages")]
        public global::G.AppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_requests")]
        public global::G.AppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_custom_properties")]
        public global::G.AppPermissionsRepositoryCustomProperties? RepositoryCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_hooks")]
        public global::G.AppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository projects, columns, and cards.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_projects")]
        public global::G.AppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage secret scanning alerts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning_alerts")]
        public global::G.AppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository secrets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secrets")]
        public global::G.AppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_events")]
        public global::G.AppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage just a single file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("single_file")]
        public global::G.AppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for commit statuses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses")]
        public global::G.AppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage Dependabot alerts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerability_alerts")]
        public global::G.AppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to update GitHub Actions workflow files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflows")]
        public global::G.AppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization teams and members.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members")]
        public global::G.AppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage access to an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_administration")]
        public global::G.AppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom repository roles management.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_custom_roles")]
        public global::G.AppPermissionsOrganizationCustomRoles? OrganizationCustomRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom organization roles management.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_custom_org_roles")]
        public global::G.AppPermissionsOrganizationCustomOrgRoles? OrganizationCustomOrgRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom property management.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_custom_properties")]
        public global::G.AppPermissionsOrganizationCustomProperties? OrganizationCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in beta and is subject to change.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_copilot_seat_management")]
        public global::G.AppPermissionsOrganizationCopilotSeatManagement? OrganizationCopilotSeatManagement { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage announcement banners for an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_announcement_banners")]
        public global::G.AppPermissionsOrganizationAnnouncementBanners? OrganizationAnnouncementBanners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view events triggered by an activity in an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_events")]
        public global::G.AppPermissionsOrganizationEvents? OrganizationEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_hooks")]
        public global::G.AppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access token requests to an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_personal_access_tokens")]
        public global::G.AppPermissionsOrganizationPersonalAccessTokens? OrganizationPersonalAccessTokens { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_personal_access_token_requests")]
        public global::G.AppPermissionsOrganizationPersonalAccessTokenRequests? OrganizationPersonalAccessTokenRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing an organization's plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_plan")]
        public global::G.AppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization projects and projects beta (where available).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_projects")]
        public global::G.AppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization packages published to GitHub Packages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_packages")]
        public global::G.AppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization secrets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_secrets")]
        public global::G.AppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_self_hosted_runners")]
        public global::G.AppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage users blocked by the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_user_blocking")]
        public global::G.AppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage team discussions and related comments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_discussions")]
        public global::G.AppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the email addresses belonging to a user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email_addresses")]
        public global::G.AppPermissionsEmailAddresses? EmailAddresses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the followers belonging to a user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers")]
        public global::G.AppPermissionsFollowers? Followers { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage git SSH keys.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git_ssh_keys")]
        public global::G.AppPermissionsGitSshKeys? GitSshKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gpg_keys")]
        public global::G.AppPermissionsGpgKeys? GpgKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage interaction limits on a repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interaction_limits")]
        public global::G.AppPermissionsInteractionLimits? InteractionLimits { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the profile settings belonging to a user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile")]
        public global::G.AppPermissionsProfile? Profile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to list and manage repositories a user is starring.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starring")]
        public global::G.AppPermissionsStarring? Starring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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