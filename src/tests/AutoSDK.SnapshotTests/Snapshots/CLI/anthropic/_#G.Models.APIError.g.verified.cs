//HintName: G.Models.APIError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIError
    {
        /// <summary>
        /// Default Value: api_error
        /// </summary>
        /// <default>global::G.APIErrorType.ApiError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.APIErrorTypeJsonConverter))]
        public global::G.APIErrorType Type { get; set; } = global::G.APIErrorType.ApiError;

        /// <summary>
        /// Default Value: Internal server error
        /// </summary>
        /// <default>"Internal server error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Internal server error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: api_error
        /// </param>
        /// <param name="message">
        /// Default Value: Internal server error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIError(
            string message,
            global::G.APIErrorType type = global::G.APIErrorType.ApiError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIError" /> class.
        /// </summary>
        public APIError()
        {
        }
    }
}