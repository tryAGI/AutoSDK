//HintName: G.Models.PipelinesGetPipelineResponsePipeline.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesGetPipelineResponsePipeline
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_id")]
        public string? IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PipelinesGetPipelineResponsePipelineIntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PipelinesGetPipelineResponsePipelineIntegrationType IntegrationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feed_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Config7JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Config7 Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_scheduled_at")]
        public global::System.DateTime? NextScheduledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_at")]
        public global::System.DateTime? LastRunAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_at")]
        public global::System.DateTime? DisabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_display_name")]
        public string? IntegrationDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feed_name")]
        public string? FeedName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber_count")]
        public double? SubscriberCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        public double? ErrorCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_slug")]
        public string? ProjectSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesGetPipelineResponsePipeline" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="integrationType"></param>
        /// <param name="feedId"></param>
        /// <param name="config"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="integrationId"></param>
        /// <param name="nextScheduledAt"></param>
        /// <param name="lastRunAt"></param>
        /// <param name="disabledAt"></param>
        /// <param name="integrationDisplayName"></param>
        /// <param name="feedName"></param>
        /// <param name="subscriberCount"></param>
        /// <param name="errorCount"></param>
        /// <param name="projectName"></param>
        /// <param name="projectSlug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesGetPipelineResponsePipeline(
            string id,
            string name,
            string organizationId,
            string projectId,
            global::G.PipelinesGetPipelineResponsePipelineIntegrationType integrationType,
            string feedId,
            global::G.Config7 config,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? integrationId,
            global::System.DateTime? nextScheduledAt,
            global::System.DateTime? lastRunAt,
            global::System.DateTime? disabledAt,
            string? integrationDisplayName,
            string? feedName,
            double? subscriberCount,
            double? errorCount,
            string? projectName,
            string? projectSlug)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.IntegrationId = integrationId;
            this.IntegrationType = integrationType;
            this.FeedId = feedId ?? throw new global::System.ArgumentNullException(nameof(feedId));
            this.Config = config;
            this.NextScheduledAt = nextScheduledAt;
            this.LastRunAt = lastRunAt;
            this.DisabledAt = disabledAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IntegrationDisplayName = integrationDisplayName;
            this.FeedName = feedName;
            this.SubscriberCount = subscriberCount;
            this.ErrorCount = errorCount;
            this.ProjectName = projectName;
            this.ProjectSlug = projectSlug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesGetPipelineResponsePipeline" /> class.
        /// </summary>
        public PipelinesGetPipelineResponsePipeline()
        {
        }
    }
}