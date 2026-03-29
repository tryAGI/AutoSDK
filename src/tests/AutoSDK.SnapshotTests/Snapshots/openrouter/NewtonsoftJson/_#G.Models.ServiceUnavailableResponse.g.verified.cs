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
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ServiceUnavailableResponseErrorData Error { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ServiceUnavailableResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for ServiceUnavailableResponse
        /// </param>
        /// <param name="userId"></param>
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