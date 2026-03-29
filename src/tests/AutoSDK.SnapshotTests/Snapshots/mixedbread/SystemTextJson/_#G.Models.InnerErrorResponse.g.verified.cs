//HintName: G.Models.InnerErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inner Error Pydantic Response Service Message
    /// </summary>
    public sealed partial class InnerErrorResponse
    {
        /// <summary>
        /// The error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The error code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// The error type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InnerErrorResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message
        /// </param>
        /// <param name="code">
        /// The error code
        /// </param>
        /// <param name="type">
        /// The error type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InnerErrorResponse(
            string message,
            int code,
            string type)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InnerErrorResponse" /> class.
        /// </summary>
        public InnerErrorResponse()
        {
        }
    }
}