//HintName: G.Models.SecretScanningLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.<br/>
    /// Example: commit
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commit")]
        Commit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wiki_commit")]
        WikiCommit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issue_title")]
        IssueTitle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issue_body")]
        IssueBody,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issue_comment")]
        IssueComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion_title")]
        DiscussionTitle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion_body")]
        DiscussionBody,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="discussion_comment")]
        DiscussionComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_title")]
        PullRequestTitle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_body")]
        PullRequestBody,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_comment")]
        PullRequestComment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review")]
        PullRequestReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_request_review_comment")]
        PullRequestReviewComment,
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
                SecretScanningLocationType.WikiCommit => "wiki_commit",
                SecretScanningLocationType.IssueTitle => "issue_title",
                SecretScanningLocationType.IssueBody => "issue_body",
                SecretScanningLocationType.IssueComment => "issue_comment",
                SecretScanningLocationType.DiscussionTitle => "discussion_title",
                SecretScanningLocationType.DiscussionBody => "discussion_body",
                SecretScanningLocationType.DiscussionComment => "discussion_comment",
                SecretScanningLocationType.PullRequestTitle => "pull_request_title",
                SecretScanningLocationType.PullRequestBody => "pull_request_body",
                SecretScanningLocationType.PullRequestComment => "pull_request_comment",
                SecretScanningLocationType.PullRequestReview => "pull_request_review",
                SecretScanningLocationType.PullRequestReviewComment => "pull_request_review_comment",
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
                "wiki_commit" => SecretScanningLocationType.WikiCommit,
                "issue_title" => SecretScanningLocationType.IssueTitle,
                "issue_body" => SecretScanningLocationType.IssueBody,
                "issue_comment" => SecretScanningLocationType.IssueComment,
                "discussion_title" => SecretScanningLocationType.DiscussionTitle,
                "discussion_body" => SecretScanningLocationType.DiscussionBody,
                "discussion_comment" => SecretScanningLocationType.DiscussionComment,
                "pull_request_title" => SecretScanningLocationType.PullRequestTitle,
                "pull_request_body" => SecretScanningLocationType.PullRequestBody,
                "pull_request_comment" => SecretScanningLocationType.PullRequestComment,
                "pull_request_review" => SecretScanningLocationType.PullRequestReview,
                "pull_request_review_comment" => SecretScanningLocationType.PullRequestReviewComment,
                _ => null,
            };
        }
    }
}