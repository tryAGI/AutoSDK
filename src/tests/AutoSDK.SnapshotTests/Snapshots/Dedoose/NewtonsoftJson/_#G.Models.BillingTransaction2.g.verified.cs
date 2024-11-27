//HintName: G.Models.BillingTransaction2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingTransaction2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId")]
        public global::System.Guid? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billingDate")]
        public global::System.DateTime? BillingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amountPaid")]
        public double? AmountPaid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creditsAdded")]
        public double? CreditsAdded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memo")]
        public string? Memo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingTransaction2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="accountId"></param>
        /// <param name="billingDate"></param>
        /// <param name="amountPaid"></param>
        /// <param name="creditsAdded"></param>
        /// <param name="memo"></param>
        public BillingTransaction2(
            global::System.Guid? id,
            global::System.Guid? accountId,
            global::System.DateTime? billingDate,
            double? amountPaid,
            double? creditsAdded,
            string? memo)
        {
            this.Id = id;
            this.AccountId = accountId;
            this.BillingDate = billingDate;
            this.AmountPaid = amountPaid;
            this.CreditsAdded = creditsAdded;
            this.Memo = memo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingTransaction2" /> class.
        /// </summary>
        public BillingTransaction2()
        {
        }
    }
}