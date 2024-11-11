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
        [global::System.Text.Json.Serialization.JsonPropertyName("github_owned_allowed")]
        public bool? GithubOwnedAllowed { get; set; }

        /// <summary>
        /// Whether actions from GitHub Marketplace verified creators are allowed. Set to `true` to allow all actions by GitHub Marketplace verified creators.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_allowed")]
        public bool? VerifiedAllowed { get; set; }

        /// <summary>
        /// Specifies a list of string-matching patterns to allow specific action(s) and reusable workflow(s). Wildcards, tags, and SHAs are allowed. For example, `monalisa/octocat@*`, `monalisa/octocat@v2`, `monalisa/*`.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The `patterns_allowed` setting only applies to public repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patterns_allowed")]
        public global::System.Collections.Generic.IList<string>? PatternsAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedActions" /> class.
        /// </summary>
        /// <param name="githubOwnedAllowed">
        /// Whether GitHub-owned actions are allowed. For example, this includes the actions in the `actions` organization.
        /// </param>
        /// <param name="verifiedAllowed">
        /// Whether actions from GitHub Marketplace verified creators are allowed. Set to `true` to allow all actions by GitHub Marketplace verified creators.
        /// </param>
        /// <param name="patternsAllowed">
        /// Specifies a list of string-matching patterns to allow specific action(s) and reusable workflow(s). Wildcards, tags, and SHAs are allowed. For example, `monalisa/octocat@*`, `monalisa/octocat@v2`, `monalisa/*`.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The `patterns_allowed` setting only applies to public repositories.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SelectedActions(
            bool? githubOwnedAllowed,
            bool? verifiedAllowed,
            global::System.Collections.Generic.IList<string>? patternsAllowed)
        {
            this.GithubOwnedAllowed = githubOwnedAllowed;
            this.VerifiedAllowed = verifiedAllowed;
            this.PatternsAllowed = patternsAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedActions" /> class.
        /// </summary>
        public SelectedActions()
        {
        }
    }
}