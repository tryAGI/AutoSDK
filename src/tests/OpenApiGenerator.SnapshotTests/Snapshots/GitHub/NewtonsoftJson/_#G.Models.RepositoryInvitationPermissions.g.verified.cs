//HintName: G.Models.RepositoryInvitationPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission associated with the invitation.
    /// <br/>Example: read
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryInvitationPermissions
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="triage")]
        Triage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maintain")]
        Maintain,
    }
}