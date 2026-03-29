//HintName: G.Models.ServerlessListRequestsByEndpointResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serverless request item
    /// </summary>
    public sealed partial class ServerlessListRequestsByEndpointResponseItem
    {
        /// <summary>
        /// Unique identifier for the request<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </summary>
        /// <example>a1b2c3d4-e5f6-7890-abcd-ef1234567890</example>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RequestId { get; set; } = default!;

        /// <summary>
        /// Endpoint that was executed for this request<br/>
        /// Example: fal-ai/flux/dev
        /// </summary>
        /// <example>fal-ai/flux/dev</example>
        [global::Newtonsoft.Json.JsonProperty("endpoint_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndpointId { get; set; } = default!;

        /// <summary>
        /// Time when request processing started<br/>
        /// Example: 2025-01-01T00:00:05Z
        /// </summary>
        /// <example>2025-01-01T00:00:05Z</example>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// Time when request was sent to the backend<br/>
        /// Example: 2025-01-01T00:00:01Z
        /// </summary>
        /// <example>2025-01-01T00:00:01Z</example>
        [global::Newtonsoft.Json.JsonProperty("sent_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime SentAt { get; set; } = default!;

        /// <summary>
        /// Time when request finished processing<br/>
        /// Example: 2025-01-01T00:00:08Z
        /// </summary>
        /// <example>2025-01-01T00:00:08Z</example>
        [global::Newtonsoft.Json.JsonProperty("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// HTTP status code returned by the request<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::Newtonsoft.Json.JsonProperty("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Total request duration in seconds<br/>
        /// Example: 7.8F
        /// </summary>
        /// <example>7.8F</example>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Input payload for the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_input")]
        public object? JsonInput { get; set; }

        /// <summary>
        /// Output payload for the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_output")]
        public object? JsonOutput { get; set; }

        /// <summary>
        /// Unique identifier for the runner execution instance<br/>
        /// Example: f1e2d3c4-b5a6-7890-dcba-0987654321fe
        /// </summary>
        /// <example>f1e2d3c4-b5a6-7890-dcba-0987654321fe</example>
        [global::Newtonsoft.Json.JsonProperty("runner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RunnerId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListRequestsByEndpointResponseItem" /> class.
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
        /// <param name="runnerId">
        /// Unique identifier for the runner execution instance<br/>
        /// Example: f1e2d3c4-b5a6-7890-dcba-0987654321fe
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
        public ServerlessListRequestsByEndpointResponseItem(
            global::System.Guid requestId,
            string endpointId,
            global::System.DateTime startedAt,
            global::System.DateTime sentAt,
            global::System.Guid runnerId,
            global::System.DateTime? endedAt,
            int? statusCode,
            double? duration,
            object? jsonInput,
            object? jsonOutput)
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
            this.RunnerId = runnerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListRequestsByEndpointResponseItem" /> class.
        /// </summary>
        public ServerlessListRequestsByEndpointResponseItem()
        {
        }
    }
}