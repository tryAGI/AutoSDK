﻿//HintName: G.Models.ReposUpdateRequestSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required when using `squash_merge_commit_message`.<br/>
    /// The default value for a squash merge commit title:<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    public enum ReposUpdateRequestSquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        COMMITORPRTITLE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateRequestSquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRequestSquashMergeCommitTitle value)
        {
            return value switch
            {
                ReposUpdateRequestSquashMergeCommitTitle.PRTITLE => "PR_TITLE",
                ReposUpdateRequestSquashMergeCommitTitle.COMMITORPRTITLE => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRequestSquashMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => ReposUpdateRequestSquashMergeCommitTitle.PRTITLE,
                "COMMIT_OR_PR_TITLE" => ReposUpdateRequestSquashMergeCommitTitle.COMMITORPRTITLE,
                _ => null,
            };
        }
    }
}