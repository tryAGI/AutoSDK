//HintName: G.Models.BillingInfoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BillingChecks BillingChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_flags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BillingFlags BillingFlags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInfoResponse" /> class.
        /// </summary>
        /// <param name="billingChecks"></param>
        /// <param name="billingFlags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingInfoResponse(
            global::G.BillingChecks billingChecks,
            global::G.BillingFlags billingFlags)
        {
            this.BillingChecks = billingChecks ?? throw new global::System.ArgumentNullException(nameof(billingChecks));
            this.BillingFlags = billingFlags ?? throw new global::System.ArgumentNullException(nameof(billingFlags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInfoResponse" /> class.
        /// </summary>
        public BillingInfoResponse()
        {
        }
    }
}