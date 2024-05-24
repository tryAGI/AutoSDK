//HintName: G.Models.FullRepositoryMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.
    ///   - `PR_TITLE` - default to the pull request's title.
    ///   - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// <br/>Example: PR_TITLE
    /// </summary>
    public abstract class FullRepositoryMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        public const string PRTITLE = "PR_TITLE";
        /// <summary>
        /// 
        /// </summary>
        public const string MERGEMESSAGE = "MERGE_MESSAGE";
    }
}