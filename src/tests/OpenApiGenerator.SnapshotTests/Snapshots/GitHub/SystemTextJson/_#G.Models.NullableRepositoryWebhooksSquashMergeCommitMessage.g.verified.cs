//HintName: G.Models.NullableRepositoryWebhooksSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum NullableRepositoryWebhooksSquashMergeCommitMessage
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
    public static class NullableRepositoryWebhooksSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableRepositoryWebhooksSquashMergeCommitMessage value)
        {
            return value switch
            {
                NullableRepositoryWebhooksSquashMergeCommitMessage.PRBODY => "PR_BODY",
                NullableRepositoryWebhooksSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                NullableRepositoryWebhooksSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableRepositoryWebhooksSquashMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => NullableRepositoryWebhooksSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => NullableRepositoryWebhooksSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => NullableRepositoryWebhooksSquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}