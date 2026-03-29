//HintName: G.Models.OpenRemoveSpaceMemberData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenRemoveSpaceMemberData
    {
        /// <summary>
        /// 不在空间的用户不进行处理
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_in_workspace_user_ids")]
        public global::System.Collections.Generic.IList<string>? NotInWorkspaceUserIds { get; set; }

        /// <summary>
        /// 空间所有者不进行处理
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_not_support_remove_user_ids")]
        public global::System.Collections.Generic.IList<string>? OwnerNotSupportRemoveUserIds { get; set; }

        /// <summary>
        /// 成功移除的成员列表
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed_success_user_ids")]
        public global::System.Collections.Generic.IList<string>? RemovedSuccessUserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRemoveSpaceMemberData" /> class.
        /// </summary>
        /// <param name="notInWorkspaceUserIds">
        /// 不在空间的用户不进行处理
        /// </param>
        /// <param name="ownerNotSupportRemoveUserIds">
        /// 空间所有者不进行处理
        /// </param>
        /// <param name="removedSuccessUserIds">
        /// 成功移除的成员列表
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenRemoveSpaceMemberData(
            global::System.Collections.Generic.IList<string>? notInWorkspaceUserIds,
            global::System.Collections.Generic.IList<string>? ownerNotSupportRemoveUserIds,
            global::System.Collections.Generic.IList<string>? removedSuccessUserIds)
        {
            this.NotInWorkspaceUserIds = notInWorkspaceUserIds;
            this.OwnerNotSupportRemoveUserIds = ownerNotSupportRemoveUserIds;
            this.RemovedSuccessUserIds = removedSuccessUserIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRemoveSpaceMemberData" /> class.
        /// </summary>
        public OpenRemoveSpaceMemberData()
        {
        }
    }
}