//HintName: G.Models.AppPermissionsIssues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsIssues
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