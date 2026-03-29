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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AWSStsAuthenticationPlanTypeJsonConverter))]
        public global::G.AWSStsAuthenticationPlanType Type { get; set; }

        /// <summary>
        /// This is the role ARN for the AWS credential
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roleArn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleArn { get; set; }

        /// <summary>
        /// Optional external ID for additional security in the role trust policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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