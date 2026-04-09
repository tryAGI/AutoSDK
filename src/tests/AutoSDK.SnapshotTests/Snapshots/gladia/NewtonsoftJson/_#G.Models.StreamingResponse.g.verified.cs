//HintName: G.Models.StreamingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingResponse
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Debug id<br/>
        /// Example: G-45463597
        /// </summary>
        /// <example>G-45463597</example>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// API version<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// "queued": the job has been queued. "processing": the job is being processed. "done": the job has been processed and the result is available. "error": an error occurred during the job's processing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StreamingResponseStatusJsonConverter))]
        public global::G.StreamingResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// Creation date<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Completion date when status is "done" or "error"<br/>
        /// Example: 2024-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2024-01-01T00:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Custom metadata given in the initial request<br/>
        /// Example: {"user":"John Doe"}
        /// </summary>
        /// <example>{"user":"John Doe"}</example>
        [global::Newtonsoft.Json.JsonProperty("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// HTTP status code of the error if status is "error"<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::Newtonsoft.Json.JsonProperty("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// For debugging purposes, send data that could help to identify issues
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_session_metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object PostSessionMetadata { get; set; } = default!;

        /// <summary>
        /// Default Value: live<br/>
        /// Example: live
        /// </summary>
        /// <default>global::G.StreamingResponseKind.Live</default>
        /// <example>live</example>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StreamingResponseKindJsonConverter))]
        public global::G.StreamingResponseKind Kind { get; set; } = global::G.StreamingResponseKind.Live;

        /// <summary>
        /// The file data you uploaded. Can be null if status is "error"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public global::G.FileResponse? File { get; set; }

        /// <summary>
        /// Parameters used for this live transcription. Can be null if status is "error"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_params")]
        public global::G.StreamingRequestParamsResponse? RequestParams { get; set; }

        /// <summary>
        /// Live transcription's result when status is "done"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.StreamingTranscriptionResultWithMessagesDTO? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingResponse" /> class.
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
        /// Parameters used for this live transcription. Can be null if status is "error"
        /// </param>
        /// <param name="result">
        /// Live transcription's result when status is "done"
        /// </param>
        /// <param name="kind">
        /// Default Value: live<br/>
        /// Example: live
        /// </param>
        public StreamingResponse(
            global::System.Guid id,
            string requestId,
            int version,
            global::G.StreamingResponseStatus status,
            global::System.DateTime createdAt,
            object postSessionMetadata,
            global::System.DateTime? completedAt,
            object? customMetadata,
            int? errorCode,
            global::G.FileResponse? file,
            global::G.StreamingRequestParamsResponse? requestParams,
            global::G.StreamingTranscriptionResultWithMessagesDTO? result,
            global::G.StreamingResponseKind kind = global::G.StreamingResponseKind.Live)
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
        /// Initializes a new instance of the <see cref="StreamingResponse" /> class.
        /// </summary>
        public StreamingResponse()
        {
        }
    }
}