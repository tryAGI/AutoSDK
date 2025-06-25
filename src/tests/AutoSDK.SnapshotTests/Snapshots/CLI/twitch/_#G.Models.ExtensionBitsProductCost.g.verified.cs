﻿//HintName: G.Models.ExtensionBitsProductCost.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// The type of currency. Possible values are:  <br/>
        ///   <br/>
        /// * bits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtensionBitsProductCostTypeJsonConverter))]
        public global::G.ExtensionBitsProductCostType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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