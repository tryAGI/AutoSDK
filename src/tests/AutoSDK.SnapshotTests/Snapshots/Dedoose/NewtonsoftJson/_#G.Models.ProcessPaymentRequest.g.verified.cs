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
        [global::Newtonsoft.Json.JsonProperty("accountId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AccountId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memo", Required = global::Newtonsoft.Json.Required.Always)]
        public string Memo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessPaymentRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="amount"></param>
        /// <param name="memo"></param>
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