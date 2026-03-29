//HintName: G.Models.BedrockConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BedrockConfiguration
    {
        /// <summary>
        /// AWS authentication type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_auth_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BedrockConfigurationAwsAuthType AwsAuthType { get; set; } = default!;

        /// <summary>
        /// AWS region
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_region", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsRegion { get; set; } = default!;

        /// <summary>
        /// AWS access key ID (required for accessKey auth)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_access_key_id")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS secret access key (required for accessKey auth)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_secret_access_key")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS role ARN (required for assumedRole auth)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_role_arn")]
        public string? AwsRoleArn { get; set; }

        /// <summary>
        /// AWS external ID (optional for assumedRole auth)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_external_id")]
        public string? AwsExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockConfiguration" /> class.
        /// </summary>
        /// <param name="awsAuthType">
        /// AWS authentication type
        /// </param>
        /// <param name="awsRegion">
        /// AWS region
        /// </param>
        /// <param name="awsAccessKeyId">
        /// AWS access key ID (required for accessKey auth)
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS secret access key (required for accessKey auth)
        /// </param>
        /// <param name="awsRoleArn">
        /// AWS role ARN (required for assumedRole auth)
        /// </param>
        /// <param name="awsExternalId">
        /// AWS external ID (optional for assumedRole auth)
        /// </param>
        public BedrockConfiguration(
            global::G.BedrockConfigurationAwsAuthType awsAuthType,
            string awsRegion,
            string? awsAccessKeyId,
            string? awsSecretAccessKey,
            string? awsRoleArn,
            string? awsExternalId)
        {
            this.AwsAuthType = awsAuthType;
            this.AwsRegion = awsRegion ?? throw new global::System.ArgumentNullException(nameof(awsRegion));
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsSecretAccessKey = awsSecretAccessKey;
            this.AwsRoleArn = awsRoleArn;
            this.AwsExternalId = awsExternalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockConfiguration" /> class.
        /// </summary>
        public BedrockConfiguration()
        {
        }
    }
}