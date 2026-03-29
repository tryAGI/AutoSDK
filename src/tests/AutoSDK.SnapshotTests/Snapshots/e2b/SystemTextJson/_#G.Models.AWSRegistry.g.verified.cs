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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AWSRegistryTypeJsonConverter))]
        public global::G.AWSRegistryType Type { get; set; }

        /// <summary>
        /// AWS Access Key ID for ECR authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAccessKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS Secret Access Key for ECR authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsSecretAccessKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsSecretAccessKey { get; set; }

        /// <summary>
        /// AWS Region where the ECR registry is located
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsRegion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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