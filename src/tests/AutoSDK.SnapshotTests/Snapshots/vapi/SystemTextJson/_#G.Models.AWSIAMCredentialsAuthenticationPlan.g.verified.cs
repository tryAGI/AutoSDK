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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AWSIAMCredentialsAuthenticationPlanTypeJsonConverter))]
        public global::G.AWSIAMCredentialsAuthenticationPlanType Type { get; set; }

        /// <summary>
        /// AWS Access Key ID. This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAccessKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsAccessKeyId { get; set; }

        /// <summary>
        /// AWS Secret Access Key. This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsSecretAccessKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsSecretAccessKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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