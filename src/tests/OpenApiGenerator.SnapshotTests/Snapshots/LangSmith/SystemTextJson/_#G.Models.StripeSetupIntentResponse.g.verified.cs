//HintName: G.Models.StripeSetupIntentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stripe setup intent response.
    /// </summary>
    public sealed partial class StripeSetupIntentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}