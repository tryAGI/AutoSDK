//HintName: G.Models.RequestTimeoutResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request Timeout - Operation exceeded time limit
    /// </summary>
    public sealed partial class RequestTimeoutResponse
    {
        /// <summary>
        /// Error data for RequestTimeoutResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RequestTimeoutResponseErrorData Error { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="RequestTimeoutResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for RequestTimeoutResponse
        /// </param>
        /// <param name="userId"></param>
        public RequestTimeoutResponse(
            global::G.RequestTimeoutResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTimeoutResponse" /> class.
        /// </summary>
        public RequestTimeoutResponse()
        {
        }
    }
}