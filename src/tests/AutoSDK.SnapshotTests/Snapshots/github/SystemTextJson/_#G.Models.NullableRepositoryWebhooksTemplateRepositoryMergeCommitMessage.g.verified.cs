//HintName: G.Models.NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        PrBody,
        /// <summary>
        /// 
        /// </summary>
        PrTitle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage value)
        {
            return value switch
            {
                NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage.Blank => "BLANK",
                NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage.PrBody => "PR_BODY",
                NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage.Blank,
                "PR_BODY" => NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage.PrBody,
                "PR_TITLE" => NullableRepositoryWebhooksTemplateRepositoryMergeCommitMessage.PrTitle,
                _ => null,
            };
        }
    }
}