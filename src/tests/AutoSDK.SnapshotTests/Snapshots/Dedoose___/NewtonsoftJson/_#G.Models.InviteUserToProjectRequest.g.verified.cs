//HintName: G.Models.InviteUserToProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteUserToProjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid GroupId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUserToProjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="email"></param>
        /// <param name="groupId"></param>
        public InviteUserToProjectRequest(
            global::System.Guid projectId,
            string email,
            global::System.Guid groupId)
        {
            this.ProjectId = projectId;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.GroupId = groupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUserToProjectRequest" /> class.
        /// </summary>
        public InviteUserToProjectRequest()
        {
        }
    }
}