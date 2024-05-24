//HintName: G.Models.InteractionLimitResponseLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.
    /// <br/>Example: collaborators_only
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InteractionLimitResponseLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="existing_users")]
        ExistingUsers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contributors_only")]
        ContributorsOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="collaborators_only")]
        CollaboratorsOnly,
    }
}