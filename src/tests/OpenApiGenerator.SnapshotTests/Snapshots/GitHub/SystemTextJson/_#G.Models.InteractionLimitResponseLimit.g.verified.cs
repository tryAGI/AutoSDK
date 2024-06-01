//HintName: G.Models.InteractionLimitResponseLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.
    /// <br/>Example: collaborators_only
    /// </summary>
    public enum InteractionLimitResponseLimit
    {
        /// <summary>
        /// 
        /// </summary>
        ExistingUsers,
        /// <summary>
        /// 
        /// </summary>
        ContributorsOnly,
        /// <summary>
        /// 
        /// </summary>
        CollaboratorsOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InteractionLimitResponseLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InteractionLimitResponseLimit value)
        {
            return value switch
            {
                InteractionLimitResponseLimit.ExistingUsers => "existing_users",
                InteractionLimitResponseLimit.ContributorsOnly => "contributors_only",
                InteractionLimitResponseLimit.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InteractionLimitResponseLimit ToEnum(string value)
        {
            return value switch
            {
                "existing_users" => InteractionLimitResponseLimit.ExistingUsers,
                "contributors_only" => InteractionLimitResponseLimit.ContributorsOnly,
                "collaborators_only" => InteractionLimitResponseLimit.CollaboratorsOnly,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}