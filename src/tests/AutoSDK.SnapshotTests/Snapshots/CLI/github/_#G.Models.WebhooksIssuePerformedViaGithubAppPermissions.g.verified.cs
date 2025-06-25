//HintName: G.Models.WebhooksIssuePerformedViaGithubAppPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhooksIssuePerformedViaGithubAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsTeamDiscussionsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::G.WebhooksIssuePerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssuePerformedViaGithubAppPermissions" /> class.
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
        public WebhooksIssuePerformedViaGithubAppPermissions(
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsActions? actions,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsAdministration? administration,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsChecks? checks,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsContentReferences? contentReferences,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsContents? contents,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsDeployments? deployments,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsDiscussions? discussions,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsEmails? emails,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsEnvironments? environments,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsIssues? issues,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsKeys? keys,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsMembers? members,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsMetadata? metadata,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationAdministration? organizationAdministration,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationHooks? organizationHooks,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages? organizationPackages,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPlan? organizationPlan,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationProjects? organizationProjects,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSecrets? organizationSecrets,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsPackages? packages,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsPages? pages,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsPullRequests? pullRequests,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryHooks? repositoryHooks,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects? repositoryProjects,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecrets? secrets,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecurityEvents? securityEvents,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsSingleFile? singleFile,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsStatuses? statuses,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsTeamDiscussions? teamDiscussions,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhooksIssuePerformedViaGithubAppPermissions" /> class.
        /// </summary>
        public WebhooksIssuePerformedViaGithubAppPermissions()
        {
        }
    }
}