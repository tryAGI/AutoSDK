//HintName: G.Models.PullRequestReviewCommentSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullRequestReviewCommentSubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line")]
        Line,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
    }
}