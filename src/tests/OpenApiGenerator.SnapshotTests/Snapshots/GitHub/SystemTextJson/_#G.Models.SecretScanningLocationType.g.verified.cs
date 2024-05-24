//HintName: G.Models.SecretScanningLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.
    /// <br/>Example: commit
    /// </summary>
    public abstract class SecretScanningLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Commit = "commit";
        /// <summary>
        /// 
        /// </summary>
        public const string WikiCommit = "wiki_commit";
        /// <summary>
        /// 
        /// </summary>
        public const string IssueTitle = "issue_title";
        /// <summary>
        /// 
        /// </summary>
        public const string IssueBody = "issue_body";
        /// <summary>
        /// 
        /// </summary>
        public const string IssueComment = "issue_comment";
        /// <summary>
        /// 
        /// </summary>
        public const string DiscussionTitle = "discussion_title";
        /// <summary>
        /// 
        /// </summary>
        public const string DiscussionBody = "discussion_body";
        /// <summary>
        /// 
        /// </summary>
        public const string DiscussionComment = "discussion_comment";
        /// <summary>
        /// 
        /// </summary>
        public const string PullRequestTitle = "pull_request_title";
        /// <summary>
        /// 
        /// </summary>
        public const string PullRequestBody = "pull_request_body";
        /// <summary>
        /// 
        /// </summary>
        public const string PullRequestComment = "pull_request_comment";
        /// <summary>
        /// 
        /// </summary>
        public const string PullRequestReview = "pull_request_review";
        /// <summary>
        /// 
        /// </summary>
        public const string PullRequestReviewComment = "pull_request_review_comment";
    }
}