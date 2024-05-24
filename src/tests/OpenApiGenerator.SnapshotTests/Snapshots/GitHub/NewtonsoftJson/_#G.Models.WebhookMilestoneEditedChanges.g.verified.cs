//HintName: G.Models.WebhookMilestoneEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the milestone if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookMilestoneEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public WebhookMilestoneEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("due_on")]
        public WebhookMilestoneEditedChangesDueOn? DueOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public WebhookMilestoneEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}