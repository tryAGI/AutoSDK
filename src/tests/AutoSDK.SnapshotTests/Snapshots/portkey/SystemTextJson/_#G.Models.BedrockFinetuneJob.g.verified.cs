//HintName: G.Models.BedrockFinetuneJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gateway supported body params for bedrock fine-tuning.
    /// </summary>
    public sealed partial class BedrockFinetuneJob
    {
        /// <summary>
        /// Job name for the bedrock finetune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_name")]
        public string? JobName { get; set; }

        /// <summary>
        /// Role ARN for the bedrock finetune job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        public string? RoleArn { get; set; }

        /// <summary>
        /// Finetune job's output s3 location, will be constructed based on `training_file` if not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_file")]
        public string? OutputFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockFinetuneJob" /> class.
        /// </summary>
        /// <param name="jobName">
        /// Job name for the bedrock finetune job
        /// </param>
        /// <param name="roleArn">
        /// Role ARN for the bedrock finetune job
        /// </param>
        /// <param name="outputFile">
        /// Finetune job's output s3 location, will be constructed based on `training_file` if not provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BedrockFinetuneJob(
            string? jobName,
            string? roleArn,
            string? outputFile)
        {
            this.JobName = jobName;
            this.RoleArn = roleArn;
            this.OutputFile = outputFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockFinetuneJob" /> class.
        /// </summary>
        public BedrockFinetuneJob()
        {
        }
    }
}