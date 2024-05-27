//HintName: G.Models.UpdateExtensionBitsProductRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExtensionBitsProductRequest
    {
        /// <summary>
        /// The product's SKU. The SKU must be unique within an extension. The product's SKU cannot be changed. The SKU may contain only alphanumeric characters, dashes (-), underscores (\_), and periods (.) and is limited to a maximum of 255 characters. No spaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sku { get; set; }

        /// <summary>
        /// An object that contains the product's cost information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required UpdateExtensionBitsProductRequestCost Cost { get; set; }

        /// <summary>
        /// The product's name as displayed in the extension. The maximum length is 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether the product is in development. Set to **true** if the product is in development and not available for public use. The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_development")]
        public bool InDevelopment { get; set; }

        /// <summary>
        /// The date and time, in RFC3339 format, when the product expires. If not set, the product does not expire. To disable the product, set the expiration date to a date in the past.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public global::System.DateTime Expiration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether Bits product purchase events are broadcast to all instances of the extension on a channel. The events are broadcast via the `onTransactionComplete` helper callback. The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_broadcast")]
        public bool IsBroadcast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}