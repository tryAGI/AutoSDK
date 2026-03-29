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
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Timestamp when the research task was created.<br/>
        /// Example: 2025-01-15T10:30:00Z
        /// </summary>
        /// <example>2025-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The current status of the research task.<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// The research task or question investigated.<br/>
        /// Example: What are the latest developments in AI?
        /// </summary>
        /// <example>What are the latest developments in AI?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The model used by the research agent.<br/>
        /// Example: mini
        /// </summary>
        /// <example>mini</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23F
        /// </summary>
        /// <example>1.23F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResponseTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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