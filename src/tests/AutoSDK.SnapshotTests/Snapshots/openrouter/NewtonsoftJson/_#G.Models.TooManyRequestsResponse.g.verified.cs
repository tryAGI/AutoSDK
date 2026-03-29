//HintName: G.Models.TooManyRequestsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Too Many Requests - Rate limit exceeded
    /// </summary>
    public sealed partial class TooManyRequestsResponse
    {
        /// <summary>
        /// Error data for TooManyRequestsResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TooManyRequestsResponseErrorData Error { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="TooManyRequestsResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for TooManyRequestsResponse
        /// </param>
        /// <param name="userId"></param>
        public TooManyRequestsResponse(
            global::G.TooManyRequestsResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequestsResponse" /> class.
        /// </summary>
        public TooManyRequestsResponse()
        {
        }
    }
}