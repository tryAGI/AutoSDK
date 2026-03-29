//HintName: G.Models.ForbiddenErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ForbiddenErrorResponse
    {
        /// <summary>
        /// Date of when the error occurred<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Path to the API endpoint<br/>
        /// Example: /v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>/v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Debug id<br/>
        /// Example: G-821fe9df
        /// </summary>
        /// <example>G-821fe9df</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// HTTP status code of the error<br/>
        /// Example: 403
        /// </summary>
        /// <example>403</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StatusCode { get; set; }

        /// <summary>
        /// Forbidden request<br/>
        /// Example: Invalid parameter
        /// </summary>
        /// <example>Invalid parameter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenErrorResponse" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Date of when the error occurred<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="path">
        /// Path to the API endpoint<br/>
        /// Example: /v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="requestId">
        /// Debug id<br/>
        /// Example: G-821fe9df
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code of the error<br/>
        /// Example: 403
        /// </param>
        /// <param name="message">
        /// Forbidden request<br/>
        /// Example: Invalid parameter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForbiddenErrorResponse(
            string timestamp,
            string path,
            string requestId,
            double statusCode,
            string message)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.StatusCode = statusCode;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenErrorResponse" /> class.
        /// </summary>
        public ForbiddenErrorResponse()
        {
        }
    }
}