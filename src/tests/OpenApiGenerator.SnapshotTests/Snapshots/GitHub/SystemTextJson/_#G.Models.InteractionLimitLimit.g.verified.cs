//HintName: G.Models.InteractionLimitLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.
    /// <br/>Example: collaborators_only
    /// </summary>
    public enum InteractionLimitLimit
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
    public static class InteractionLimitLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InteractionLimitLimit value)
        {
            return value switch
            {
                InteractionLimitLimit.ExistingUsers => "existing_users",
                InteractionLimitLimit.ContributorsOnly => "contributors_only",
                InteractionLimitLimit.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InteractionLimitLimit ToEnum(string value)
        {
            return value switch
            {
                "existing_users" => InteractionLimitLimit.ExistingUsers,
                "contributors_only" => InteractionLimitLimit.ContributorsOnly,
                "collaborators_only" => InteractionLimitLimit.CollaboratorsOnly,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}