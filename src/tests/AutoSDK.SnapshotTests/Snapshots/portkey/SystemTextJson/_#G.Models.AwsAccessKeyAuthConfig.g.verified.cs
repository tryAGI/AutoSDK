//HintName: G.Models.AwsAccessKeyAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AwsAccessKeyAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter))]
        public global::G.AwsAccessKeyAuthConfigAwsAuthType AwsAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsAccessKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_secret_access_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsSecretAccessKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsAccessKeyAuthConfig" /> class.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="awsRegion"></param>
        /// <param name="awsAuthType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsAccessKeyAuthConfig(
            string awsAccessKeyId,
            string awsSecretAccessKey,
            string awsRegion,
            global::G.AwsAccessKeyAuthConfigAwsAuthType awsAuthType)
        {
            this.AwsAuthType = awsAuthType;
            this.AwsAccessKeyId = awsAccessKeyId ?? throw new global::System.ArgumentNullException(nameof(awsAccessKeyId));
            this.AwsSecretAccessKey = awsSecretAccessKey ?? throw new global::System.ArgumentNullException(nameof(awsSecretAccessKey));
            this.AwsRegion = awsRegion ?? throw new global::System.ArgumentNullException(nameof(awsRegion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsAccessKeyAuthConfig" /> class.
        /// </summary>
        public AwsAccessKeyAuthConfig()
        {
        }
    }
}