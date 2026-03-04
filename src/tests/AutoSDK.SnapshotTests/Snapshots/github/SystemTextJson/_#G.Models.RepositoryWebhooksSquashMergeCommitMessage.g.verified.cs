//HintName: G.Models.RepositoryWebhooksSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum RepositoryWebhooksSquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PrBody,
        /// <summary>
        /// 
        /// </summary>
        CommitMessages,
        /// <summary>
        /// 
        /// </summary>
        Blank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryWebhooksSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksSquashMergeCommitMessage value)
        {
            return value switch
            {
                RepositoryWebhooksSquashMergeCommitMessage.PrBody => "PR_BODY",
                RepositoryWebhooksSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                RepositoryWebhooksSquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => RepositoryWebhooksSquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => RepositoryWebhooksSquashMergeCommitMessage.CommitMessages,
                "BLANK" => RepositoryWebhooksSquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}