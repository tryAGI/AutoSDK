//HintName: G.Models.TeamMembershipRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the user in the team.
    /// <br/>Default Value: member
    /// <br/>Example: member
    /// </summary>
    public abstract class TeamMembershipRole
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Member = "member";
        /// <summary>
        /// 
        /// </summary>
        public const string Maintainer = "maintainer";
    }
}