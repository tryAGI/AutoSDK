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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.ExtensionTransactionProductDataCostTypeJsonConverter))]
        public global::G.ExtensionTransactionProductDataCostType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}