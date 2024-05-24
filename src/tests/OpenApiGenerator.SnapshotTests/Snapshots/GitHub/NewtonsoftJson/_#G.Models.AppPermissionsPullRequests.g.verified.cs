//HintName: G.Models.AppPermissionsPullRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsPullRequests
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }
}