//HintName: G.Models.CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentCallData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentCallData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deadline", Required = global::Newtonsoft.Json.Required.Always)]
        public string Deadline { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fee_amount", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeeAmount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public string Operator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prefix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recipient", Required = global::Newtonsoft.Json.Required.Always)]
        public string Recipient { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recipient_amount", Required = global::Newtonsoft.Json.Required.Always)]
        public string RecipientAmount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recipient_currency", Required = global::Newtonsoft.Json.Required.Always)]
        public string RecipientCurrency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refund_destination", Required = global::Newtonsoft.Json.Required.Always)]
        public string RefundDestination { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature", Required = global::Newtonsoft.Json.Required.Always)]
        public string Signature { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentCallData" /> class.
        /// </summary>
        /// <param name="deadline"></param>
        /// <param name="feeAmount"></param>
        /// <param name="id"></param>
        /// <param name="operator"></param>
        /// <param name="prefix"></param>
        /// <param name="recipient"></param>
        /// <param name="recipientAmount"></param>
        /// <param name="recipientCurrency"></param>
        /// <param name="refundDestination"></param>
        /// <param name="signature"></param>
        public CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentCallData(
            string deadline,
            string feeAmount,
            string id,
            string @operator,
            string prefix,
            string recipient,
            string recipientAmount,
            string recipientCurrency,
            string refundDestination,
            string signature)
        {
            this.Deadline = deadline ?? throw new global::System.ArgumentNullException(nameof(deadline));
            this.FeeAmount = feeAmount ?? throw new global::System.ArgumentNullException(nameof(feeAmount));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
            this.Recipient = recipient ?? throw new global::System.ArgumentNullException(nameof(recipient));
            this.RecipientAmount = recipientAmount ?? throw new global::System.ArgumentNullException(nameof(recipientAmount));
            this.RecipientCurrency = recipientCurrency ?? throw new global::System.ArgumentNullException(nameof(recipientCurrency));
            this.RefundDestination = refundDestination ?? throw new global::System.ArgumentNullException(nameof(refundDestination));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentCallData" /> class.
        /// </summary>
        public CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentCallData()
        {
        }
    }
}