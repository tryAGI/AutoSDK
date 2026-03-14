//HintName: G.Models.BedrockStaticIAMAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS Bedrock authentication with explicit IAM credentials
    /// </summary>
    public sealed partial class BedrockStaticIAMAuth
    {
        /// <summary>
        /// Must be "bedrock_static_iam" for static AWS IAM credentials<br/>
        /// Default Value: bedrock_static_iam<br/>
        /// Example: bedrock_static_iam
        /// </summary>
        /// <default>"bedrock_static_iam"</default>
        /// <example>bedrock_static_iam</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// AWS access key ID<br/>
        /// Example: AKIAIOSFODNN7EXAMPLE
        /// </summary>
        /// <example>AKIAIOSFODNN7EXAMPLE</example>
        [global::Newtonsoft.Json.JsonProperty("aws_access_key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsAccessKeyId { get; set; } = default!;

        /// <summary>
        /// AWS secret access key<br/>
        /// Example: wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY
        /// </summary>
        /// <example>wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY</example>
        [global::Newtonsoft.Json.JsonProperty("aws_secret_access_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsSecretAccessKey { get; set; } = default!;

        /// <summary>
        /// AWS region for Bedrock<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public string Region { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockStaticIAMAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "bedrock_static_iam" for static AWS IAM credentials<br/>
        /// Default Value: bedrock_static_iam<br/>
        /// Example: bedrock_static_iam
        /// </param>
        /// <param name="awsAccessKeyId">
        /// AWS access key ID<br/>
        /// Example: AKIAIOSFODNN7EXAMPLE
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS secret access key<br/>
        /// Example: wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY
        /// </param>
        /// <param name="region">
        /// AWS region for Bedrock<br/>
        /// Example: us-east-1
        /// </param>
        public BedrockStaticIAMAuth(
            string type,
            string awsAccessKeyId,
            string awsSecretAccessKey,
            string region)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AwsAccessKeyId = awsAccessKeyId ?? throw new global::System.ArgumentNullException(nameof(awsAccessKeyId));
            this.AwsSecretAccessKey = awsSecretAccessKey ?? throw new global::System.ArgumentNullException(nameof(awsSecretAccessKey));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockStaticIAMAuth" /> class.
        /// </summary>
        public BedrockStaticIAMAuth()
        {
        }
    }
}