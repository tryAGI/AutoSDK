﻿//HintName: G.Models.ReposCreateInOrgRequestMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required when using `merge_commit_message`.<br/>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposCreateInOrgRequestMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MERGE_MESSAGE")]
        MERGEMESSAGE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposCreateInOrgRequestMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateInOrgRequestMergeCommitTitle value)
        {
            return value switch
            {
                ReposCreateInOrgRequestMergeCommitTitle.PRTITLE => "PR_TITLE",
                ReposCreateInOrgRequestMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateInOrgRequestMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => ReposCreateInOrgRequestMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => ReposCreateInOrgRequestMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}