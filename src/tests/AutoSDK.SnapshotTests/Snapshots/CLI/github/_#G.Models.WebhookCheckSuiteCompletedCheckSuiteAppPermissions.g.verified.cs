//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookCheckSuiteCompletedCheckSuiteAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActionsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministrationJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecksJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferencesJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeploymentsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussionsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmailsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironmentsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssuesJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeysJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembersJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadataJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooksJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackagesJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlanJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjectsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecretsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackagesJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPagesJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequestsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooksJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjectsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEventsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFileJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatusesJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsTeamDiscussionsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflowsJsonConverter))]
        public global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteCompletedCheckSuiteAppPermissions" /> class.
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
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissions(
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActions? actions,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministration? administration,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecks? checks,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferences? contentReferences,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContents? contents,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments? deployments,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussions? discussions,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmails? emails,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironments? environments,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssues? issues,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeys? keys,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembers? members,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadata? metadata,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministration? organizationAdministration,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks? organizationHooks,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackages? organizationPackages,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlan? organizationPlan,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjects? organizationProjects,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecrets? organizationSecrets,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackages? packages,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPages? pages,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequests? pullRequests,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooks? repositoryHooks,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects? repositoryProjects,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets? secrets,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEvents? securityEvents,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFile? singleFile,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatuses? statuses,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsTeamDiscussions? teamDiscussions,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::G.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteCompletedCheckSuiteAppPermissions" /> class.
        /// </summary>
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissions()
        {
        }
    }
}