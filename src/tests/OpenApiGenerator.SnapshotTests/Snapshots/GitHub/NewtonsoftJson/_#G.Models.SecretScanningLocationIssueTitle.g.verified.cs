//HintName: G.Models.SecretScanningLocationIssueTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an 'issue_title' secret scanning location type. This location type shows that a secret was detected in the title of an issue.
    /// </summary>
    public sealed partial class SecretScanningLocationIssueTitle
    {
        /// <summary>
        /// The API URL to get the issue where the secret was detected.
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_title_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssueTitleUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}