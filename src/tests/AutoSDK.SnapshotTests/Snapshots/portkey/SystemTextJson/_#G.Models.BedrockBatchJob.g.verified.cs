//HintName: G.Models.BedrockBatchJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gateway supported body params for bedrock fine-tuning.
    /// </summary>
    public sealed partial class BedrockBatchJob
    {
        /// <summary>
        /// Job name for the batch job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_name")]
        public string? JobName { get; set; }

        /// <summary>
        /// Batch job's output storage location, will be constructed based on `input_file_id` if not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_data_config")]
        public string? OutputDataConfig { get; set; }

        /// <summary>
        /// Model to start batch job with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Role ARN for the bedrock batch job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockBatchJob" /> class.
        /// </summary>
        /// <param name="model">
        /// Model to start batch job with
        /// </param>
        /// <param name="roleArn">
        /// Role ARN for the bedrock batch job
        /// </param>
        /// <param name="jobName">
        /// Job name for the batch job
        /// </param>
        /// <param name="outputDataConfig">
        /// Batch job's output storage location, will be constructed based on `input_file_id` if not provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BedrockBatchJob(
            string model,
            string roleArn,
            string? jobName,
            string? outputDataConfig)
        {
            this.JobName = jobName;
            this.OutputDataConfig = outputDataConfig;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockBatchJob" /> class.
        /// </summary>
        public BedrockBatchJob()
        {
        }
    }
}