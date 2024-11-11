//HintName: G.Models.WebhookRepositoryRulesetEditedChangesConditions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesConditions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRulesetConditions>? Added { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRulesetConditions>? Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public global::System.Collections.Generic.IList<global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem>? Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditions" /> class.
        /// </summary>
        /// <param name="added"></param>
        /// <param name="deleted"></param>
        /// <param name="updated"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRepositoryRulesetEditedChangesConditions(
            global::System.Collections.Generic.IList<global::G.RepositoryRulesetConditions>? added,
            global::System.Collections.Generic.IList<global::G.RepositoryRulesetConditions>? deleted,
            global::System.Collections.Generic.IList<global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem>? updated)
        {
            this.Added = added;
            this.Deleted = deleted;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditions" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesConditions()
        {
        }
    }
}