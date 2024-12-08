//HintName: G.Models.BetaInvalidRequestError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaInvalidRequestError
    {
        /// <summary>
        /// Default Value: invalid_request_error
        /// </summary>
        /// <default>global::G.BetaInvalidRequestErrorType.InvalidRequestError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaInvalidRequestErrorType Type { get; set; } = global::G.BetaInvalidRequestErrorType.InvalidRequestError;

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
        /// Initializes a new instance of the <see cref="BetaInvalidRequestError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: invalid_request_error
        /// </param>
        /// <param name="message">
        /// Default Value: Invalid request
        /// </param>
        public BetaInvalidRequestError(
            string message,
            global::G.BetaInvalidRequestErrorType type = global::G.BetaInvalidRequestErrorType.InvalidRequestError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInvalidRequestError" /> class.
        /// </summary>
        public BetaInvalidRequestError()
        {
        }
    }
}