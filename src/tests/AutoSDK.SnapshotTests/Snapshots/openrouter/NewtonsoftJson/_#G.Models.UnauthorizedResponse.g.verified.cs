//HintName: G.Models.UnauthorizedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unauthorized - Authentication required or invalid credentials
    /// </summary>
    public sealed partial class UnauthorizedResponse
    {
        /// <summary>
        /// Error data for UnauthorizedResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UnauthorizedResponseErrorData Error { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="UnauthorizedResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for UnauthorizedResponse
        /// </param>
        /// <param name="userId"></param>
        public UnauthorizedResponse(
            global::G.UnauthorizedResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedResponse" /> class.
        /// </summary>
        public UnauthorizedResponse()
        {
        }
    }
}