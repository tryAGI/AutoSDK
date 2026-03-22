//HintName: G.Models.PullsSubmitReviewRequestEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. When you leave this blank, the API returns _HTTP 422 (Unrecognizable entity)_ and sets the review action state to `PENDING`, which means you will need to re-submit the pull request review using a review action.
    /// </summary>
    public enum PullsSubmitReviewRequestEvent
    {
        /// <summary>
        /// `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. When you leave this blank, the API returns _HTTP 422 (Unrecognizable entity)_ and sets the review action state to `PENDING`, which means you will need to re-submit the pull request review using a review action.
        /// </summary>
        Approve,
        /// <summary>
        /// `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. When you leave this blank, the API returns _HTTP 422 (Unrecognizable entity)_ and sets the review action state to `PENDING`, which means you will need to re-submit the pull request review using a review action.
        /// </summary>
        Comment,
        /// <summary>
        /// `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. When you leave this blank, the API returns _HTTP 422 (Unrecognizable entity)_ and sets the review action state to `PENDING`, which means you will need to re-submit the pull request review using a review action.
        /// </summary>
        RequestChanges,
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
                PullsSubmitReviewRequestEvent.Approve => "APPROVE",
                PullsSubmitReviewRequestEvent.Comment => "COMMENT",
                PullsSubmitReviewRequestEvent.RequestChanges => "REQUEST_CHANGES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsSubmitReviewRequestEvent? ToEnum(string value)
        {
            return value switch
            {
                "APPROVE" => PullsSubmitReviewRequestEvent.Approve,
                "COMMENT" => PullsSubmitReviewRequestEvent.Comment,
                "REQUEST_CHANGES" => PullsSubmitReviewRequestEvent.RequestChanges,
                _ => null,
            };
        }
    }
}