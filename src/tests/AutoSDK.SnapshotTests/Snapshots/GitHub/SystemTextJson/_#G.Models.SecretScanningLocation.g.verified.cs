//HintName: G.Models.SecretScanningLocation.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningLocation
    {
        /// <summary>
        /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.<br/>
        /// Example: commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SecretScanningLocationTypeJsonConverter))]
        public global::G.SecretScanningLocationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverterFactory13))]
        public global::G.OneOf<global::G.SecretScanningLocationCommit, global::G.SecretScanningLocationWikiCommit, global::G.SecretScanningLocationIssueTitle, global::G.SecretScanningLocationIssueBody, global::G.SecretScanningLocationIssueComment, global::G.SecretScanningLocationDiscussionTitle, global::G.SecretScanningLocationDiscussionBody, global::G.SecretScanningLocationDiscussionComment, global::G.SecretScanningLocationPullRequestTitle, global::G.SecretScanningLocationPullRequestBody, global::G.SecretScanningLocationPullRequestComment, global::G.SecretScanningLocationPullRequestReview, global::G.SecretScanningLocationPullRequestReviewComment>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}