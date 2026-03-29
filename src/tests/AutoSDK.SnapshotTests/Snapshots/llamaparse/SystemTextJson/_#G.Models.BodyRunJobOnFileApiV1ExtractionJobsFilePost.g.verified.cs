//HintName: G.Models.BodyRunJobOnFileApiV1ExtractionJobsFilePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyRunJobOnFileApiV1ExtractionJobsFilePost
    {
        /// <summary>
        /// The id of the extraction agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExtractionAgentId { get; set; }

        /// <summary>
        /// The file to run the job on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to run the job on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The data schema to override the extraction agent's data schema with as a JSON string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema_override")]
        public string? DataSchemaOverride { get; set; }

        /// <summary>
        /// The config to override the extraction agent's config with as a JSON string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_override")]
        public string? ConfigOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRunJobOnFileApiV1ExtractionJobsFilePost" /> class.
        /// </summary>
        /// <param name="extractionAgentId">
        /// The id of the extraction agent
        /// </param>
        /// <param name="file">
        /// The file to run the job on
        /// </param>
        /// <param name="filename">
        /// The file to run the job on
        /// </param>
        /// <param name="dataSchemaOverride">
        /// The data schema to override the extraction agent's data schema with as a JSON string
        /// </param>
        /// <param name="configOverride">
        /// The config to override the extraction agent's config with as a JSON string
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyRunJobOnFileApiV1ExtractionJobsFilePost(
            global::System.Guid extractionAgentId,
            byte[] file,
            string filename,
            string? dataSchemaOverride,
            string? configOverride)
        {
            this.ExtractionAgentId = extractionAgentId;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.DataSchemaOverride = dataSchemaOverride;
            this.ConfigOverride = configOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRunJobOnFileApiV1ExtractionJobsFilePost" /> class.
        /// </summary>
        public BodyRunJobOnFileApiV1ExtractionJobsFilePost()
        {
        }
    }
}