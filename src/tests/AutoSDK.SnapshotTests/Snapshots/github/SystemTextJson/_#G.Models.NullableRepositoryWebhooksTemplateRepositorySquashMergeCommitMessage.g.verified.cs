//HintName: G.Models.NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage
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
    public static class NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage value)
        {
            return value switch
            {
                NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.PrBody => "PR_BODY",
                NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.CommitMessages,
                "BLANK" => NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}