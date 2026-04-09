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
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sender { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chain_id", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateChargeRequestChainIdJsonConverter))]
        public global::G.CreateChargeRequestChainId ChainId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChargeRequest" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="sender"></param>
        /// <param name="chainId"></param>
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