//HintName: G.Models.CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chain_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double ChainId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contract_address", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContractAddress { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sender { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentMetadata" /> class.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="contractAddress"></param>
        /// <param name="sender"></param>
        public CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentMetadata(
            double chainId,
            string contractAddress,
            string sender)
        {
            this.ChainId = chainId;
            this.ContractAddress = contractAddress ?? throw new global::System.ArgumentNullException(nameof(contractAddress));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentMetadata" /> class.
        /// </summary>
        public CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentMetadata()
        {
        }
    }
}