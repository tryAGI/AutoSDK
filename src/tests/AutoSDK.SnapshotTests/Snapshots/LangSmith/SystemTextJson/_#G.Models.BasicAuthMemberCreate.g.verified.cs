//HintName: G.Models.BasicAuthMemberCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasicAuthMemberCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public global::System.Guid? LsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_role_id")]
        public global::System.Guid? WorkspaceRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? WorkspaceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthMemberCreate" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="email"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="workspaceRoleId"></param>
        /// <param name="workspaceIds"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BasicAuthMemberCreate(
            string email,
            global::System.Guid? userId,
            global::System.Guid? lsUserId,
            bool? readOnly,
            global::System.Guid? roleId,
            string? password,
            string? fullName,
            global::System.Guid? workspaceRoleId,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaceIds)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.UserId = userId;
            this.LsUserId = lsUserId;
            this.ReadOnly = readOnly;
            this.RoleId = roleId;
            this.Password = password;
            this.FullName = fullName;
            this.WorkspaceRoleId = workspaceRoleId;
            this.WorkspaceIds = workspaceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthMemberCreate" /> class.
        /// </summary>
        public BasicAuthMemberCreate()
        {
        }
    }
}