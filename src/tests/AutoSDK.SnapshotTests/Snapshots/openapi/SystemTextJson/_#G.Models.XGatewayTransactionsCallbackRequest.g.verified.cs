//HintName: G.Models.XGatewayTransactionsCallbackRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class XGatewayTransactionsCallbackRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CallbackType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Network { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionHash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TransactionHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransactionInfo? Info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fees")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FeesInfo? Fees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eur")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Eur { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Usd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XGatewayTransactionsCallbackRequest" /> class.
        /// </summary>
        /// <param name="callbackType"></param>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
        /// <param name="customerId"></param>
        /// <param name="hash"></param>
        /// <param name="id"></param>
        /// <param name="network"></param>
        /// <param name="status"></param>
        /// <param name="transactionHash"></param>
        /// <param name="type"></param>
        /// <param name="info"></param>
        /// <param name="fees"></param>
        /// <param name="eur"></param>
        /// <param name="usd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XGatewayTransactionsCallbackRequest(
            string? callbackType,
            string amount,
            string currency,
            string customerId,
            string? hash,
            string id,
            string? network,
            string? status,
            string? transactionHash,
            string? type,
            global::G.TransactionInfo? info,
            global::G.FeesInfo? fees,
            string? eur,
            string? usd)
        {
            this.CallbackType = callbackType ?? throw new global::System.ArgumentNullException(nameof(callbackType));
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.CustomerId = customerId ?? throw new global::System.ArgumentNullException(nameof(customerId));
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Network = network ?? throw new global::System.ArgumentNullException(nameof(network));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TransactionHash = transactionHash ?? throw new global::System.ArgumentNullException(nameof(transactionHash));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Info = info ?? throw new global::System.ArgumentNullException(nameof(info));
            this.Fees = fees ?? throw new global::System.ArgumentNullException(nameof(fees));
            this.Eur = eur ?? throw new global::System.ArgumentNullException(nameof(eur));
            this.Usd = usd ?? throw new global::System.ArgumentNullException(nameof(usd));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XGatewayTransactionsCallbackRequest" /> class.
        /// </summary>
        public XGatewayTransactionsCallbackRequest()
        {
        }
    }
}