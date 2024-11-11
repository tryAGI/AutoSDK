//HintName: G.Models.CommitParent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommitParent
    {
        /// <summary>
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </summary>
        /// <example>7638417db6d59f3c431d3e1f261cc637155684cd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/7638417db6d59f3c431d3e1f261cc637155684cd
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/commits/7638417db6d59f3c431d3e1f261cc637155684cd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/commit/7638417db6d59f3c431d3e1f261cc637155684cd
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/commit/7638417db6d59f3c431d3e1f261cc637155684cd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitParent" /> class.
        /// </summary>
        /// <param name="sha">
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/7638417db6d59f3c431d3e1f261cc637155684cd
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/commit/7638417db6d59f3c431d3e1f261cc637155684cd
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CommitParent(
            string sha,
            string url,
            string? htmlUrl)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitParent" /> class.
        /// </summary>
        public CommitParent()
        {
        }
    }
}