//HintName: G.Models.WebhookRepositoryRulesetEditedChangesEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesEnforcement" /> class.
        /// </summary>
        /// <param name="from"></param>
        public WebhookRepositoryRulesetEditedChangesEnforcement(
            string? from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesEnforcement" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesEnforcement()
        {
        }
    }
}