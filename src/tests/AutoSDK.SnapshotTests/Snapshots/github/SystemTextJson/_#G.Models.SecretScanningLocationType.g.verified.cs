//HintName: G.Models.SecretScanningLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.<br/>
    /// Example: commit
    /// </summary>
    public enum SecretScanningLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Commit,
        /// <summary>
        /// 
        /// </summary>
        DiscussionBody,
        /// <summary>
        /// 
        /// </summary>
        DiscussionComment,
        /// <summary>
        /// 
        /// </summary>
        DiscussionTitle,
        /// <summary>
        /// 
        /// </summary>
        IssueBody,
        /// <summary>
        /// 
        /// </summary>
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        IssueTitle,
        /// <summary>
        /// 
        /// </summary>
        PullRequestBody,
        /// <summary>
        /// 
        /// </summary>
        PullRequestComment,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReview,
        /// <summary>
        /// 
        /// </summary>
        PullRequestReviewComment,
        /// <summary>
        /// 
        /// </summary>
        PullRequestTitle,
        /// <summary>
        /// 
        /// </summary>
        WikiCommit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningLocationType value)
        {
            return value switch
            {
                SecretScanningLocationType.Commit => "commit",
                SecretScanningLocationType.DiscussionBody => "discussion_body",
                SecretScanningLocationType.DiscussionComment => "discussion_comment",
                SecretScanningLocationType.DiscussionTitle => "discussion_title",
                SecretScanningLocationType.IssueBody => "issue_body",
                SecretScanningLocationType.IssueComment => "issue_comment",
                SecretScanningLocationType.IssueTitle => "issue_title",
                SecretScanningLocationType.PullRequestBody => "pull_request_body",
                SecretScanningLocationType.PullRequestComment => "pull_request_comment",
                SecretScanningLocationType.PullRequestReview => "pull_request_review",
                SecretScanningLocationType.PullRequestReviewComment => "pull_request_review_comment",
                SecretScanningLocationType.PullRequestTitle => "pull_request_title",
                SecretScanningLocationType.WikiCommit => "wiki_commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningLocationType? ToEnum(string value)
        {
            return value switch
            {
                "commit" => SecretScanningLocationType.Commit,
                "discussion_body" => SecretScanningLocationType.DiscussionBody,
                "discussion_comment" => SecretScanningLocationType.DiscussionComment,
                "discussion_title" => SecretScanningLocationType.DiscussionTitle,
                "issue_body" => SecretScanningLocationType.IssueBody,
                "issue_comment" => SecretScanningLocationType.IssueComment,
                "issue_title" => SecretScanningLocationType.IssueTitle,
                "pull_request_body" => SecretScanningLocationType.PullRequestBody,
                "pull_request_comment" => SecretScanningLocationType.PullRequestComment,
                "pull_request_review" => SecretScanningLocationType.PullRequestReview,
                "pull_request_review_comment" => SecretScanningLocationType.PullRequestReviewComment,
                "pull_request_title" => SecretScanningLocationType.PullRequestTitle,
                "wiki_commit" => SecretScanningLocationType.WikiCommit,
                _ => null,
            };
        }
    }
}