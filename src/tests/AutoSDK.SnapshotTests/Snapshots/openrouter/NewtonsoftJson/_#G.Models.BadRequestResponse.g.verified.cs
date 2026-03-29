//HintName: G.Models.BadRequestResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bad Request - Invalid request parameters or malformed input
    /// </summary>
    public sealed partial class BadRequestResponse
    {
        /// <summary>
        /// Error data for BadRequestResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BadRequestResponseErrorData Error { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="BadRequestResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for BadRequestResponse
        /// </param>
        /// <param name="userId"></param>
        public BadRequestResponse(
            global::G.BadRequestResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestResponse" /> class.
        /// </summary>
        public BadRequestResponse()
        {
        }
    }
}