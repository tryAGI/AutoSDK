//HintName: G.Models.WebhooksIssue2PerformedViaGithubAppPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhooksIssue2PerformedViaGithubAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsTeamDiscussionsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::G.WebhooksIssue2PerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssue2PerformedViaGithubAppPermissions" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="administration"></param>
        /// <param name="checks"></param>
        /// <param name="contentReferences"></param>
        /// <param name="contents"></param>
        /// <param name="deployments"></param>
        /// <param name="discussions"></param>
        /// <param name="emails"></param>
        /// <param name="environments"></param>
        /// <param name="issues"></param>
        /// <param name="keys"></param>
        /// <param name="members"></param>
        /// <param name="metadata"></param>
        /// <param name="organizationAdministration"></param>
        /// <param name="organizationHooks"></param>
        /// <param name="organizationPackages"></param>
        /// <param name="organizationPlan"></param>
        /// <param name="organizationProjects"></param>
        /// <param name="organizationSecrets"></param>
        /// <param name="organizationSelfHostedRunners"></param>
        /// <param name="organizationUserBlocking"></param>
        /// <param name="packages"></param>
        /// <param name="pages"></param>
        /// <param name="pullRequests"></param>
        /// <param name="repositoryHooks"></param>
        /// <param name="repositoryProjects"></param>
        /// <param name="secretScanningAlerts"></param>
        /// <param name="secrets"></param>
        /// <param name="securityEvents"></param>
        /// <param name="securityScanningAlert"></param>
        /// <param name="singleFile"></param>
        /// <param name="statuses"></param>
        /// <param name="teamDiscussions"></param>
        /// <param name="vulnerabilityAlerts"></param>
        /// <param name="workflows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksIssue2PerformedViaGithubAppPermissions(
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsActions? actions,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsAdministration? administration,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsChecks? checks,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsContentReferences? contentReferences,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsContents? contents,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsDeployments? deployments,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsDiscussions? discussions,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsEmails? emails,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsEnvironments? environments,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsIssues? issues,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsKeys? keys,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsMembers? members,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsMetadata? metadata,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationAdministration? organizationAdministration,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks? organizationHooks,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPackages? organizationPackages,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPlan? organizationPlan,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationProjects? organizationProjects,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets? organizationSecrets,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPackages? packages,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPages? pages,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequests? pullRequests,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryHooks? repositoryHooks,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects? repositoryProjects,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSecrets? secrets,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSecurityEvents? securityEvents,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile? singleFile,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsStatuses? statuses,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsTeamDiscussions? teamDiscussions,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsWorkflows? workflows)
        {
            this.Actions = actions;
            this.Administration = administration;
            this.Checks = checks;
            this.ContentReferences = contentReferences;
            this.Contents = contents;
            this.Deployments = deployments;
            this.Discussions = discussions;
            this.Emails = emails;
            this.Environments = environments;
            this.Issues = issues;
            this.Keys = keys;
            this.Members = members;
            this.Metadata = metadata;
            this.OrganizationAdministration = organizationAdministration;
            this.OrganizationHooks = organizationHooks;
            this.OrganizationPackages = organizationPackages;
            this.OrganizationPlan = organizationPlan;
            this.OrganizationProjects = organizationProjects;
            this.OrganizationSecrets = organizationSecrets;
            this.OrganizationSelfHostedRunners = organizationSelfHostedRunners;
            this.OrganizationUserBlocking = organizationUserBlocking;
            this.Packages = packages;
            this.Pages = pages;
            this.PullRequests = pullRequests;
            this.RepositoryHooks = repositoryHooks;
            this.RepositoryProjects = repositoryProjects;
            this.SecretScanningAlerts = secretScanningAlerts;
            this.Secrets = secrets;
            this.SecurityEvents = securityEvents;
            this.SecurityScanningAlert = securityScanningAlert;
            this.SingleFile = singleFile;
            this.Statuses = statuses;
            this.TeamDiscussions = teamDiscussions;
            this.VulnerabilityAlerts = vulnerabilityAlerts;
            this.Workflows = workflows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssue2PerformedViaGithubAppPermissions" /> class.
        /// </summary>
        public WebhooksIssue2PerformedViaGithubAppPermissions()
        {
        }
    }
}