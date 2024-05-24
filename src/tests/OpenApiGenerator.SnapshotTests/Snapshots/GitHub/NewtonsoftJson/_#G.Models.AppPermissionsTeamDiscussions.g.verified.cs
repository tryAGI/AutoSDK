//HintName: G.Models.AppPermissionsTeamDiscussions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage team discussions and related comments.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsTeamDiscussions
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