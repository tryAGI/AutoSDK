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
        [global::System.Text.Json.Serialization.JsonPropertyName("deadline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Deadline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fee_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeeAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Recipient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecipientAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient_currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecipientCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refund_destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefundDestination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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