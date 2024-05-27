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
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// The type of currency. Possible values are:  
        ///   
        /// * bits — The minimum price is 1 and the maximum is 10000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}