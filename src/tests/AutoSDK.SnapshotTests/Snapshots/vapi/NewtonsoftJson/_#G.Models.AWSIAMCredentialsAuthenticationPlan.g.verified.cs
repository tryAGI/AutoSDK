//HintName: G.Models.AWSIAMCredentialsAuthenticationPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AWSIAMCredentialsAuthenticationPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AWSIAMCredentialsAuthenticationPlanTypeJsonConverter))]
        public global::G.AWSIAMCredentialsAuthenticationPlanType Type { get; set; }

        /// <summary>
        /// AWS Access Key ID. This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awsAccessKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsAccessKeyId { get; set; } = default!;

        /// <summary>
        /// AWS Secret Access Key. This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awsSecretAccessKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string AwsSecretAccessKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSIAMCredentialsAuthenticationPlan" /> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// AWS Access Key ID. This is not returned in the API.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS Secret Access Key. This is not returned in the API.
        /// </param>
        /// <param name="type"></param>
        public AWSIAMCredentialsAuthenticationPlan(
            string awsAccessKeyId,
            string awsSecretAccessKey,
            global::G.AWSIAMCredentialsAuthenticationPlanType type)
        {
            this.Type = type;
            this.AwsAccessKeyId = awsAccessKeyId ?? throw new global::System.ArgumentNullException(nameof(awsAccessKeyId));
            this.AwsSecretAccessKey = awsSecretAccessKey ?? throw new global::System.ArgumentNullException(nameof(awsSecretAccessKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSIAMCredentialsAuthenticationPlan" /> class.
        /// </summary>
        public AWSIAMCredentialsAuthenticationPlan()
        {
        }
    }
}