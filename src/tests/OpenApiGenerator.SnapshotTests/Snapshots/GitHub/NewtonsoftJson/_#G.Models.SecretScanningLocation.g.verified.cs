//HintName: G.Models.SecretScanningLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningLocation
    {
        /// <summary>
        /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.
        /// <br/>Example: commit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public SecretScanningLocationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::System.OneOf<SecretScanningLocationCommit?, SecretScanningLocationWikiCommit?, SecretScanningLocationIssueTitle?, SecretScanningLocationIssueBody?, SecretScanningLocationIssueComment?, SecretScanningLocationDiscussionTitle?, SecretScanningLocationDiscussionBody?, SecretScanningLocationDiscussionComment?, SecretScanningLocationPullRequestTitle?, SecretScanningLocationPullRequestBody?, SecretScanningLocationPullRequestComment?, SecretScanningLocationPullRequestReview?, SecretScanningLocationPullRequestReviewComment?> Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}