//HintName: G.Models.BadGatewayResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bad Gateway - Provider/upstream API failure
    /// </summary>
    public sealed partial class BadGatewayResponse
    {
        /// <summary>
        /// Error data for BadGatewayResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BadGatewayResponseErrorData Error { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BadGatewayResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for BadGatewayResponse
        /// </param>
        /// <param name="userId"></param>
        public BadGatewayResponse(
            global::G.BadGatewayResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadGatewayResponse" /> class.
        /// </summary>
        public BadGatewayResponse()
        {
        }
    }
}