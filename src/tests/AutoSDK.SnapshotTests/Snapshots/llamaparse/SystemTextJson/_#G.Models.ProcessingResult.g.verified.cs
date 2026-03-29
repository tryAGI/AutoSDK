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
        [global::System.Text.Json.Serialization.JsonPropertyName("result_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultId { get; set; }

        /// <summary>
        /// Source item that was processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Type of processing performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchJobTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BatchJobType JobType { get; set; }

        /// <summary>
        /// Job configuration used for processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob> JobConfig { get; set; }

        /// <summary>
        /// Content hash of the job configuration for dedup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParametersHash { get; set; }

        /// <summary>
        /// Location of the processing output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_s3_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputS3Path { get; set; }

        /// <summary>
        /// Summary statistics about the output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_metadata")]
        public global::G.ProcessingResultMetadata? OutputMetadata { get; set; }

        /// <summary>
        /// When this processing occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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