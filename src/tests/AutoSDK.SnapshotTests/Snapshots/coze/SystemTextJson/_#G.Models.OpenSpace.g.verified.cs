//HintName: G.Models.OpenSpace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenSpace
    {
        /// <summary>
        /// 空间管理员 id 列表
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin_uids")]
        public global::System.Collections.Generic.IList<string>? AdminUids { get; set; }

        /// <summary>
        /// 空间描述
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 企业 id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// 空间图标 url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 空间 id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpaceMemberJoinedStatusJsonConverter))]
        public global::G.SpaceMemberJoinedStatus? JoinedStatus { get; set; }

        /// <summary>
        /// 空间名称
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_uid")]
        public string? OwnerUid { get; set; }

        /// <summary>
        /// 当前用户角色, 枚举值: owner, admin, member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_type")]
        public string? RoleType { get; set; }

        /// <summary>
        /// 工作空间类型, 枚举值: personal, team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_type")]
        public string? WorkspaceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSpace" /> class.
        /// </summary>
        /// <param name="adminUids">
        /// 空间管理员 id 列表
        /// </param>
        /// <param name="description">
        /// 空间描述
        /// </param>
        /// <param name="enterpriseId">
        /// 企业 id
        /// </param>
        /// <param name="iconUrl">
        /// 空间图标 url
        /// </param>
        /// <param name="id">
        /// 空间 id
        /// </param>
        /// <param name="joinedStatus"></param>
        /// <param name="name">
        /// 空间名称
        /// </param>
        /// <param name="ownerUid"></param>
        /// <param name="roleType">
        /// 当前用户角色, 枚举值: owner, admin, member
        /// </param>
        /// <param name="workspaceType">
        /// 工作空间类型, 枚举值: personal, team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenSpace(
            global::System.Collections.Generic.IList<string>? adminUids,
            string? description,
            string? enterpriseId,
            string? iconUrl,
            string? id,
            global::G.SpaceMemberJoinedStatus? joinedStatus,
            string? name,
            string? ownerUid,
            string? roleType,
            string? workspaceType)
        {
            this.AdminUids = adminUids;
            this.Description = description;
            this.EnterpriseId = enterpriseId;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.JoinedStatus = joinedStatus;
            this.Name = name;
            this.OwnerUid = ownerUid;
            this.RoleType = roleType;
            this.WorkspaceType = workspaceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSpace" /> class.
        /// </summary>
        public OpenSpace()
        {
        }
    }
}