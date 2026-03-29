//HintName: G.Models.ExtractJobCreateBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating extraction jobs in batch.
    /// </summary>
    public sealed partial class ExtractJobCreateBatch
    {
        /// <summary>
        /// Outbound webhook endpoints to notify on job status changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// The id of the extraction agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExtractionAgentId { get; set; }

        /// <summary>
        /// The ids of the files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> FileIds { get; set; }

        /// <summary>
        /// The data schema to override the extraction agent's data schema with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema_override")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, string, object>))]
        public global::G.AnyOf<object, string, object>? DataSchemaOverride { get; set; }

        /// <summary>
        /// The config to override the extraction agent's config with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_override")]
        public global::G.ExtractConfig? ConfigOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobCreateBatch" /> class.
        /// </summary>
        /// <param name="extractionAgentId">
        /// The id of the extraction agent
        /// </param>
        /// <param name="fileIds">
        /// The ids of the files
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractJobCreateBatch(
            global::System.Guid extractionAgentId,
            global::System.Collections.Generic.IList<global::System.Guid> fileIds,
            global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? webhookConfigurations,
            global::G.AnyOf<object, string, object>? dataSchemaOverride,
            global::G.ExtractConfig? configOverride)
        {
            this.WebhookConfigurations = webhookConfigurations;
            this.ExtractionAgentId = extractionAgentId;
            this.FileIds = fileIds ?? throw new global::System.ArgumentNullException(nameof(fileIds));
            this.DataSchemaOverride = dataSchemaOverride;
            this.ConfigOverride = configOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobCreateBatch" /> class.
        /// </summary>
        public ExtractJobCreateBatch()
        {
        }
    }
}