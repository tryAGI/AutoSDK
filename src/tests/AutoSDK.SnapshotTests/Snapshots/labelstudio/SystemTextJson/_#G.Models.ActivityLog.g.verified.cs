//HintName: G.Models.ActivityLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityLog
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("datetime")]
        public global::System.DateTime Datetime { get; set; } = default!;

        /// <summary>
        /// Duration of response generation in ms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_data")]
        public object? ExtraData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_referer")]
        public string? HttpReferer { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_address")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// Organization id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Project id if request has it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_session")]
        public string? UserSession { get; set; }

        /// <summary>
        /// Owner id of workspace where action performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_owner_id")]
        public int? WorkspaceOwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLog" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="requestMethod"></param>
        /// <param name="requestUrl"></param>
        /// <param name="responseCode"></param>
        /// <param name="userId"></param>
        /// <param name="duration">
        /// Duration of response generation in ms
        /// </param>
        /// <param name="extraData"></param>
        /// <param name="httpReferer"></param>
        /// <param name="ipAddress"></param>
        /// <param name="organizationId">
        /// Organization id
        /// </param>
        /// <param name="projectId">
        /// Project id if request has it
        /// </param>
        /// <param name="userAgent"></param>
        /// <param name="userSession"></param>
        /// <param name="workspaceOwnerId">
        /// Owner id of workspace where action performed
        /// </param>
        /// <param name="datetime">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityLog(
            string email,
            string requestMethod,
            string requestUrl,
            string responseCode,
            int userId,
            int? duration,
            object? extraData,
            string? httpReferer,
            string? ipAddress,
            int? organizationId,
            int? projectId,
            string? userAgent,
            string? userSession,
            int? workspaceOwnerId,
            global::System.DateTime datetime = default!,
            int id = default!)
        {
            this.Datetime = datetime;
            this.Duration = duration;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.ExtraData = extraData;
            this.HttpReferer = httpReferer;
            this.Id = id;
            this.IpAddress = ipAddress;
            this.OrganizationId = organizationId;
            this.ProjectId = projectId;
            this.RequestMethod = requestMethod ?? throw new global::System.ArgumentNullException(nameof(requestMethod));
            this.RequestUrl = requestUrl ?? throw new global::System.ArgumentNullException(nameof(requestUrl));
            this.ResponseCode = responseCode ?? throw new global::System.ArgumentNullException(nameof(responseCode));
            this.UserAgent = userAgent;
            this.UserId = userId;
            this.UserSession = userSession;
            this.WorkspaceOwnerId = workspaceOwnerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLog" /> class.
        /// </summary>
        public ActivityLog()
        {
        }
    }
}