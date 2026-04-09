//HintName: G.Models.PostOrgConsumerProjectResolveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostOrgConsumerProjectResolveResponse
    {
        /// <summary>
        /// UUID of the resolved consumer project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Nano ID of the resolved consumer project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_nano_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectNanoId { get; set; } = default!;

        /// <summary>
        /// Name of the resolved consumer project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// Organization nano ID that owns the consumer project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// Resolved project type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostOrgConsumerProjectResolveResponseProjectTypeJsonConverter))]
        public global::G.PostOrgConsumerProjectResolveResponseProjectType ProjectType { get; set; }

        /// <summary>
        /// Derived internal Composio user ID for the authenticated user in this consumer org context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consumer_user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConsumerUserId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgConsumerProjectResolveResponse" /> class.
        /// </summary>
        /// <param name="projectId">
        /// UUID of the resolved consumer project.
        /// </param>
        /// <param name="projectNanoId">
        /// Nano ID of the resolved consumer project.
        /// </param>
        /// <param name="projectName">
        /// Name of the resolved consumer project.
        /// </param>
        /// <param name="orgId">
        /// Organization nano ID that owns the consumer project.
        /// </param>
        /// <param name="consumerUserId">
        /// Derived internal Composio user ID for the authenticated user in this consumer org context.
        /// </param>
        /// <param name="projectType">
        /// Resolved project type.
        /// </param>
        public PostOrgConsumerProjectResolveResponse(
            global::System.Guid projectId,
            string projectNanoId,
            string projectName,
            string orgId,
            string consumerUserId,
            global::G.PostOrgConsumerProjectResolveResponseProjectType projectType)
        {
            this.ProjectId = projectId;
            this.ProjectNanoId = projectNanoId ?? throw new global::System.ArgumentNullException(nameof(projectNanoId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.ProjectType = projectType;
            this.ConsumerUserId = consumerUserId ?? throw new global::System.ArgumentNullException(nameof(consumerUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgConsumerProjectResolveResponse" /> class.
        /// </summary>
        public PostOrgConsumerProjectResolveResponse()
        {
        }
    }
}