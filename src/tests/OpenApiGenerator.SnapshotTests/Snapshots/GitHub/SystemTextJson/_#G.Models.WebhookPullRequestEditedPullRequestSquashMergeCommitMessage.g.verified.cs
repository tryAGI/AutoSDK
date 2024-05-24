//HintName: G.Models.WebhookPullRequestEditedPullRequestSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public abstract class WebhookPullRequestEditedPullRequestSquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public const string PRBODY = "PR_BODY";
        /// <summary>
        /// 
        /// </summary>
        public const string COMMITMESSAGES = "COMMIT_MESSAGES";
        /// <summary>
        /// 
        /// </summary>
        public const string BLANK = "BLANK";
    }
}