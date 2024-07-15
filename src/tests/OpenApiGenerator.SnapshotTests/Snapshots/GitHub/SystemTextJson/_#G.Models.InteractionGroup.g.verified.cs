//HintName: G.Models.InteractionGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.<br/>
    /// Example: collaborators_only
    /// </summary>
    public enum InteractionGroup
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
    public static class InteractionGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InteractionGroup value)
        {
            return value switch
            {
                InteractionGroup.ExistingUsers => "existing_users",
                InteractionGroup.ContributorsOnly => "contributors_only",
                InteractionGroup.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InteractionGroup? ToEnum(string value)
        {
            return value switch
            {
                "existing_users" => InteractionGroup.ExistingUsers,
                "contributors_only" => InteractionGroup.ContributorsOnly,
                "collaborators_only" => InteractionGroup.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}