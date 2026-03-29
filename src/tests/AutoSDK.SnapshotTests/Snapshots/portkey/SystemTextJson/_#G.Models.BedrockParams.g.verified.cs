//HintName: G.Models.BedrockParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BedrockParams
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
        /// Initializes a new instance of the <see cref="BedrockParams" /> class.
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
        public BedrockParams(
            string? jobName,
            string? roleArn,
            string? outputFile)
        {
            this.JobName = jobName;
            this.RoleArn = roleArn;
            this.OutputFile = outputFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockParams" /> class.
        /// </summary>
        public BedrockParams()
        {
        }
    }
}