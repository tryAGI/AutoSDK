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
        [global::Newtonsoft.Json.JsonProperty("client_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientSecret { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeSetupIntentResponse" /> class.
        /// </summary>
        /// <param name="clientSecret"></param>
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