//HintName: G.Models.AwsAssumedRoleAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AwsAssumedRoleAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter))]
        public global::G.AwsAssumedRoleAuthConfigAwsAuthType AwsAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_role_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsRoleArn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_external_id")]
        public string? AwsExternalId { get; set; }

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
        /// Initializes a new instance of the <see cref="AwsAssumedRoleAuthConfig" /> class.
        /// </summary>
        /// <param name="awsRoleArn"></param>
        /// <param name="awsRegion"></param>
        /// <param name="awsAuthType"></param>
        /// <param name="awsExternalId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwsAssumedRoleAuthConfig(
            string awsRoleArn,
            string awsRegion,
            global::G.AwsAssumedRoleAuthConfigAwsAuthType awsAuthType,
            string? awsExternalId)
        {
            this.AwsAuthType = awsAuthType;
            this.AwsRoleArn = awsRoleArn ?? throw new global::System.ArgumentNullException(nameof(awsRoleArn));
            this.AwsExternalId = awsExternalId;
            this.AwsRegion = awsRegion ?? throw new global::System.ArgumentNullException(nameof(awsRegion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsAssumedRoleAuthConfig" /> class.
        /// </summary>
        public AwsAssumedRoleAuthConfig()
        {
        }
    }
}