//HintName: G.Models.AWSRegistry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AWSRegistry
    {
        /// <summary>
        /// Type of registry authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AWSRegistryType Type { get; set; }

        /// <summary>
        /// AWS Access Key ID for ECR authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awsAccessKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsAccessKeyId { get; set; } = default!;

        /// <summary>
        /// AWS Secret Access Key for ECR authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awsSecretAccessKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsSecretAccessKey { get; set; } = default!;

        /// <summary>
        /// AWS Region where the ECR registry is located
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awsRegion", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsRegion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSRegistry" /> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// AWS Access Key ID for ECR authentication
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS Secret Access Key for ECR authentication
        /// </param>
        /// <param name="awsRegion">
        /// AWS Region where the ECR registry is located
        /// </param>
        /// <param name="type">
        /// Type of registry authentication
        /// </param>
        public AWSRegistry(
            string awsAccessKeyId,
            string awsSecretAccessKey,
            string awsRegion,
            global::G.AWSRegistryType type)
        {
            this.Type = type;
            this.AwsAccessKeyId = awsAccessKeyId ?? throw new global::System.ArgumentNullException(nameof(awsAccessKeyId));
            this.AwsSecretAccessKey = awsSecretAccessKey ?? throw new global::System.ArgumentNullException(nameof(awsSecretAccessKey));
            this.AwsRegion = awsRegion ?? throw new global::System.ArgumentNullException(nameof(awsRegion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSRegistry" /> class.
        /// </summary>
        public AWSRegistry()
        {
        }
    }
}