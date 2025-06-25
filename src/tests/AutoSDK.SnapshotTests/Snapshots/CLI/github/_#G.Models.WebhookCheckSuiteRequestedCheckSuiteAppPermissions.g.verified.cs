//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteAppPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookCheckSuiteRequestedCheckSuiteAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActionsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministrationJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecksJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferencesJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeploymentsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussionsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmailsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironmentsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssuesJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeysJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembersJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadataJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooksJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackagesJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlanJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjectsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecretsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackagesJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPagesJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequestsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooksJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjectsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEventsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFileJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatusesJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsTeamDiscussionsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflowsJsonConverter))]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuiteAppPermissions" /> class.
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
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissions(
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActions? actions,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministration? administration,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecks? checks,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferences? contentReferences,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContents? contents,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeployments? deployments,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions? discussions,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmails? emails,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironments? environments,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssues? issues,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeys? keys,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembers? members,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadata? metadata,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration? organizationAdministration,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooks? organizationHooks,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackages? organizationPackages,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlan? organizationPlan,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjects? organizationProjects,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecrets? organizationSecrets,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackages? packages,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPages? pages,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequests? pullRequests,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooks? repositoryHooks,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects? repositoryProjects,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecrets? secrets,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEvents? securityEvents,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFile? singleFile,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses? statuses,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsTeamDiscussions? teamDiscussions,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuiteAppPermissions" /> class.
        /// </summary>
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissions()
        {
        }
    }
}