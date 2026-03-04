//HintName: G.Models.RepositoryWebhooksMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryWebhooksMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PrTitle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MERGE_MESSAGE")]
        MergeMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryWebhooksMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksMergeCommitTitle value)
        {
            return value switch
            {
                RepositoryWebhooksMergeCommitTitle.PrTitle => "PR_TITLE",
                RepositoryWebhooksMergeCommitTitle.MergeMessage => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => RepositoryWebhooksMergeCommitTitle.PrTitle,
                "MERGE_MESSAGE" => RepositoryWebhooksMergeCommitTitle.MergeMessage,
                _ => null,
            };
        }
    }
}