//HintName: G.Models.WebhookRepositoryRulesetEditedChangesRules.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRules
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRule>? Added { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRule>? Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public global::System.Collections.Generic.IList<global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItem>? Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRules" /> class.
        /// </summary>
        /// <param name="added"></param>
        /// <param name="deleted"></param>
        /// <param name="updated"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRepositoryRulesetEditedChangesRules(
            global::System.Collections.Generic.IList<global::G.RepositoryRule>? added,
            global::System.Collections.Generic.IList<global::G.RepositoryRule>? deleted,
            global::System.Collections.Generic.IList<global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItem>? updated)
        {
            this.Added = added;
            this.Deleted = deleted;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRules" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesRules()
        {
        }
    }
}