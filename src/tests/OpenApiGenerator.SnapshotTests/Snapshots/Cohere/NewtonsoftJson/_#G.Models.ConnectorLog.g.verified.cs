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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectorId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// Time of connector log creation in RFC3339 format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// HTTP status code of the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Duration of the request in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_millis", Required = global::Newtonsoft.Json.Required.Always)]
        public int DurationMillis { get; set; } = default!;

        /// <summary>
        /// Error message of the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}