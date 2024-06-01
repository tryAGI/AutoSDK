//HintName: G.Models.TeamMembershipState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the user's membership in the team.
    /// </summary>
    public enum TeamMembershipState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamMembershipStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMembershipState value)
        {
            return value switch
            {
                TeamMembershipState.Active => "active",
                TeamMembershipState.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMembershipState ToEnum(string value)
        {
            return value switch
            {
                "active" => TeamMembershipState.Active,
                "pending" => TeamMembershipState.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}