//HintName: G.Models.RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage
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
    public static class RepositoryWebhooksTemplateRepositorySquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage value)
        {
            return value switch
            {
                RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.PrBody => "PR_BODY",
                RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.CommitMessages,
                "BLANK" => RepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}