//HintName: G.Models.PullRequestReviewCommentSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    public abstract class PullRequestReviewCommentSubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Line = "line";
        /// <summary>
        /// 
        /// </summary>
        public const string File = "file";
    }
}