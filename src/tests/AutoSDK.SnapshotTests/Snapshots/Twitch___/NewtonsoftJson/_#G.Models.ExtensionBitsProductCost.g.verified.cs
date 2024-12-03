//HintName: G.Models.ExtensionBitsProductCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the product's cost information.
    /// </summary>
    public sealed partial class ExtensionBitsProductCost
    {
        /// <summary>
        /// The product's price.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public int Amount { get; set; } = default!;

        /// <summary>
        /// The type of currency. Possible values are:  <br/>
        ///   <br/>
        /// * bits
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ExtensionBitsProductCostType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBitsProductCost" /> class.
        /// </summary>
        /// <param name="amount">
        /// The product's price.
        /// </param>
        /// <param name="type">
        /// The type of currency. Possible values are:  <br/>
        ///   <br/>
        /// * bits
        /// </param>
        public ExtensionBitsProductCost(
            int amount,
            global::G.ExtensionBitsProductCostType type)
        {
            this.Amount = amount;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBitsProductCost" /> class.
        /// </summary>
        public ExtensionBitsProductCost()
        {
        }
    }
}