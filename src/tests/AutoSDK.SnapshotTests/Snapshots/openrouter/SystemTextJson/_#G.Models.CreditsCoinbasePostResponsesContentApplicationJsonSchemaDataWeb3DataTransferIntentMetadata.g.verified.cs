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
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ChainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contract_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContractAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntentMetadata" /> class.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="contractAddress"></param>
        /// <param name="sender"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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