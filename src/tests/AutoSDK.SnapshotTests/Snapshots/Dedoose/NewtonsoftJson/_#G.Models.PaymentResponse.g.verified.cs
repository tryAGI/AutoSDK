//HintName: G.Models.PaymentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaymentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isSuccessfull")]
        public bool? IsSuccessfull { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creditTransactionLog")]
        public global::G.CreditTransaction? CreditTransactionLog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billingTransactionLog")]
        public global::G.BillingTransaction? BillingTransactionLog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse" /> class.
        /// </summary>
        /// <param name="isSuccessfull"></param>
        /// <param name="transactionId"></param>
        /// <param name="errors"></param>
        /// <param name="creditTransactionLog"></param>
        /// <param name="billingTransactionLog"></param>
        public PaymentResponse(
            bool? isSuccessfull,
            string? transactionId,
            global::System.Collections.Generic.IList<string>? errors,
            global::G.CreditTransaction? creditTransactionLog,
            global::G.BillingTransaction? billingTransactionLog)
        {
            this.IsSuccessfull = isSuccessfull;
            this.TransactionId = transactionId;
            this.Errors = errors;
            this.CreditTransactionLog = creditTransactionLog;
            this.BillingTransactionLog = billingTransactionLog;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse" /> class.
        /// </summary>
        public PaymentResponse()
        {
        }
    }
}