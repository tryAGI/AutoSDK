//HintName: G.Models.TeamMembershipState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the user's membership in the team.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamMembershipState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }
}