//HintName: G.Models.AuditLogObjectListRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditLogObjectListRecord
    {
        /// <summary>
        /// Timestamp of when the action occurred
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// HTTP method used for the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AuditLogObjectListRecordMethodJsonConverter))]
        public global::G.AuditLogObjectListRecordMethod? Method { get; set; }

        /// <summary>
        /// URI path that was accessed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Unique ID of the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// JSON string of the request body
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_body")]
        public string? RequestBody { get; set; }

        /// <summary>
        /// JSON string of the query parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_params")]
        public string? QueryParams { get; set; }

        /// <summary>
        /// JSON string of the request headers (partially masked)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_headers")]
        public string? RequestHeaders { get; set; }

        /// <summary>
        /// ID of the user who made the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Type of user who made the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AuditLogObjectListRecordUserTypeJsonConverter))]
        public global::G.AuditLogObjectListRecordUserType? UserType { get; set; }

        /// <summary>
        /// ID of the organisation the user belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// ID of the workspace the resource belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// HTTP status code of the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_status_code")]
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        /// Type of resource that was accessed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// Action performed on the resource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public string? Action { get; set; }

        /// <summary>
        /// IP address of the client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_ip")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// Country of origin based on the IP address
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogObjectListRecord" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Timestamp of when the action occurred
        /// </param>
        /// <param name="method">
        /// HTTP method used for the request
        /// </param>
        /// <param name="uri">
        /// URI path that was accessed
        /// </param>
        /// <param name="requestId">
        /// Unique ID of the request
        /// </param>
        /// <param name="requestBody">
        /// JSON string of the request body
        /// </param>
        /// <param name="queryParams">
        /// JSON string of the query parameters
        /// </param>
        /// <param name="requestHeaders">
        /// JSON string of the request headers (partially masked)
        /// </param>
        /// <param name="userId">
        /// ID of the user who made the request
        /// </param>
        /// <param name="userType">
        /// Type of user who made the request
        /// </param>
        /// <param name="organisationId">
        /// ID of the organisation the user belongs to
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace the resource belongs to
        /// </param>
        /// <param name="responseStatusCode">
        /// HTTP status code of the response
        /// </param>
        /// <param name="resourceType">
        /// Type of resource that was accessed
        /// </param>
        /// <param name="action">
        /// Action performed on the resource
        /// </param>
        /// <param name="clientIp">
        /// IP address of the client
        /// </param>
        /// <param name="country">
        /// Country of origin based on the IP address
        /// </param>
        public AuditLogObjectListRecord(
            string? timestamp,
            global::G.AuditLogObjectListRecordMethod? method,
            string? uri,
            string? requestId,
            string? requestBody,
            string? queryParams,
            string? requestHeaders,
            global::System.Guid? userId,
            global::G.AuditLogObjectListRecordUserType? userType,
            global::System.Guid? organisationId,
            string? workspaceId,
            int? responseStatusCode,
            string? resourceType,
            string? action,
            string? clientIp,
            string? country)
        {
            this.Timestamp = timestamp;
            this.Method = method;
            this.Uri = uri;
            this.RequestId = requestId;
            this.RequestBody = requestBody;
            this.QueryParams = queryParams;
            this.RequestHeaders = requestHeaders;
            this.UserId = userId;
            this.UserType = userType;
            this.OrganisationId = organisationId;
            this.WorkspaceId = workspaceId;
            this.ResponseStatusCode = responseStatusCode;
            this.ResourceType = resourceType;
            this.Action = action;
            this.ClientIp = clientIp;
            this.Country = country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogObjectListRecord" /> class.
        /// </summary>
        public AuditLogObjectListRecord()
        {
        }
    }
}