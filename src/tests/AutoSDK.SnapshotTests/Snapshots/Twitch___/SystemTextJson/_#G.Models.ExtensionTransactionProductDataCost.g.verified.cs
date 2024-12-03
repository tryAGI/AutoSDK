//HintName: G.Models.ExtensionTransactionProductDataCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains details about the digital product’s cost.
    /// </summary>
    public sealed partial class ExtensionTransactionProductDataCost
    {
        /// <summary>
        /// The amount exchanged for the digital product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// The type of currency exchanged. Possible values are:  <br/>
        ///   <br/>
        /// * bits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtensionTransactionProductDataCostTypeJsonConverter))]
        public global::G.ExtensionTransactionProductDataCostType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionTransactionProductDataCost" /> class.
        /// </summary>
        /// <param name="amount">
        /// The amount exchanged for the digital product.
        /// </param>
        /// <param name="type">
        /// The type of currency exchanged. Possible values are:  <br/>
        ///   <br/>
        /// * bits
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ExtensionTransactionProductDataCost(
            int amount,
            global::G.ExtensionTransactionProductDataCostType type)
        {
            this.Amount = amount;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionTransactionProductDataCost" /> class.
        /// </summary>
        public ExtensionTransactionProductDataCost()
        {
        }
    }
}