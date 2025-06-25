//HintName: G.Models.UpdateExtensionBitsProductBodyCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the product's cost information.
    /// </summary>
    public sealed partial class UpdateExtensionBitsProductBodyCost
    {
        /// <summary>
        /// The product's price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// The type of currency. Possible values are:  <br/>
        ///   <br/>
        /// * bits — The minimum price is 1 and the maximum is 10000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateExtensionBitsProductBodyCostTypeJsonConverter))]
        public global::G.UpdateExtensionBitsProductBodyCostType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExtensionBitsProductBodyCost" /> class.
        /// </summary>
        /// <param name="amount">
        /// The product's price.
        /// </param>
        /// <param name="type">
        /// The type of currency. Possible values are:  <br/>
        ///   <br/>
        /// * bits — The minimum price is 1 and the maximum is 10000.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateExtensionBitsProductBodyCost(
            int amount,
            global::G.UpdateExtensionBitsProductBodyCostType type)
        {
            this.Amount = amount;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExtensionBitsProductBodyCost" /> class.
        /// </summary>
        public UpdateExtensionBitsProductBodyCost()
        {
        }
    }
}