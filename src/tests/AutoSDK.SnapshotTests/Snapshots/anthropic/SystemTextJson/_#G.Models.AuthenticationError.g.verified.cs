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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthenticationErrorTypeJsonConverter))]
        public global::G.AuthenticationErrorType Type { get; set; } = global::G.AuthenticationErrorType.AuthenticationError;

        /// <summary>
        /// Default Value: Authentication error
        /// </summary>
        /// <default>"Authentication error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Authentication error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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