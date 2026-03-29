//HintName: G.Models.CreateChargeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a Coinbase charge for crypto payment
    /// </summary>
    public sealed partial class CreateChargeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateChargeRequestChainIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateChargeRequestChainId ChainId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChargeRequest" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="sender"></param>
        /// <param name="chainId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChargeRequest(
            double amount,
            string sender,
            global::G.CreateChargeRequestChainId chainId)
        {
            this.Amount = amount;
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.ChainId = chainId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChargeRequest" /> class.
        /// </summary>
        public CreateChargeRequest()
        {
        }
    }
}