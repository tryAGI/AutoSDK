//HintName: G.Models.GetOrganizationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationResponse
    {
        /// <summary>
        /// Limits associated with the organization's tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetOrganizationResponseTier Tier { get; set; }

        /// <summary>
        /// The number of credits remaining in the organization account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditBalance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditBalance { get; set; }

        /// <summary>
        /// Usage data for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetOrganizationResponseUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponse" /> class.
        /// </summary>
        /// <param name="tier">
        /// Limits associated with the organization's tier.
        /// </param>
        /// <param name="creditBalance">
        /// The number of credits remaining in the organization account.
        /// </param>
        /// <param name="usage">
        /// Usage data for the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationResponse(
            global::G.GetOrganizationResponseTier tier,
            int creditBalance,
            global::G.GetOrganizationResponseUsage usage)
        {
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
            this.CreditBalance = creditBalance;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponse" /> class.
        /// </summary>
        public GetOrganizationResponse()
        {
        }
    }
}