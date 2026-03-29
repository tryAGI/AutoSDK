//HintName: G.Models.PortkeyBatchJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gateway supported body params for portkey managed batching.
    /// </summary>
    public sealed partial class PortkeyBatchJob
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
        /// Role ARN for the bedrock batch job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_arn")]
        public string? RoleArn { get; set; }

        /// <summary>
        /// Portkey Gateway Provider specific headers to be passed to the provider, if portkey is used as a provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("portkey_options")]
        public global::G.PortkeyBatchOptions? PortkeyOptions { get; set; }

        /// <summary>
        /// Provider specific options to be passed to the provider, optional can be passed directly as well.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_options")]
        public global::G.AnyOf<global::G.PortkeyBatchJobProviderOptionsBedrockOptions, global::G.PortkeyBatchJobProviderOptionsVertexOptions>? ProviderOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyBatchJob" /> class.
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
        /// <param name="roleArn">
        /// Role ARN for the bedrock batch job
        /// </param>
        /// <param name="portkeyOptions">
        /// Portkey Gateway Provider specific headers to be passed to the provider, if portkey is used as a provider
        /// </param>
        /// <param name="providerOptions">
        /// Provider specific options to be passed to the provider, optional can be passed directly as well.
        /// </param>
        public PortkeyBatchJob(
            string model,
            string? jobName,
            string? outputDataConfig,
            string? roleArn,
            global::G.PortkeyBatchOptions? portkeyOptions,
            global::G.AnyOf<global::G.PortkeyBatchJobProviderOptionsBedrockOptions, global::G.PortkeyBatchJobProviderOptionsVertexOptions>? providerOptions)
        {
            this.JobName = jobName;
            this.OutputDataConfig = outputDataConfig;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.RoleArn = roleArn;
            this.PortkeyOptions = portkeyOptions;
            this.ProviderOptions = providerOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyBatchJob" /> class.
        /// </summary>
        public PortkeyBatchJob()
        {
        }
    }
}