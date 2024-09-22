//HintName: G.Models.MembershipState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MembershipState describes the state of a user membership to an organization.<br/>
    ///  - MEMBERSHIP_STATE_ACTIVE: Active.<br/>
    ///  - MEMBERSHIP_STATE_PENDING: Pending, i.e., a request has been sent to the user to join an<br/>
    /// organization.
    /// </summary>
    public enum MembershipState
    {
        /// <summary>
        /// Active.
        /// </summary>
        MEMBERSHIPSTATEACTIVE,
        /// <summary>
        /// Pending, i.e., a request has been sent to the user to join an
        /// </summary>
        MEMBERSHIPSTATEPENDING,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MembershipStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MembershipState value)
        {
            return value switch
            {
                MembershipState.MEMBERSHIPSTATEACTIVE => "MEMBERSHIP_STATE_ACTIVE",
                MembershipState.MEMBERSHIPSTATEPENDING => "MEMBERSHIP_STATE_PENDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MembershipState? ToEnum(string value)
        {
            return value switch
            {
                "MEMBERSHIP_STATE_ACTIVE" => MembershipState.MEMBERSHIPSTATEACTIVE,
                "MEMBERSHIP_STATE_PENDING" => MembershipState.MEMBERSHIPSTATEPENDING,
                _ => null,
            };
        }
    }
}