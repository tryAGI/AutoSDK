//HintName: G.Models.LinkUserWithInvitationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkUserWithInvitationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InvitationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkUserWithInvitationRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="groupId"></param>
        /// <param name="invitationId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LinkUserWithInvitationRequest(
            global::System.Guid userId,
            global::System.Guid projectId,
            global::System.Guid groupId,
            global::System.Guid invitationId)
        {
            this.UserId = userId;
            this.ProjectId = projectId;
            this.GroupId = groupId;
            this.InvitationId = invitationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkUserWithInvitationRequest" /> class.
        /// </summary>
        public LinkUserWithInvitationRequest()
        {
        }
    }
}