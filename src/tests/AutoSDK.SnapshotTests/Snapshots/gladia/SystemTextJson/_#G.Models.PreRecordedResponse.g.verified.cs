//HintName: G.Models.PreRecordedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreRecordedResponse
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Debug id<br/>
        /// Example: G-45463597
        /// </summary>
        /// <example>G-45463597</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// API version<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// "queued": the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PreRecordedResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PreRecordedResponseStatus Status { get; set; }

        /// <summary>
        /// Creation date<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Completion date when status is "done" or "error"<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Custom metadata given in the initial request<br/>
        /// Example: {"user":"John Doe"}
        /// </summary>
        /// <example>{"user":"John Doe"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// HTTP status code of the error if status is "error"<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// For debugging purposes, send data that could help to identify issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_session_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object PostSessionMetadata { get; set; }

        /// <summary>
        /// Default Value: pre-recorded<br/>
        /// Example: pre-recorded
        /// </summary>
        /// <default>global::G.PreRecordedResponseKind.PreRecorded</default>
        /// <example>pre-recorded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PreRecordedResponseKindJsonConverter))]
        public global::G.PreRecordedResponseKind Kind { get; set; } = global::G.PreRecordedResponseKind.PreRecorded;

        /// <summary>
        /// The file data you uploaded. Can be null if status is "error"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::G.FileResponse? File { get; set; }

        /// <summary>
        /// Parameters used for this pre-recorded transcription. Can be null if status is "error"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_params")]
        public global::G.PreRecordedRequestParamsResponse? RequestParams { get; set; }

        /// <summary>
        /// Pre-recorded transcription's result when status is "done"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.TranscriptionResultDTO? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreRecordedResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="requestId">
        /// Debug id<br/>
        /// Example: G-45463597
        /// </param>
        /// <param name="version">
        /// API version<br/>
        /// Example: 2
        /// </param>
        /// <param name="status">
        /// "queued": the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </param>
        /// <param name="createdAt">
        /// Creation date<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="postSessionMetadata">
        /// For debugging purposes, send data that could help to identify issues
        /// </param>
        /// <param name="completedAt">
        /// Completion date when status is "done" or "error"<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata given in the initial request<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="errorCode">
        /// HTTP status code of the error if status is "error"<br/>
        /// Example: 500
        /// </param>
        /// <param name="file">
        /// The file data you uploaded. Can be null if status is "error"
        /// </param>
        /// <param name="requestParams">
        /// Parameters used for this pre-recorded transcription. Can be null if status is "error"
        /// </param>
        /// <param name="result">
        /// Pre-recorded transcription's result when status is "done"
        /// </param>
        /// <param name="kind">
        /// Default Value: pre-recorded<br/>
        /// Example: pre-recorded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreRecordedResponse(
            global::System.Guid id,
            string requestId,
            int version,
            global::G.PreRecordedResponseStatus status,
            global::System.DateTime createdAt,
            object postSessionMetadata,
            global::System.DateTime? completedAt,
            object? customMetadata,
            int? errorCode,
            global::G.FileResponse? file,
            global::G.PreRecordedRequestParamsResponse? requestParams,
            global::G.TranscriptionResultDTO? result,
            global::G.PreRecordedResponseKind kind = global::G.PreRecordedResponseKind.PreRecorded)
        {
            this.Id = id;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Version = version;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.CustomMetadata = customMetadata;
            this.ErrorCode = errorCode;
            this.PostSessionMetadata = postSessionMetadata ?? throw new global::System.ArgumentNullException(nameof(postSessionMetadata));
            this.Kind = kind;
            this.File = file;
            this.RequestParams = requestParams;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreRecordedResponse" /> class.
        /// </summary>
        public PreRecordedResponse()
        {
        }
    }
}