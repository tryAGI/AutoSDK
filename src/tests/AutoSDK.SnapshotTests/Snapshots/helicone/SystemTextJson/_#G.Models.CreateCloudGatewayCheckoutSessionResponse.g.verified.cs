//HintName: G.Models.CreateCloudGatewayCheckoutSessionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCloudGatewayCheckoutSessionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkoutUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckoutUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudGatewayCheckoutSessionResponse" /> class.
        /// </summary>
        /// <param name="checkoutUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCloudGatewayCheckoutSessionResponse(
            string checkoutUrl)
        {
            this.CheckoutUrl = checkoutUrl ?? throw new global::System.ArgumentNullException(nameof(checkoutUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudGatewayCheckoutSessionResponse" /> class.
        /// </summary>
        public CreateCloudGatewayCheckoutSessionResponse()
        {
        }
    }
}