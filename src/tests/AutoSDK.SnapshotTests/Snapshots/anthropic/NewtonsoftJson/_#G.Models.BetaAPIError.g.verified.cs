//HintName: G.Models.BetaAPIError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAPIError
    {
        /// <summary>
        /// Default Value: api_error
        /// </summary>
        /// <default>global::G.BetaAPIErrorType.ApiError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaAPIErrorType Type { get; set; } = global::G.BetaAPIErrorType.ApiError;

        /// <summary>
        /// Default Value: Internal server error
        /// </summary>
        /// <default>"Internal server error"</default>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAPIError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: api_error
        /// </param>
        /// <param name="message">
        /// Default Value: Internal server error
        /// </param>
        public BetaAPIError(
            string message,
            global::G.BetaAPIErrorType type = global::G.BetaAPIErrorType.ApiError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAPIError" /> class.
        /// </summary>
        public BetaAPIError()
        {
        }
    }
}