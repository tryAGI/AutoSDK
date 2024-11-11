//HintName: G.Models.RepositoryRulesetLinksHtml.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRulesetLinksHtml
    {
        /// <summary>
        /// The html URL of the ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetLinksHtml" /> class.
        /// </summary>
        /// <param name="href">
        /// The html URL of the ruleset
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRulesetLinksHtml(
            string? href)
        {
            this.Href = href;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetLinksHtml" /> class.
        /// </summary>
        public RepositoryRulesetLinksHtml()
        {
        }
    }
}