//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsTeamDiscussionsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions),
                jsonSerializerContext) as global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}