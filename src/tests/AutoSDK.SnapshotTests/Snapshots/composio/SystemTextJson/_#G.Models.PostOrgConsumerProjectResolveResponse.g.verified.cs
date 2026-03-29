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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Nano ID of the resolved consumer project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_nano_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNanoId { get; set; }

        /// <summary>
        /// Name of the resolved consumer project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Organization nano ID that owns the consumer project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Resolved project type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostOrgConsumerProjectResolveResponseProjectTypeJsonConverter))]
        public global::G.PostOrgConsumerProjectResolveResponseProjectType ProjectType { get; set; }

        /// <summary>
        /// Derived internal Composio user ID for the authenticated user in this consumer org context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumer_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsumerUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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