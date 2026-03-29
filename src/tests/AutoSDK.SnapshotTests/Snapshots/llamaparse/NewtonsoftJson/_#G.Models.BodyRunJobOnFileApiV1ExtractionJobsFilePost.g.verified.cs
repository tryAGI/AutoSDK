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
        [global::Newtonsoft.Json.JsonProperty("extraction_agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExtractionAgentId { get; set; } = default!;

        /// <summary>
        /// The file to run the job on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// The file to run the job on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The data schema to override the extraction agent's data schema with as a JSON string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema_override")]
        public string? DataSchemaOverride { get; set; }

        /// <summary>
        /// The config to override the extraction agent's config with as a JSON string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config_override")]
        public string? ConfigOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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