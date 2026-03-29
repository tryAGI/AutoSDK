//HintName: G.Models.CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3Data.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_intent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntent TransferIntent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3Data" /> class.
        /// </summary>
        /// <param name="transferIntent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3Data(
            global::G.CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3DataTransferIntent transferIntent)
        {
            this.TransferIntent = transferIntent ?? throw new global::System.ArgumentNullException(nameof(transferIntent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3Data" /> class.
        /// </summary>
        public CreditsCoinbasePostResponsesContentApplicationJsonSchemaDataWeb3Data()
        {
        }
    }
}