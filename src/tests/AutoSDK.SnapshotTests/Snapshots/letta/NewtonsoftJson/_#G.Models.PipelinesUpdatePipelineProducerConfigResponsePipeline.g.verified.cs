//HintName: G.Models.PipelinesUpdatePipelineProducerConfigResponsePipeline.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineProducerConfigResponsePipeline
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_id")]
        public string? IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeJsonConverter))]
        public global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType IntegrationType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feed_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Config9 Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_scheduled_at")]
        public global::System.DateTime? NextScheduledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_run_at")]
        public global::System.DateTime? LastRunAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled_at")]
        public global::System.DateTime? DisabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_display_name")]
        public string? IntegrationDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feed_name")]
        public string? FeedName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriber_count")]
        public double? SubscriberCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_count")]
        public double? ErrorCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_slug")]
        public string? ProjectSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigResponsePipeline" /> class.
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
        public PipelinesUpdatePipelineProducerConfigResponsePipeline(
            string id,
            string name,
            string organizationId,
            string projectId,
            global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType integrationType,
            string feedId,
            global::G.Config9 config,
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
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigResponsePipeline" /> class.
        /// </summary>
        public PipelinesUpdatePipelineProducerConfigResponsePipeline()
        {
        }
    }
}