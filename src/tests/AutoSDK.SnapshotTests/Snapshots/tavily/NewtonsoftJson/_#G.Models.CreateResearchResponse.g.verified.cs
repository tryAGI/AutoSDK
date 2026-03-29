//HintName: G.Models.CreateResearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResearchResponse
    {
        /// <summary>
        /// A unique identifier for the research task.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174111
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174111</example>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// Timestamp when the research task was created.<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </summary>
        /// <example>2025-01-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The current status of the research task.<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// The research task or question investigated.<br/>
        /// Example: What are the latest developments in AI?
        /// </summary>
        /// <example>What are the latest developments in AI?</example>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// The model used by the research agent.<br/>
        /// Example: mini
        /// </summary>
        /// <example>mini</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23F
        /// </summary>
        /// <example>1.23F</example>
        [global::Newtonsoft.Json.JsonProperty("response_time", Required = global::Newtonsoft.Json.Required.Always)]
        public int ResponseTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// A unique identifier for the research task.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174111
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the research task was created.<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </param>
        /// <param name="status">
        /// The current status of the research task.<br/>
        /// Example: pending
        /// </param>
        /// <param name="input">
        /// The research task or question investigated.<br/>
        /// Example: What are the latest developments in AI?
        /// </param>
        /// <param name="model">
        /// The model used by the research agent.<br/>
        /// Example: mini
        /// </param>
        /// <param name="responseTime">
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23F
        /// </param>
        public CreateResearchResponse(
            string requestId,
            string createdAt,
            string status,
            string input,
            string model,
            int responseTime)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ResponseTime = responseTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchResponse" /> class.
        /// </summary>
        public CreateResearchResponse()
        {
        }
    }
}