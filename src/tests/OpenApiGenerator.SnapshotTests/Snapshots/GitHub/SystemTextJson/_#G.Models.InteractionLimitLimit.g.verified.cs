//HintName: G.Models.InteractionLimitLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.
    /// <br/>Example: collaborators_only
    /// </summary>
    public abstract class InteractionLimitLimit
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ExistingUsers = "existing_users";
        /// <summary>
        /// 
        /// </summary>
        public const string ContributorsOnly = "contributors_only";
        /// <summary>
        /// 
        /// </summary>
        public const string CollaboratorsOnly = "collaborators_only";
    }
}