//HintName: G.Models.FullRepositoryMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// <br/>Example: PR_BODY
    /// </summary>
    public abstract class FullRepositoryMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public const string PRBODY = "PR_BODY";
        /// <summary>
        /// 
        /// </summary>
        public const string PRTITLE = "PR_TITLE";
        /// <summary>
        /// 
        /// </summary>
        public const string BLANK = "BLANK";
    }
}