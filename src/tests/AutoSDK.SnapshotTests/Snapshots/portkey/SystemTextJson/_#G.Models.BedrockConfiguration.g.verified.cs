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
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BedrockConfigurationAwsAuthTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BedrockConfigurationAwsAuthType AwsAuthType { get; set; }

        /// <summary>
        /// AWS region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsRegion { get; set; }

        /// <summary>
        /// AWS access key ID (required for accessKey auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_key_id")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS secret access key (required for accessKey auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_secret_access_key")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS role ARN (required for assumedRole auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_role_arn")]
        public string? AwsRoleArn { get; set; }

        /// <summary>
        /// AWS external ID (optional for assumedRole auth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_external_id")]
        public string? AwsExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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