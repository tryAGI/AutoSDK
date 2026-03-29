//HintName: G.Models.ServiceUnavailableResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Service Unavailable - Service temporarily unavailable
    /// </summary>
    public sealed partial class ServiceUnavailableResponse
    {
        /// <summary>
        /// Error data for ServiceUnavailableResponse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ServiceUnavailableResponseErrorData Error { get; set; }

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
        /// Initializes a new instance of the <see cref="ServiceUnavailableResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for ServiceUnavailableResponse
        /// </param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceUnavailableResponse(
            global::G.ServiceUnavailableResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceUnavailableResponse" /> class.
        /// </summary>
        public ServiceUnavailableResponse()
        {
        }
    }
}