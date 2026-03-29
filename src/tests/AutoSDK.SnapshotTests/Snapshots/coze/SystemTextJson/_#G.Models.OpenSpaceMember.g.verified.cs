//HintName: G.Models.OpenSpaceMember.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenSpaceMember
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WorkspaceRoleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WorkspaceRoleType RoleType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 昵称（添加成员时不用传）
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_nickname")]
        public string? UserNickname { get; set; }

        /// <summary>
        /// 用户名（添加成员时不用传）
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_unique_name")]
        public string? UserUniqueName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSpaceMember" /> class.
        /// </summary>
        /// <param name="roleType"></param>
        /// <param name="userId">
        /// 用户ID
        /// </param>
        /// <param name="userNickname">
        /// 昵称（添加成员时不用传）
        /// </param>
        /// <param name="userUniqueName">
        /// 用户名（添加成员时不用传）
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenSpaceMember(
            global::G.WorkspaceRoleType roleType,
            string userId,
            string? userNickname,
            string? userUniqueName)
        {
            this.RoleType = roleType;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserNickname = userNickname;
            this.UserUniqueName = userUniqueName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSpaceMember" /> class.
        /// </summary>
        public OpenSpaceMember()
        {
        }
    }
}