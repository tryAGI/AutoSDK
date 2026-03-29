//HintName: G.Models.BadRequestErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BadRequestErrorResponse
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
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("statusCode", Required = global::Newtonsoft.Json.Required.Always)]
        public double StatusCode { get; set; } = default!;

        /// <summary>
        /// Error message<br/>
        /// Example: Content-Type is missing Multipart Boundary.
        /// </summary>
        /// <example>Content-Type is missing Multipart Boundary.</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// List of validation errors, if any<br/>
        /// Example: [Field "language" must be a string, Field "min_speakers" must be a number]
        /// </summary>
        /// <example>[Field "language" must be a string, Field "min_speakers" must be a number]</example>
        [global::Newtonsoft.Json.JsonProperty("validation_errors")]
        public global::System.Collections.Generic.IList<string>? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestErrorResponse" /> class.
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
        /// Example: 400
        /// </param>
        /// <param name="message">
        /// Error message<br/>
        /// Example: Content-Type is missing Multipart Boundary.
        /// </param>
        /// <param name="validationErrors">
        /// List of validation errors, if any<br/>
        /// Example: [Field "language" must be a string, Field "min_speakers" must be a number]
        /// </param>
        public BadRequestErrorResponse(
            string timestamp,
            string path,
            string requestId,
            double statusCode,
            string message,
            global::System.Collections.Generic.IList<string>? validationErrors)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.StatusCode = statusCode;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestErrorResponse" /> class.
        /// </summary>
        public BadRequestErrorResponse()
        {
        }
    }
}