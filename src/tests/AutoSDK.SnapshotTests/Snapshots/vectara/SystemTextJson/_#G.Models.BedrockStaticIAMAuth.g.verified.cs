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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "bedrock_static_iam";

        /// <summary>
        /// AWS access key ID<br/>
        /// Example: AKIAIOSFODNN7EXAMPLE
        /// </summary>
        /// <example>AKIAIOSFODNN7EXAMPLE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS secret access key<br/>
        /// Example: wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY
        /// </summary>
        /// <example>wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_secret_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS region for Bedrock<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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