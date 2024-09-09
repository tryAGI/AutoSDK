//HintName: G.Models.SecretScanningLocationPullRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'pull_request_body' secret scanning location type. This location type shows that a secret was detected in the body of a pull request.
    /// </summary>
    public sealed partial class SecretScanningLocationPullRequestBody
    {
        /// <summary>
        /// The API URL to get the pull request where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pull/2846
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_body_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullRequestBodyUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}