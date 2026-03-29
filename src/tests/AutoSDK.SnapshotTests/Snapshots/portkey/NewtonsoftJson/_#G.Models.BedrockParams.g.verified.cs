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
        [global::Newtonsoft.Json.JsonProperty("job_name")]
        public string? JobName { get; set; }

        /// <summary>
        /// Role ARN for the bedrock finetune job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_arn")]
        public string? RoleArn { get; set; }

        /// <summary>
        /// Finetune job's output s3 location, will be constructed based on `training_file` if not provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_file")]
        public string? OutputFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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