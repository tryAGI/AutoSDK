//HintName: G.Models.AwsServiceRoleAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AwsServiceRoleAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_auth_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter))]
        public global::G.AwsServiceRoleAuthConfigAwsAuthType AwsAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_region")]
        public string? AwsRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsServiceRoleAuthConfig" /> class.
        /// </summary>
        /// <param name="awsAuthType"></param>
        /// <param name="awsRegion"></param>
        public AwsServiceRoleAuthConfig(
            global::G.AwsServiceRoleAuthConfigAwsAuthType awsAuthType,
            string? awsRegion)
        {
            this.AwsAuthType = awsAuthType;
            this.AwsRegion = awsRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsServiceRoleAuthConfig" /> class.
        /// </summary>
        public AwsServiceRoleAuthConfig()
        {
        }
    }
}