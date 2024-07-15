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
        /// 
        /// </summary>
        APPROVE,
        /// <summary>
        /// 
        /// </summary>
        REQUESTCHANGES,
        /// <summary>
        /// 
        /// </summary>
        COMMENT,
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
                PullsCreateReviewRequestEvent.APPROVE => "APPROVE",
                PullsCreateReviewRequestEvent.REQUESTCHANGES => "REQUEST_CHANGES",
                PullsCreateReviewRequestEvent.COMMENT => "COMMENT",
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
                "APPROVE" => PullsCreateReviewRequestEvent.APPROVE,
                "REQUEST_CHANGES" => PullsCreateReviewRequestEvent.REQUESTCHANGES,
                "COMMENT" => PullsCreateReviewRequestEvent.COMMENT,
                _ => null,
            };
        }
    }
}