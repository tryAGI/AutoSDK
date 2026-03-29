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
        [global::Newtonsoft.Json.JsonProperty("role_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WorkspaceRoleType RoleType { get; set; } = default!;

        /// <summary>
        /// 用户ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 昵称（添加成员时不用传）
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_nickname")]
        public string? UserNickname { get; set; }

        /// <summary>
        /// 用户名（添加成员时不用传）
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_unique_name")]
        public string? UserUniqueName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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