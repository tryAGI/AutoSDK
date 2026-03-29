//HintName: G.Models.SearchRequestsResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request search result
    /// </summary>
    public sealed partial class SearchRequestsResponseResult
    {
        /// <summary>
        /// Unique identifier for the request<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </summary>
        /// <example>a1b2c3d4-e5f6-7890-abcd-ef1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Endpoint that was executed for this request<br/>
        /// Example: fal-ai/flux/dev
        /// </summary>
        /// <example>fal-ai/flux/dev</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Time when request processing started<br/>
        /// Example: 2025-01-01T00:00:05Z
        /// </summary>
        /// <example>2025-01-01T00:00:05Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Time when request was sent to the backend<br/>
        /// Example: 2025-01-01T00:00:01Z
        /// </summary>
        /// <example>2025-01-01T00:00:01Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SentAt { get; set; }

        /// <summary>
        /// Time when request finished processing<br/>
        /// Example: 2025-01-01T00:00:08Z
        /// </summary>
        /// <example>2025-01-01T00:00:08Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// HTTP status code returned by the request<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Total request duration in seconds<br/>
        /// Example: 7.8F
        /// </summary>
        /// <example>7.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Input payload for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_input")]
        public object? JsonInput { get; set; }

        /// <summary>
        /// Output payload for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_output")]
        public object? JsonOutput { get; set; }

        /// <summary>
        /// Similarity score (0-1) when semantic search is used<br/>
        /// Example: 0.87F
        /// </summary>
        /// <example>0.87F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        public double? Similarity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestsResponseResult" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
        /// <param name="endpointId">
        /// Endpoint that was executed for this request<br/>
        /// Example: fal-ai/flux/dev
        /// </param>
        /// <param name="startedAt">
        /// Time when request processing started<br/>
        /// Example: 2025-01-01T00:00:05Z
        /// </param>
        /// <param name="sentAt">
        /// Time when request was sent to the backend<br/>
        /// Example: 2025-01-01T00:00:01Z
        /// </param>
        /// <param name="endedAt">
        /// Time when request finished processing<br/>
        /// Example: 2025-01-01T00:00:08Z
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code returned by the request<br/>
        /// Example: 200
        /// </param>
        /// <param name="duration">
        /// Total request duration in seconds<br/>
        /// Example: 7.8F
        /// </param>
        /// <param name="jsonInput">
        /// Input payload for the request
        /// </param>
        /// <param name="jsonOutput">
        /// Output payload for the request
        /// </param>
        /// <param name="similarity">
        /// Similarity score (0-1) when semantic search is used<br/>
        /// Example: 0.87F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestsResponseResult(
            global::System.Guid requestId,
            string endpointId,
            global::System.DateTime startedAt,
            global::System.DateTime sentAt,
            global::System.DateTime? endedAt,
            int? statusCode,
            double? duration,
            object? jsonInput,
            object? jsonOutput,
            double? similarity)
        {
            this.RequestId = requestId;
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.StartedAt = startedAt;
            this.SentAt = sentAt;
            this.EndedAt = endedAt;
            this.StatusCode = statusCode;
            this.Duration = duration;
            this.JsonInput = jsonInput;
            this.JsonOutput = jsonOutput;
            this.Similarity = similarity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestsResponseResult" /> class.
        /// </summary>
        public SearchRequestsResponseResult()
        {
        }
    }
}