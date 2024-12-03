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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUserToProjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="email"></param>
        /// <param name="groupId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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