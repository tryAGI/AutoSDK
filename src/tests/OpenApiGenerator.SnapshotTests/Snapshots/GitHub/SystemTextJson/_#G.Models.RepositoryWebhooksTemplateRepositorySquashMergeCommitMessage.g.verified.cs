//HintName: G.Models.RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        COMMITMESSAGES,
        /// <summary>
        /// 
        /// </summary>
        BLANK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryWebhooksTemplateRepositorySquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage value)
        {
            return value switch
            {
                RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.PRBODY => "PR_BODY",
                RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}