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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaInvalidRequestErrorTypeJsonConverter))]
        public global::G.BetaInvalidRequestErrorType Type { get; set; } = global::G.BetaInvalidRequestErrorType.InvalidRequestError;

        /// <summary>
        /// Default Value: Invalid request
        /// </summary>
        /// <default>"Invalid request"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Invalid request";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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