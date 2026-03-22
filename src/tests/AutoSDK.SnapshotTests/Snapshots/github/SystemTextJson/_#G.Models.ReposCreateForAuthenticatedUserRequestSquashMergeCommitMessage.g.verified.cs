//HintName: G.Models.ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        CommitMessages,
        /// <summary>
        /// 
        /// </summary>
        PrBody,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage value)
        {
            return value switch
            {
                ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage.Blank => "BLANK",
                ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage.PrBody => "PR_BODY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage.Blank,
                "COMMIT_MESSAGES" => ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage.CommitMessages,
                "PR_BODY" => ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage.PrBody,
                _ => null,
            };
        }
    }
}