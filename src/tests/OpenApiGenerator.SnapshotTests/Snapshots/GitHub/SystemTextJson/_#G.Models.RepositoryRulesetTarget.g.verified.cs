//HintName: G.Models.RepositoryRulesetTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The target of the ruleset
    /// **Note**: The `push` target is in beta and is subject to change.
    /// </summary>
    public abstract class RepositoryRulesetTarget
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Branch = "branch";
        /// <summary>
        /// 
        /// </summary>
        public const string Tag = "tag";
        /// <summary>
        /// 
        /// </summary>
        public const string Push = "push";
    }
}