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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActionsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministrationJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecksJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferencesJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeploymentsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussionsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmailsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironmentsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssuesJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeysJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembersJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadataJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministrationJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooksJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackagesJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlanJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjectsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecretsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlockingJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackagesJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPagesJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequestsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooksJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjectsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEventsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlertJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFileJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatusesJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsTeamDiscussionsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlertsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflowsJsonConverter))]
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}