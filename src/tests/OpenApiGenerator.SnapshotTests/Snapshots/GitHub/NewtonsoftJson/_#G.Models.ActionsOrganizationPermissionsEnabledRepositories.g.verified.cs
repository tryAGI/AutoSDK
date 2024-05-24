//HintName: G.Models.ActionsOrganizationPermissionsEnabledRepositories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsOrganizationPermissionsEnabledRepositories
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }
}