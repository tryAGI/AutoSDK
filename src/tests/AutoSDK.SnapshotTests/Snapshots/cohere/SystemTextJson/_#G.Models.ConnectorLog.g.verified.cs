//HintName: G.Models.ConnectorLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorLog
    {
        /// <summary>
        /// Unique identifier for the connector log
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier for the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Time of connector log creation in RFC3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// HTTP status code of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Duration of the request in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMillis { get; set; }

        /// <summary>
        /// Error message of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorLog" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the connector log
        /// </param>
        /// <param name="connectorId">
        /// Unique identifier for the connector
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
        /// <param name="userId">
        /// Unique identifier for the user
        /// </param>
        /// <param name="organizationId">
        /// Unique identifier for the organization
        /// </param>
        /// <param name="createdAt">
        /// Time of connector log creation in RFC3339 format
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code of the request
        /// </param>
        /// <param name="durationMillis">
        /// Duration of the request in milliseconds
        /// </param>
        /// <param name="errorMessage">
        /// Error message of the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectorLog(
            string id,
            string connectorId,
            string requestId,
            string userId,
            string organizationId,
            global::System.DateTime createdAt,
            int statusCode,
            int durationMillis,
            string? errorMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.CreatedAt = createdAt;
            this.StatusCode = statusCode;
            this.DurationMillis = durationMillis;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorLog" /> class.
        /// </summary>
        public ConnectorLog()
        {
        }
    }
}