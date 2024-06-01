//HintName: G.Models.ReposCreateInOrgRequestSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum ReposCreateInOrgRequestSquashMergeCommitMessage
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
    public static class ReposCreateInOrgRequestSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateInOrgRequestSquashMergeCommitMessage value)
        {
            return value switch
            {
                ReposCreateInOrgRequestSquashMergeCommitMessage.PRBODY => "PR_BODY",
                ReposCreateInOrgRequestSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                ReposCreateInOrgRequestSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateInOrgRequestSquashMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => ReposCreateInOrgRequestSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => ReposCreateInOrgRequestSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => ReposCreateInOrgRequestSquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}