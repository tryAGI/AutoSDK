//HintName: G.Models.AuthenticationError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthenticationError
    {
        /// <summary>
        /// Default Value: authentication_error
        /// </summary>
        /// <default>global::G.AuthenticationErrorType.AuthenticationError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AuthenticationErrorType Type { get; set; } = global::G.AuthenticationErrorType.AuthenticationError;

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
        /// Initializes a new instance of the <see cref="AuthenticationError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: authentication_error
        /// </param>
        /// <param name="message">
        /// Default Value: Authentication error
        /// </param>
        public AuthenticationError(
            string message,
            global::G.AuthenticationErrorType type = global::G.AuthenticationErrorType.AuthenticationError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationError" /> class.
        /// </summary>
        public AuthenticationError()
        {
        }
    }
}