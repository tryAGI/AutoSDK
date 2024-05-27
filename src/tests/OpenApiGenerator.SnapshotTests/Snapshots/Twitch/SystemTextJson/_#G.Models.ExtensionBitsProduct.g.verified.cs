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
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sku { get; set; }

        /// <summary>
        /// An object that contains the product's cost information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ExtensionBitsProductCost Cost { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether the product is in development. If **true**, the product is not available for public use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_development")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InDevelopment { get; set; }

        /// <summary>
        /// The product's name as displayed in the extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The date and time, in RFC3339 format, when the product expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Expiration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether Bits product purchase events are broadcast to all instances of an extension on a channel. The events are broadcast via the `onTransactionComplete` helper callback. Is **true** if the event is broadcast to all instances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_broadcast")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBroadcast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}