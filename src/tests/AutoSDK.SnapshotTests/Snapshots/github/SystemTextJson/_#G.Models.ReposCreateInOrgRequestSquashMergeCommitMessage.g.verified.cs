//HintName: G.Models.ReposCreateInOrgRequestSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum ReposCreateInOrgRequestSquashMergeCommitMessage
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
    public static class ReposCreateInOrgRequestSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateInOrgRequestSquashMergeCommitMessage value)
        {
            return value switch
            {
                ReposCreateInOrgRequestSquashMergeCommitMessage.Blank => "BLANK",
                ReposCreateInOrgRequestSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                ReposCreateInOrgRequestSquashMergeCommitMessage.PrBody => "PR_BODY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateInOrgRequestSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => ReposCreateInOrgRequestSquashMergeCommitMessage.Blank,
                "COMMIT_MESSAGES" => ReposCreateInOrgRequestSquashMergeCommitMessage.CommitMessages,
                "PR_BODY" => ReposCreateInOrgRequestSquashMergeCommitMessage.PrBody,
                _ => null,
            };
        }
    }
}