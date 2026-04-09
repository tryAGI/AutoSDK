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
        [global::Newtonsoft.Json.JsonProperty("aws_auth_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AwsAccessKeyAuthConfigAwsAuthTypeJsonConverter))]
        public global::G.AwsAccessKeyAuthConfigAwsAuthType AwsAuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_access_key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsAccessKeyId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws_secret_access_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsSecretAccessKey { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="AwsAccessKeyAuthConfig" /> class.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="awsRegion"></param>
        /// <param name="awsAuthType"></param>
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