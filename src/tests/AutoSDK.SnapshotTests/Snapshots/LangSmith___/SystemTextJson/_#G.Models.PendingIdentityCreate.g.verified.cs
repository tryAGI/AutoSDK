//HintName: G.Models.PendingIdentityCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingIdentityCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Default Value: false
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
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? WorkspaceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_role_id")]
        public global::System.Guid? WorkspaceRoleId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingIdentityCreate" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="roleId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="workspaceRoleId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PendingIdentityCreate(
            string email,
            bool? readOnly,
            global::System.Guid? roleId,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaceIds,
            global::System.Guid? workspaceRoleId,
            string? password,
            string? fullName)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.ReadOnly = readOnly;
            this.RoleId = roleId;
            this.WorkspaceIds = workspaceIds;
            this.WorkspaceRoleId = workspaceRoleId;
            this.Password = password;
            this.FullName = fullName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingIdentityCreate" /> class.
        /// </summary>
        public PendingIdentityCreate()
        {
        }
    }
}