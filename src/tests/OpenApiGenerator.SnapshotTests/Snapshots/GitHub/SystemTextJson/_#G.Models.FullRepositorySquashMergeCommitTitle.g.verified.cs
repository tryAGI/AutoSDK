//HintName: G.Models.FullRepositorySquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// <br/>Example: PR_TITLE
    /// </summary>
    public abstract class FullRepositorySquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        public const string PRTITLE = "PR_TITLE";
        /// <summary>
        /// 
        /// </summary>
        public const string COMMITORPRTITLE = "COMMIT_OR_PR_TITLE";
    }
}