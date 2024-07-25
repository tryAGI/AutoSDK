//HintName: G.Models.StripeCustomerAddress.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Stripe customer address.
    /// </summary>
    public sealed partial class StripeCustomerAddress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Line1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line2")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::System.AnyOf<string?, object?>? Line2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::System.AnyOf<string?, object?>? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postal_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}