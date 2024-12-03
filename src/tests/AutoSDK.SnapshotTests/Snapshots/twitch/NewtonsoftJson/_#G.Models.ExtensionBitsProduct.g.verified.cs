//HintName: G.Models.ExtensionBitsProduct.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtensionBitsProduct
    {
        /// <summary>
        /// The product's SKU. The SKU is unique across an extension's products.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sku", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sku { get; set; } = default!;

        /// <summary>
        /// An object that contains the product's cost information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionBitsProductCost Cost { get; set; } = default!;

        /// <summary>
        /// A Boolean value that indicates whether the product is in development. If **true**, the product is not available for public use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_development", Required = global::Newtonsoft.Json.Required.Always)]
        public bool InDevelopment { get; set; } = default!;

        /// <summary>
        /// The product's name as displayed in the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// The date and time, in RFC3339 format, when the product expires.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiration", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Expiration { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether Bits product purchase events are broadcast to all instances of an extension on a channel. The events are broadcast via the `onTransactionComplete` helper callback. Is **true** if the event is broadcast to all instances.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_broadcast", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsBroadcast { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBitsProduct" /> class.
        /// </summary>
        /// <param name="sku">
        /// The product's SKU. The SKU is unique across an extension's products.
        /// </param>
        /// <param name="cost">
        /// An object that contains the product's cost information.
        /// </param>
        /// <param name="inDevelopment">
        /// A Boolean value that indicates whether the product is in development. If **true**, the product is not available for public use.
        /// </param>
        /// <param name="displayName">
        /// The product's name as displayed in the extension.
        /// </param>
        /// <param name="expiration">
        /// The date and time, in RFC3339 format, when the product expires.
        /// </param>
        /// <param name="isBroadcast">
        /// A Boolean value that determines whether Bits product purchase events are broadcast to all instances of an extension on a channel. The events are broadcast via the `onTransactionComplete` helper callback. Is **true** if the event is broadcast to all instances.
        /// </param>
        public ExtensionBitsProduct(
            string sku,
            global::G.ExtensionBitsProductCost cost,
            bool inDevelopment,
            string displayName,
            global::System.DateTime expiration,
            bool isBroadcast)
        {
            this.Sku = sku ?? throw new global::System.ArgumentNullException(nameof(sku));
            this.Cost = cost ?? throw new global::System.ArgumentNullException(nameof(cost));
            this.InDevelopment = inDevelopment;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Expiration = expiration;
            this.IsBroadcast = isBroadcast;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBitsProduct" /> class.
        /// </summary>
        public ExtensionBitsProduct()
        {
        }
    }
}