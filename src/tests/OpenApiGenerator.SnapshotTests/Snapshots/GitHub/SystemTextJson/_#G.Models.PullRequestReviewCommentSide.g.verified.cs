//HintName: G.Models.PullRequestReviewCommentSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment
    /// <br/>Default Value: RIGHT
    /// </summary>
    public abstract class PullRequestReviewCommentSide
    {
        /// <summary>
        /// 
        /// </summary>
        public const string LEFT = "LEFT";
        /// <summary>
        /// 
        /// </summary>
        public const string RIGHT = "RIGHT";
    }
}