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
        [global::Newtonsoft.Json.JsonProperty("pull_request_body_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullRequestBodyUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}