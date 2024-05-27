//HintName: G.Models.ExtensionTransactionProductData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains details about the digital product.
    /// </summary>
    public sealed partial class ExtensionTransactionProductData
    {
        /// <summary>
        /// An ID that identifies the digital product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sku { get; set; }

        /// <summary>
        /// Set to `twitch.ext.` \+ `&lt;the extension's ID&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Contains details about the digital product’s cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ExtensionTransactionProductDataCost Cost { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the product is in development. Is **true** if the digital product is in development and cannot be exchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inDevelopment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InDevelopment { get; set; }

        /// <summary>
        /// The name of the digital product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// This field is always empty since you may purchase only unexpired products.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expiration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the data was broadcast to all instances of the extension. Is **true** if the data was broadcast to all instances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Broadcast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}