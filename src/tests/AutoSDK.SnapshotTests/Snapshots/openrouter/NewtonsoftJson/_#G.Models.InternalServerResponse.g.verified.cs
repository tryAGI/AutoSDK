//HintName: G.Models.InternalServerResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Internal Server Error - Unexpected server error
    /// </summary>
    public sealed partial class InternalServerResponse
    {
        /// <summary>
        /// Error data for InternalServerResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InternalServerResponseErrorData Error { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="InternalServerResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for InternalServerResponse
        /// </param>
        /// <param name="userId"></param>
        public InternalServerResponse(
            global::G.InternalServerResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalServerResponse" /> class.
        /// </summary>
        public InternalServerResponse()
        {
        }
    }
}