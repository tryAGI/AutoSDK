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

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeSetupIntentResponse" /> class.
        /// </summary>
        /// <param name="clientSecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripeSetupIntentResponse(
            string clientSecret)
        {
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeSetupIntentResponse" /> class.
        /// </summary>
        public StripeSetupIntentResponse()
        {
        }
    }
}