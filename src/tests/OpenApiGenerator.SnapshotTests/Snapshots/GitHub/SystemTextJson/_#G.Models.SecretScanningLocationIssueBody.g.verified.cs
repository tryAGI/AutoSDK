//HintName: G.Models.SecretScanningLocationIssueBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an 'issue_body' secret scanning location type. This location type shows that a secret was detected in the body of an issue.
    /// </summary>
    public sealed partial class SecretScanningLocationIssueBody
    {
        /// <summary>
        /// The API URL to get the issue where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_body_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueBodyUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}