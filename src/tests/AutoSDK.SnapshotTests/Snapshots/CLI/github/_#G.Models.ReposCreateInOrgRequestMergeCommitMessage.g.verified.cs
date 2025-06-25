﻿//HintName: G.Models.ReposCreateInOrgRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum ReposCreateInOrgRequestMergeCommitMessage
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
    public static class ReposCreateInOrgRequestMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateInOrgRequestMergeCommitMessage value)
        {
            return value switch
            {
                ReposCreateInOrgRequestMergeCommitMessage.PRBODY => "PR_BODY",
                ReposCreateInOrgRequestMergeCommitMessage.PRTITLE => "PR_TITLE",
                ReposCreateInOrgRequestMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateInOrgRequestMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => ReposCreateInOrgRequestMergeCommitMessage.PRBODY,
                "PR_TITLE" => ReposCreateInOrgRequestMergeCommitMessage.PRTITLE,
                "BLANK" => ReposCreateInOrgRequestMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}