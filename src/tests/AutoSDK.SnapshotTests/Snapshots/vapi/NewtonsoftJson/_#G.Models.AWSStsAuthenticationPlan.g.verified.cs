//HintName: G.Models.AWSStsAuthenticationPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AWSStsAuthenticationPlan
    {
        /// <summary>
        /// This is the type of authentication plan
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AWSStsAuthenticationPlanType Type { get; set; }

        /// <summary>
        /// This is the role ARN for the AWS credential
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roleArn", Required = global::Newtonsoft.Json.Required.Always)]
        public string RoleArn { get; set; } = default!;

        /// <summary>
        /// Optional external ID for additional security in the role trust policy.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsAuthenticationPlan" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// This is the role ARN for the AWS credential
        /// </param>
        /// <param name="type">
        /// This is the type of authentication plan
        /// </param>
        /// <param name="externalId">
        /// Optional external ID for additional security in the role trust policy.
        /// </param>
        public AWSStsAuthenticationPlan(
            string roleArn,
            global::G.AWSStsAuthenticationPlanType type,
            string? externalId)
        {
            this.Type = type;
            this.RoleArn = roleArn ?? throw new global::System.ArgumentNullException(nameof(roleArn));
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsAuthenticationPlan" /> class.
        /// </summary>
        public AWSStsAuthenticationPlan()
        {
        }
    }
}