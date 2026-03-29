//HintName: G.Models.PortkeyFinetuneJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gateway supported body params for portkey managed fine-tuning.
    /// </summary>
    public sealed partial class PortkeyFinetuneJob
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
        /// Portkey Gateway Provider specific headers to be passed to the provider, if portkey is used as a provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("portkey_options")]
        public global::G.PortkeyOptions? PortkeyOptions { get; set; }

        /// <summary>
        /// Provider specific options to be passed to the provider, optional can be passed directly as well. Can be skipped if same keys are passed at top the level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_options")]
        public global::G.BedrockParams? ProviderOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyFinetuneJob" /> class.
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
        /// <param name="portkeyOptions">
        /// Portkey Gateway Provider specific headers to be passed to the provider, if portkey is used as a provider
        /// </param>
        /// <param name="providerOptions">
        /// Provider specific options to be passed to the provider, optional can be passed directly as well. Can be skipped if same keys are passed at top the level.
        /// </param>
        public PortkeyFinetuneJob(
            string? jobName,
            string? roleArn,
            string? outputFile,
            global::G.PortkeyOptions? portkeyOptions,
            global::G.BedrockParams? providerOptions)
        {
            this.JobName = jobName;
            this.RoleArn = roleArn;
            this.OutputFile = outputFile;
            this.PortkeyOptions = portkeyOptions;
            this.ProviderOptions = providerOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyFinetuneJob" /> class.
        /// </summary>
        public PortkeyFinetuneJob()
        {
        }
    }
}