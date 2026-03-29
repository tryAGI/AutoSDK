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
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// Path to the API endpoint<br/>
        /// Example: /v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>/v2/transcription/45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Debug id<br/>
        /// Example: G-821fe9df
        /// </summary>
        /// <example>G-821fe9df</example>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// HTTP status code of the error<br/>
        /// Example: 403
        /// </summary>
        /// <example>403</example>
        [global::Newtonsoft.Json.JsonProperty("statusCode", Required = global::Newtonsoft.Json.Required.Always)]
        public double StatusCode { get; set; } = default!;

        /// <summary>
        /// Forbidden request<br/>
        /// Example: Invalid parameter
        /// </summary>
        /// <example>Invalid parameter</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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