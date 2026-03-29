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
        [global::Newtonsoft.Json.JsonProperty("checkoutUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string CheckoutUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudGatewayCheckoutSessionResponse" /> class.
        /// </summary>
        /// <param name="checkoutUrl"></param>
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