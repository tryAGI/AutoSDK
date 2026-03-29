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
        [global::Newtonsoft.Json.JsonProperty("datetime")]
        public global::System.DateTime Datetime { get; set; } = default!;

        /// <summary>
        /// Duration of response generation in ms
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_data")]
        public object? ExtraData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("http_referer")]
        public string? HttpReferer { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ip_address")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// Organization id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Project id if request has it
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_method", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestMethod { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResponseCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_session")]
        public string? UserSession { get; set; }

        /// <summary>
        /// Owner id of workspace where action performed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_owner_id")]
        public int? WorkspaceOwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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