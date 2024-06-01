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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActionsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministrationJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecksJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferencesJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeploymentsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussionsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmailsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironmentsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssuesJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeysJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembersJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadataJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministrationJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooksJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackagesJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlanJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjectsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecretsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlockingJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackagesJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPagesJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequestsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooksJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjectsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEventsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlertJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFileJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatusesJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsTeamDiscussionsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlertsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflowsJsonConverter))]
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}