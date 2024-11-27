//HintName: G.Models.ProcessPaymentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessPaymentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Memo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessPaymentRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="amount"></param>
        /// <param name="memo"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProcessPaymentRequest(
            global::System.Guid accountId,
            double amount,
            string memo)
        {
            this.AccountId = accountId;
            this.Amount = amount;
            this.Memo = memo ?? throw new global::System.ArgumentNullException(nameof(memo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessPaymentRequest" /> class.
        /// </summary>
        public ProcessPaymentRequest()
        {
        }
    }
}