//HintName: G.Models.ResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An error object returned when the model fails to generate a Response.
    /// </summary>
    public sealed partial class ResponseError
    {
        /// <summary>
        /// The error code for the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseErrorCode Code { get; set; } = default!;

        /// <summary>
        /// A human-readable description of the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseError" /> class.
        /// </summary>
        /// <param name="code">
        /// The error code for the response.
        /// </param>
        /// <param name="message">
        /// A human-readable description of the error.
        /// </param>
        public ResponseError(
            global::G.ResponseErrorCode code,
            string message)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseError" /> class.
        /// </summary>
        public ResponseError()
        {
        }
    }
}