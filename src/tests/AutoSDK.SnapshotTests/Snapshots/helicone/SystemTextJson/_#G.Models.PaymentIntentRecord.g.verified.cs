//HintName: G.Models.PaymentIntentRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaymentIntentRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRefunded")]
        public bool? IsRefunded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refundedAmount")]
        public double? RefundedAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refundIds")]
        public global::System.Collections.Generic.IList<string>? RefundIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIntentRecord" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <param name="created"></param>
        /// <param name="status"></param>
        /// <param name="isRefunded"></param>
        /// <param name="refundedAmount"></param>
        /// <param name="refundIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentIntentRecord(
            string id,
            double amount,
            double created,
            string status,
            bool? isRefunded,
            double? refundedAmount,
            global::System.Collections.Generic.IList<string>? refundIds)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Amount = amount;
            this.Created = created;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.IsRefunded = isRefunded;
            this.RefundedAmount = refundedAmount;
            this.RefundIds = refundIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIntentRecord" /> class.
        /// </summary>
        public PaymentIntentRecord()
        {
        }
    }
}