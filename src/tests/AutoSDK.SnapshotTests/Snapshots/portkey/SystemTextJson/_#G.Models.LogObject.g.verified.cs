//HintName: G.Models.LogObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogObject
    {
        /// <summary>
        /// Unique identifier for the log entry<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LogRequest Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LogResponse Response { get; set; }

        /// <summary>
        /// Organization identifier<br/>
        /// Example: org-123
        /// </summary>
        /// <example>org-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public string? OrganisationId { get; set; }

        /// <summary>
        /// Timestamp when the log was created<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </summary>
        /// <example>2024-01-15T10:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Analytics metrics extracted from the log entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::G.AnalyticsMetrics? Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalUntransformedRequest")]
        public global::G.RequestResponseObject? FinalUntransformedRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalResponse")]
        public global::G.RequestResponseObject? OriginalResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformedRequest")]
        public global::G.RequestResponseObject? TransformedRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogObject" /> class.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <param name="id">
        /// Unique identifier for the log entry<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="organisationId">
        /// Organization identifier<br/>
        /// Example: org-123
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the log was created<br/>
        /// Example: 2024-01-15T10:30:00.000Z
        /// </param>
        /// <param name="metrics">
        /// Analytics metrics extracted from the log entry
        /// </param>
        /// <param name="finalUntransformedRequest"></param>
        /// <param name="originalResponse"></param>
        /// <param name="transformedRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogObject(
            global::G.LogRequest request,
            global::G.LogResponse response,
            global::System.Guid? id,
            string? organisationId,
            global::System.DateTime? createdAt,
            global::G.AnalyticsMetrics? metrics,
            global::G.RequestResponseObject? finalUntransformedRequest,
            global::G.RequestResponseObject? originalResponse,
            global::G.RequestResponseObject? transformedRequest)
        {
            this.Id = id;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.OrganisationId = organisationId;
            this.CreatedAt = createdAt;
            this.Metrics = metrics;
            this.FinalUntransformedRequest = finalUntransformedRequest;
            this.OriginalResponse = originalResponse;
            this.TransformedRequest = transformedRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogObject" /> class.
        /// </summary>
        public LogObject()
        {
        }
    }
}