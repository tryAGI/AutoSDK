//HintName: G.Models.TransactionInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransactionInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exchangeRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ExchangeRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ReferenceAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceCurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ReferenceCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceExchangeRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ReferenceExchangeRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TransactionAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionCurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TransactionCurrency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInfo" /> class.
        /// </summary>
        /// <param name="exchangeRate"></param>
        /// <param name="referenceAmount"></param>
        /// <param name="referenceCurrency"></param>
        /// <param name="referenceExchangeRate"></param>
        /// <param name="transactionAmount"></param>
        /// <param name="transactionCurrency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransactionInfo(
            string? exchangeRate,
            string? referenceAmount,
            string? referenceCurrency,
            string? referenceExchangeRate,
            string? transactionAmount,
            string? transactionCurrency)
        {
            this.ExchangeRate = exchangeRate ?? throw new global::System.ArgumentNullException(nameof(exchangeRate));
            this.ReferenceAmount = referenceAmount ?? throw new global::System.ArgumentNullException(nameof(referenceAmount));
            this.ReferenceCurrency = referenceCurrency ?? throw new global::System.ArgumentNullException(nameof(referenceCurrency));
            this.ReferenceExchangeRate = referenceExchangeRate ?? throw new global::System.ArgumentNullException(nameof(referenceExchangeRate));
            this.TransactionAmount = transactionAmount ?? throw new global::System.ArgumentNullException(nameof(transactionAmount));
            this.TransactionCurrency = transactionCurrency ?? throw new global::System.ArgumentNullException(nameof(transactionCurrency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInfo" /> class.
        /// </summary>
        public TransactionInfo()
        {
        }
    }
}