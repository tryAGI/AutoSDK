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
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PayloadTooLargeResponseErrorData Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadTooLargeResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for PayloadTooLargeResponse
        /// </param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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