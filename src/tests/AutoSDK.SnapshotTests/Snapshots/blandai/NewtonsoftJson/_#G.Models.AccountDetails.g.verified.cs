//HintName: G.Models.AccountDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountDetails
    {
        /// <summary>
        /// Account status (e.g. "active")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing")]
        public global::G.AccountDetailsBilling? Billing { get; set; }

        /// <summary>
        /// Total number of calls made
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_calls")]
        public int? TotalCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetails" /> class.
        /// </summary>
        /// <param name="status">
        /// Account status (e.g. "active")
        /// </param>
        /// <param name="billing"></param>
        /// <param name="totalCalls">
        /// Total number of calls made
        /// </param>
        public AccountDetails(
            string? status,
            global::G.AccountDetailsBilling? billing,
            int? totalCalls)
        {
            this.Status = status;
            this.Billing = billing;
            this.TotalCalls = totalCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetails" /> class.
        /// </summary>
        public AccountDetails()
        {
        }
    }
}