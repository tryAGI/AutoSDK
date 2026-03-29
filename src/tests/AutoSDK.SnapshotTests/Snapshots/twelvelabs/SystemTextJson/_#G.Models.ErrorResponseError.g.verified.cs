//HintName: G.Models.ErrorResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponseError
    {
        /// <summary>
        /// A string representing the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable string describing the error, intended to be suitable for display in a user interface.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional error details (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public object? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        /// <param name="code">
        /// A string representing the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </param>
        /// <param name="message">
        /// A human-readable string describing the error, intended to be suitable for display in a user interface.
        /// </param>
        /// <param name="details">
        /// Additional error details (optional)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponseError(
            string code,
            string message,
            object? details)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        public ErrorResponseError()
        {
        }
    }
}