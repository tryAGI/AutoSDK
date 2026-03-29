//HintName: G.Models.UnprocessableEntityResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unprocessable Entity - Semantic validation failure
    /// </summary>
    public sealed partial class UnprocessableEntityResponse
    {
        /// <summary>
        /// Error data for UnprocessableEntityResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UnprocessableEntityResponseErrorData Error { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="UnprocessableEntityResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for UnprocessableEntityResponse
        /// </param>
        /// <param name="userId"></param>
        public UnprocessableEntityResponse(
            global::G.UnprocessableEntityResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnprocessableEntityResponse" /> class.
        /// </summary>
        public UnprocessableEntityResponse()
        {
        }
    }
}