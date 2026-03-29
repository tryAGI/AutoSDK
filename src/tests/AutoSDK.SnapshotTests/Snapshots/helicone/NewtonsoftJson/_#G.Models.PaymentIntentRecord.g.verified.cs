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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public double Created { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isRefunded")]
        public bool? IsRefunded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refundedAmount")]
        public double? RefundedAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refundIds")]
        public global::System.Collections.Generic.IList<string>? RefundIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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