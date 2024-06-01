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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsActionsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsChecksJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsContentsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsKeysJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsMembersJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsPagesJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsTeamDiscussionsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public WebhooksIssue2PerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}