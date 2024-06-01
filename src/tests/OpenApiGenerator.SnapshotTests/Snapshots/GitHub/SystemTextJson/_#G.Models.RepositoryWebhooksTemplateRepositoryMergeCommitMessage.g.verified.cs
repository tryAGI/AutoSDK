//HintName: G.Models.RepositoryWebhooksTemplateRepositoryMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum RepositoryWebhooksTemplateRepositoryMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        BLANK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryWebhooksTemplateRepositoryMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksTemplateRepositoryMergeCommitMessage value)
        {
            return value switch
            {
                RepositoryWebhooksTemplateRepositoryMergeCommitMessage.PRBODY => "PR_BODY",
                RepositoryWebhooksTemplateRepositoryMergeCommitMessage.PRTITLE => "PR_TITLE",
                RepositoryWebhooksTemplateRepositoryMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksTemplateRepositoryMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => RepositoryWebhooksTemplateRepositoryMergeCommitMessage.PRBODY,
                "PR_TITLE" => RepositoryWebhooksTemplateRepositoryMergeCommitMessage.PRTITLE,
                "BLANK" => RepositoryWebhooksTemplateRepositoryMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}