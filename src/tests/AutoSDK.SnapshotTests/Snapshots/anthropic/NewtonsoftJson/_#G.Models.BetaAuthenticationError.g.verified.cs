//HintName: G.Models.BetaAuthenticationError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAuthenticationError
    {
        /// <summary>
        /// Default Value: authentication_error
        /// </summary>
        /// <default>global::G.BetaAuthenticationErrorType.AuthenticationError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaAuthenticationErrorType Type { get; set; } = global::G.BetaAuthenticationErrorType.AuthenticationError;

        /// <summary>
        /// Default Value: Authentication error
        /// </summary>
        /// <default>"Authentication error"</default>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAuthenticationError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: authentication_error
        /// </param>
        /// <param name="message">
        /// Default Value: Authentication error
        /// </param>
        public BetaAuthenticationError(
            string message,
            global::G.BetaAuthenticationErrorType type = global::G.BetaAuthenticationErrorType.AuthenticationError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAuthenticationError" /> class.
        /// </summary>
        public BetaAuthenticationError()
        {
        }
    }
}