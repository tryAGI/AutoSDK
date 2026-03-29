//HintName: G.Models.VertexBatchJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gateway supported body params for Vertext fine-tuning.
    /// </summary>
    public sealed partial class VertexBatchJob
    {
        /// <summary>
        /// Job name for the batch job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_name")]
        public string? JobName { get; set; }

        /// <summary>
        /// Batch job's output storage location, will be constructed based on `input_file_id` if not provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_data_config")]
        public string? OutputDataConfig { get; set; }

        /// <summary>
        /// Model to start batch job with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexBatchJob" /> class.
        /// </summary>
        /// <param name="model">
        /// Model to start batch job with
        /// </param>
        /// <param name="jobName">
        /// Job name for the batch job
        /// </param>
        /// <param name="outputDataConfig">
        /// Batch job's output storage location, will be constructed based on `input_file_id` if not provided
        /// </param>
        public VertexBatchJob(
            string model,
            string? jobName,
            string? outputDataConfig)
        {
            this.JobName = jobName;
            this.OutputDataConfig = outputDataConfig;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexBatchJob" /> class.
        /// </summary>
        public VertexBatchJob()
        {
        }
    }
}