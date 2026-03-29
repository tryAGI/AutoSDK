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
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AwsServiceRoleAuthConfigAwsAuthTypeJsonConverter))]
        public global::G.AwsServiceRoleAuthConfigAwsAuthType AwsAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_region")]
        public string? AwsRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwsServiceRoleAuthConfig" /> class.
        /// </summary>
        /// <param name="awsAuthType"></param>
        /// <param name="awsRegion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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