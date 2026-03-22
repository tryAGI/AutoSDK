//HintName: G.Models.PullsCreateReviewRequestEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/pulls/reviews#submit-a-review-for-a-pull-request) when you are ready.
    /// </summary>
    public enum PullsCreateReviewRequestEvent
    {
        /// <summary>
        /// `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/pulls/reviews#submit-a-review-for-a-pull-request) when you are ready.
        /// </summary>
        Approve,
        /// <summary>
        /// `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/pulls/reviews#submit-a-review-for-a-pull-request) when you are ready.
        /// </summary>
        Comment,
        /// <summary>
        /// `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/pulls/reviews#submit-a-review-for-a-pull-request) when you are ready.
        /// </summary>
        RequestChanges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsCreateReviewRequestEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsCreateReviewRequestEvent value)
        {
            return value switch
            {
                PullsCreateReviewRequestEvent.Approve => "APPROVE",
                PullsCreateReviewRequestEvent.Comment => "COMMENT",
                PullsCreateReviewRequestEvent.RequestChanges => "REQUEST_CHANGES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsCreateReviewRequestEvent? ToEnum(string value)
        {
            return value switch
            {
                "APPROVE" => PullsCreateReviewRequestEvent.Approve,
                "COMMENT" => PullsCreateReviewRequestEvent.Comment,
                "REQUEST_CHANGES" => PullsCreateReviewRequestEvent.RequestChanges,
                _ => null,
            };
        }
    }
}