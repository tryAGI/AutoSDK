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
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("returnUrl")]
        public string? ReturnUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCloudGatewayCheckoutSessionRequest" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="returnUrl"></param>
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