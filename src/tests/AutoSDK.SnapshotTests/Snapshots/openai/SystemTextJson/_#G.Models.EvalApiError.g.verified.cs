//HintName: G.Models.EvalApiError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object representing an error response from the Eval API.
    /// </summary>
    public sealed partial class EvalApiError
    {
        /// <summary>
        /// The error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalApiError" /> class.
        /// </summary>
        /// <param name="code">
        /// The error code.
        /// </param>
        /// <param name="message">
        /// The error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalApiError(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalApiError" /> class.
        /// </summary>
        public EvalApiError()
        {
        }
    }
}