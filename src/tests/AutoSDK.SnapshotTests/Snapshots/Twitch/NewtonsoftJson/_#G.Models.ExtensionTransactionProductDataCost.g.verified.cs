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
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public int Amount { get; set; } = default!;

        /// <summary>
        /// The type of currency exchanged. Possible values are:  <br/>
        ///   <br/>
        /// * bits
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ExtensionTransactionProductDataCostType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}