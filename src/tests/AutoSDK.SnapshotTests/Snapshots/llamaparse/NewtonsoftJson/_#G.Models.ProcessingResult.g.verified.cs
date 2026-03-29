//HintName: G.Models.ProcessingResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A processing result with lineage information.
    /// </summary>
    public sealed partial class ProcessingResult
    {
        /// <summary>
        /// Unique identifier for this result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResultId { get; set; } = default!;

        /// <summary>
        /// Source item that was processed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// Type of processing performed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BatchJobType JobType { get; set; } = default!;

        /// <summary>
        /// Job configuration used for processing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob> JobConfig { get; set; } = default!;

        /// <summary>
        /// Content hash of the job configuration for dedup
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string ParametersHash { get; set; } = default!;

        /// <summary>
        /// Location of the processing output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_s3_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string OutputS3Path { get; set; } = default!;

        /// <summary>
        /// Summary statistics about the output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_metadata")]
        public global::G.ProcessingResultMetadata? OutputMetadata { get; set; }

        /// <summary>
        /// When this processing occurred
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ProcessedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingResult" /> class.
        /// </summary>
        /// <param name="resultId">
        /// Unique identifier for this result
        /// </param>
        /// <param name="itemId">
        /// Source item that was processed
        /// </param>
        /// <param name="jobType">
        /// Type of processing performed
        /// </param>
        /// <param name="jobConfig">
        /// Job configuration used for processing
        /// </param>
        /// <param name="parametersHash">
        /// Content hash of the job configuration for dedup
        /// </param>
        /// <param name="outputS3Path">
        /// Location of the processing output
        /// </param>
        /// <param name="processedAt">
        /// When this processing occurred
        /// </param>
        /// <param name="outputMetadata">
        /// Summary statistics about the output
        /// </param>
        public ProcessingResult(
            string resultId,
            string itemId,
            global::G.BatchJobType jobType,
            global::G.AnyOf<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob> jobConfig,
            string parametersHash,
            string outputS3Path,
            global::System.DateTime processedAt,
            global::G.ProcessingResultMetadata? outputMetadata)
        {
            this.ResultId = resultId ?? throw new global::System.ArgumentNullException(nameof(resultId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.JobType = jobType;
            this.JobConfig = jobConfig;
            this.ParametersHash = parametersHash ?? throw new global::System.ArgumentNullException(nameof(parametersHash));
            this.OutputS3Path = outputS3Path ?? throw new global::System.ArgumentNullException(nameof(outputS3Path));
            this.OutputMetadata = outputMetadata;
            this.ProcessedAt = processedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingResult" /> class.
        /// </summary>
        public ProcessingResult()
        {
        }
    }
}