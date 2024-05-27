//HintName: G.Models.UpdateExtensionBitsProductRequestCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the product's cost information.
    /// </summary>
    public sealed partial class UpdateExtensionBitsProductRequestCost
    {
        /// <summary>
        /// The product's price.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public int Amount { get; set; } = default!;

        /// <summary>
        /// The type of currency. Possible values are:  
        ///   
        /// * bits — The minimum price is 1 and the maximum is 10000.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public UpdateExtensionBitsProductRequestCostType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}