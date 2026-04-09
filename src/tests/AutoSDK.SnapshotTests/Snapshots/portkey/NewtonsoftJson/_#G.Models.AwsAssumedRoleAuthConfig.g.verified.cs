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
        [global::Newtonsoft.Json.JsonProperty("aws_auth_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter))]
        public global::G.AwsAssumedRoleAuthConfigAwsAuthType AwsAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_role_arn", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsRoleArn { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_external_id")]
        public string? AwsExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_region", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsRegion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsAssumedRoleAuthConfig" /> class.
        /// </summary>
        /// <param name="awsRoleArn"></param>
        /// <param name="awsRegion"></param>
        /// <param name="awsAuthType"></param>
        /// <param name="awsExternalId"></param>
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