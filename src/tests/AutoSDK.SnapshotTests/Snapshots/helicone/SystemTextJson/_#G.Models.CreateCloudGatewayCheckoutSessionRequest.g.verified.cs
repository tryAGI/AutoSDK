//HintName: G.Models.CreateCloudGatewayCheckoutSessionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCloudGatewayCheckoutSessionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudGatewayCheckoutSessionRequest" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="returnUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCloudGatewayCheckoutSessionRequest(
            double amount,
            string? returnUrl)
        {
            this.Amount = amount;
            this.ReturnUrl = returnUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudGatewayCheckoutSessionRequest" /> class.
        /// </summary>
        public CreateCloudGatewayCheckoutSessionRequest()
        {
        }
    }
}