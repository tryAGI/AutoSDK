//HintName: G.Models.TeamMembershipRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the user in the team.
    /// <br/>Default Value: member
    /// <br/>Example: member
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamMembershipRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maintainer")]
        Maintainer,
    }
}