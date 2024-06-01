//HintName: G.Models.OrgsUpdateMembershipForAuthenticatedUserRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state that the membership should be in. Only `"active"` will be accepted.
    /// </summary>
    public enum OrgsUpdateMembershipForAuthenticatedUserRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsUpdateMembershipForAuthenticatedUserRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsUpdateMembershipForAuthenticatedUserRequestState value)
        {
            return value switch
            {
                OrgsUpdateMembershipForAuthenticatedUserRequestState.Active => "active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsUpdateMembershipForAuthenticatedUserRequestState ToEnum(string value)
        {
            return value switch
            {
                "active" => OrgsUpdateMembershipForAuthenticatedUserRequestState.Active,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}