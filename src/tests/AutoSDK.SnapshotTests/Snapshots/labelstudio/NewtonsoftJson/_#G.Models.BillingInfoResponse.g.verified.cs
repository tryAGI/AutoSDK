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
        [global::Newtonsoft.Json.JsonProperty("billing_checks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BillingChecks BillingChecks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_flags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BillingFlags BillingFlags { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInfoResponse" /> class.
        /// </summary>
        /// <param name="billingChecks"></param>
        /// <param name="billingFlags"></param>
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