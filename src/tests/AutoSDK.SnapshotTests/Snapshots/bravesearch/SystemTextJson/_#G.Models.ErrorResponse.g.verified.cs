//HintName: G.Models.ErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error response from the API.
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Error identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// HTTP status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Detailed error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Error identifier.
        /// </param>
        /// <param name="type">
        /// Error type.
        /// </param>
        /// <param name="status">
        /// HTTP status code.
        /// </param>
        /// <param name="code">
        /// Error code.
        /// </param>
        /// <param name="detail">
        /// Detailed error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            string? id,
            string? type,
            int? status,
            string? code,
            string? detail)
        {
            this.Id = id;
            this.Type = type;
            this.Status = status;
            this.Code = code;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}