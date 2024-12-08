//HintName: G.Models.InvalidRequestError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvalidRequestError
    {
        /// <summary>
        /// Default Value: invalid_request_error
        /// </summary>
        /// <default>global::G.InvalidRequestErrorType.InvalidRequestError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InvalidRequestErrorType Type { get; set; } = global::G.InvalidRequestErrorType.InvalidRequestError;

        /// <summary>
        /// Default Value: Invalid request
        /// </summary>
        /// <default>"Invalid request"</default>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRequestError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: invalid_request_error
        /// </param>
        /// <param name="message">
        /// Default Value: Invalid request
        /// </param>
        public InvalidRequestError(
            string message,
            global::G.InvalidRequestErrorType type = global::G.InvalidRequestErrorType.InvalidRequestError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRequestError" /> class.
        /// </summary>
        public InvalidRequestError()
        {
        }
    }
}