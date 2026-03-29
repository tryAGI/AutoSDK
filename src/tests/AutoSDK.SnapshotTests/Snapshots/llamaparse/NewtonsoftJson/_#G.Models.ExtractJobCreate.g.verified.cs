//HintName: G.Models.ExtractJobCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating an extraction job.
    /// </summary>
    public sealed partial class ExtractJobCreate
    {
        /// <summary>
        /// The priority for the request. This field may be ignored or overwritten depending on the organization tier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority")]
        public global::G.ExtractJobCreatePriority2? Priority { get; set; }

        /// <summary>
        /// Outbound webhook endpoints to notify on job status changes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// The id of the extraction agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExtractionAgentId { get; set; } = default!;

        /// <summary>
        /// The id of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// The data schema to override the extraction agent's data schema with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema_override")]
        public global::G.AnyOf<object, string, object>? DataSchemaOverride { get; set; }

        /// <summary>
        /// The config to override the extraction agent's config with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config_override")]
        public global::G.ExtractConfig? ConfigOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobCreate" /> class.
        /// </summary>
        /// <param name="extractionAgentId">
        /// The id of the extraction agent
        /// </param>
        /// <param name="fileId">
        /// The id of the file
        /// </param>
        /// <param name="priority">
        /// The priority for the request. This field may be ignored or overwritten depending on the organization tier.
        /// </param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="dataSchemaOverride">
        /// The data schema to override the extraction agent's data schema with
        /// </param>
        /// <param name="configOverride">
        /// The config to override the extraction agent's config with
        /// </param>
        public ExtractJobCreate(
            global::System.Guid extractionAgentId,
            global::System.Guid fileId,
            global::G.ExtractJobCreatePriority2? priority,
            global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? webhookConfigurations,
            global::G.AnyOf<object, string, object>? dataSchemaOverride,
            global::G.ExtractConfig? configOverride)
        {
            this.Priority = priority;
            this.WebhookConfigurations = webhookConfigurations;
            this.ExtractionAgentId = extractionAgentId;
            this.FileId = fileId;
            this.DataSchemaOverride = dataSchemaOverride;
            this.ConfigOverride = configOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobCreate" /> class.
        /// </summary>
        public ExtractJobCreate()
        {
        }
    }
}