//HintName: G.Models.WebhookSecurityAndAnalysisChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSecurityAndAnalysisChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public global::G.WebhookSecurityAndAnalysisChangesFrom? From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAndAnalysisChanges" /> class.
        /// </summary>
        /// <param name="from"></param>
        public WebhookSecurityAndAnalysisChanges(
            global::G.WebhookSecurityAndAnalysisChangesFrom? from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAndAnalysisChanges" /> class.
        /// </summary>
        public WebhookSecurityAndAnalysisChanges()
        {
        }
    }
}