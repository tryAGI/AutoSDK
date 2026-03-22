//HintName: G.Models.InteractionGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.<br/>
    /// Example: collaborators_only
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InteractionGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="collaborators_only")]
        CollaboratorsOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contributors_only")]
        ContributorsOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="existing_users")]
        ExistingUsers,
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
                InteractionGroup.CollaboratorsOnly => "collaborators_only",
                InteractionGroup.ContributorsOnly => "contributors_only",
                InteractionGroup.ExistingUsers => "existing_users",
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
                "collaborators_only" => InteractionGroup.CollaboratorsOnly,
                "contributors_only" => InteractionGroup.ContributorsOnly,
                "existing_users" => InteractionGroup.ExistingUsers,
                _ => null,
            };
        }
    }
}