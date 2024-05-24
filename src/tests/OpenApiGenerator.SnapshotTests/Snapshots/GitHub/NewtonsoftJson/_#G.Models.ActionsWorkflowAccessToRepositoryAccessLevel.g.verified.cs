//HintName: G.Models.ActionsWorkflowAccessToRepositoryAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the
    /// repository.
    /// `none` means the access is only possible from workflows in this repository. `user` level access allows sharing across user owned private repositories only. `organization` level access allows sharing across the organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsWorkflowAccessToRepositoryAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
    }
}