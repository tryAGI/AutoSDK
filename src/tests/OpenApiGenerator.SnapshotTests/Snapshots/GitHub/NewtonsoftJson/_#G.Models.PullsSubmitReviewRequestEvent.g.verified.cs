//HintName: G.Models.PullsSubmitReviewRequestEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. When you leave this blank, the API returns _HTTP 422 (Unrecognizable entity)_ and sets the review action state to `PENDING`, which means you will need to re-submit the pull request review using a review action.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullsSubmitReviewRequestEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="APPROVE")]
        APPROVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REQUEST_CHANGES")]
        REQUESTCHANGES,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMMENT")]
        COMMENT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsSubmitReviewRequestEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsSubmitReviewRequestEvent value)
        {
            return value switch
            {
                PullsSubmitReviewRequestEvent.APPROVE => "APPROVE",
                PullsSubmitReviewRequestEvent.REQUESTCHANGES => "REQUEST_CHANGES",
                PullsSubmitReviewRequestEvent.COMMENT => "COMMENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsSubmitReviewRequestEvent ToEnum(string value)
        {
            return value switch
            {
                "APPROVE" => PullsSubmitReviewRequestEvent.APPROVE,
                "REQUEST_CHANGES" => PullsSubmitReviewRequestEvent.REQUESTCHANGES,
                "COMMENT" => PullsSubmitReviewRequestEvent.COMMENT,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}