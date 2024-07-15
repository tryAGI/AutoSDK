//HintName: G.Models.SelectedActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SelectedActions
    {
        /// <summary>
        /// Whether GitHub-owned actions are allowed. For example, this includes the actions in the `actions` organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_owned_allowed")]
        public bool GithubOwnedAllowed { get; set; }

        /// <summary>
        /// Whether actions from GitHub Marketplace verified creators are allowed. Set to `true` to allow all actions by GitHub Marketplace verified creators.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verified_allowed")]
        public bool VerifiedAllowed { get; set; }

        /// <summary>
        /// Specifies a list of string-matching patterns to allow specific action(s) and reusable workflow(s). Wildcards, tags, and SHAs are allowed. For example, `monalisa/octocat@*`, `monalisa/octocat@v2`, `monalisa/*`.<br/>
        /// **Note**: The `patterns_allowed` setting only applies to public repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patterns_allowed")]
        public global::System.Collections.Generic.IList<string?>? PatternsAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}