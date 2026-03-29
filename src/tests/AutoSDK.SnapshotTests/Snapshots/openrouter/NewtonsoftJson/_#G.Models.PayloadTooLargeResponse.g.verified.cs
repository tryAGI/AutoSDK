//HintName: G.Models.PayloadTooLargeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payload Too Large - Request payload exceeds size limits
    /// </summary>
    public sealed partial class PayloadTooLargeResponse
    {
        /// <summary>
        /// Error data for PayloadTooLargeResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PayloadTooLargeResponseErrorData Error { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PayloadTooLargeResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for PayloadTooLargeResponse
        /// </param>
        /// <param name="userId"></param>
        public PayloadTooLargeResponse(
            global::G.PayloadTooLargeResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadTooLargeResponse" /> class.
        /// </summary>
        public PayloadTooLargeResponse()
        {
        }
    }
}