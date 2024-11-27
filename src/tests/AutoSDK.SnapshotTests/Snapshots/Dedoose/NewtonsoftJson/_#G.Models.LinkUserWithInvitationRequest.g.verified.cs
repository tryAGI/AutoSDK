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
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid GroupId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitationId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid InvitationId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkUserWithInvitationRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="groupId"></param>
        /// <param name="invitationId"></param>
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