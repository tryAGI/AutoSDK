//HintName: G.Models.BedrockEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BedrockEmbedding
    {
        /// <summary>
        /// The modelId of the Bedrock model to use.<br/>
        /// Default Value: amazon.titan-embed-text-v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_batch_size")]
        public int? EmbedBatchSize { get; set; }

        /// <summary>
        /// The number of workers to use for async embedding calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_workers")]
        public int? NumWorkers { get; set; }

        /// <summary>
        /// The name of aws profile to use. If not given, then the default profile is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile_name")]
        public string? ProfileName { get; set; }

        /// <summary>
        /// AWS Access Key ID to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_access_key_id")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS Secret Access Key to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_secret_access_key")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS Session Token to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_session_token")]
        public string? AwsSessionToken { get; set; }

        /// <summary>
        /// AWS region name to use. Uses region configured in AWS CLI if not passed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region_name")]
        public string? RegionName { get; set; }

        /// <summary>
        /// The maximum number of API retries.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_retries")]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// The timeout for the Bedrock API request in seconds. It will be used for both connect and read timeouts.<br/>
        /// Default Value: 60F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional kwargs for the bedrock client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_kwargs")]
        public object? AdditionalKwargs { get; set; }

        /// <summary>
        /// Default Value: BedrockEmbedding
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockEmbedding" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The modelId of the Bedrock model to use.<br/>
        /// Default Value: amazon.titan-embed-text-v1
        /// </param>
        /// <param name="embedBatchSize">
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="numWorkers">
        /// The number of workers to use for async embedding calls.
        /// </param>
        /// <param name="profileName">
        /// The name of aws profile to use. If not given, then the default profile is used.
        /// </param>
        /// <param name="awsAccessKeyId">
        /// AWS Access Key ID to use
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS Secret Access Key to use
        /// </param>
        /// <param name="awsSessionToken">
        /// AWS Session Token to use
        /// </param>
        /// <param name="regionName">
        /// AWS region name to use. Uses region configured in AWS CLI if not passed
        /// </param>
        /// <param name="maxRetries">
        /// The maximum number of API retries.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="timeout">
        /// The timeout for the Bedrock API request in seconds. It will be used for both connect and read timeouts.<br/>
        /// Default Value: 60F
        /// </param>
        /// <param name="additionalKwargs">
        /// Additional kwargs for the bedrock client.
        /// </param>
        /// <param name="className">
        /// Default Value: BedrockEmbedding
        /// </param>
        public BedrockEmbedding(
            string? modelName,
            int? embedBatchSize,
            int? numWorkers,
            string? profileName,
            string? awsAccessKeyId,
            string? awsSecretAccessKey,
            string? awsSessionToken,
            string? regionName,
            int? maxRetries,
            double? timeout,
            object? additionalKwargs,
            string? className)
        {
            this.ModelName = modelName;
            this.EmbedBatchSize = embedBatchSize;
            this.NumWorkers = numWorkers;
            this.ProfileName = profileName;
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsSecretAccessKey = awsSecretAccessKey;
            this.AwsSessionToken = awsSessionToken;
            this.RegionName = regionName;
            this.MaxRetries = maxRetries;
            this.Timeout = timeout;
            this.AdditionalKwargs = additionalKwargs;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockEmbedding" /> class.
        /// </summary>
        public BedrockEmbedding()
        {
        }
    }
}