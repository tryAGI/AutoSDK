//HintName: G.Models.PullRequestReviewCommentSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment
    /// <br/>Default Value: RIGHT
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullRequestReviewCommentSide
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LEFT")]
        LEFT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RIGHT")]
        RIGHT,
    }
}