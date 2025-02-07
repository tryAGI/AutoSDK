//HintName: G.Models.SecretScanningLocationPullRequestTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'pull_request_title' secret scanning location type. This location type shows that a secret was detected in the title of a pull request.
    /// </summary>
    public sealed partial class SecretScanningLocationPullRequestTitle
    {
        /// <summary>
        /// The API URL to get the pull request where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pull/2846
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pull/2846</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_title_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullRequestTitleUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationPullRequestTitle" /> class.
        /// </summary>
        /// <param name="pullRequestTitleUrl">
        /// The API URL to get the pull request where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pull/2846
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningLocationPullRequestTitle(
            string pullRequestTitleUrl)
        {
            this.PullRequestTitleUrl = pullRequestTitleUrl ?? throw new global::System.ArgumentNullException(nameof(pullRequestTitleUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationPullRequestTitle" /> class.
        /// </summary>
        public SecretScanningLocationPullRequestTitle()
        {
        }
    }
}