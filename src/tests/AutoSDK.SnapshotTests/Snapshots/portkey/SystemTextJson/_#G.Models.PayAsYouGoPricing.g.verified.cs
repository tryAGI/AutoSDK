//HintName: G.Models.PayAsYouGoPricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayAsYouGoPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_token")]
        public global::G.TokenPricing? RequestToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_token")]
        public global::G.TokenPricing? ResponseToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayAsYouGoPricing" /> class.
        /// </summary>
        /// <param name="requestToken"></param>
        /// <param name="responseToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayAsYouGoPricing(
            global::G.TokenPricing? requestToken,
            global::G.TokenPricing? responseToken)
        {
            this.RequestToken = requestToken;
            this.ResponseToken = responseToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayAsYouGoPricing" /> class.
        /// </summary>
        public PayAsYouGoPricing()
        {
        }
    }
}