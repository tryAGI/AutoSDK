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
        [global::System.Text.Json.Serialization.JsonPropertyName("isSuccessfull")]
        public bool? IsSuccessfull { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditTransactionLog")]
        public global::G.CreditTransaction2? CreditTransactionLog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingTransactionLog")]
        public global::G.BillingTransaction2? BillingTransactionLog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponse" /> class.
        /// </summary>
        /// <param name="isSuccessfull"></param>
        /// <param name="transactionId"></param>
        /// <param name="errors"></param>
        /// <param name="creditTransactionLog"></param>
        /// <param name="billingTransactionLog"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentResponse(
            bool? isSuccessfull,
            string? transactionId,
            global::System.Collections.Generic.IList<string>? errors,
            global::G.CreditTransaction2? creditTransactionLog,
            global::G.BillingTransaction2? billingTransactionLog)
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