//HintName: G.Models.ActionsRepositoryPermissionsAllowedActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsRepositoryPermissionsAllowedActions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="local_only")]
        LocalOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }
}