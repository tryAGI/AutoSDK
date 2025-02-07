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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::G.WebhookMilestoneEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("due_on")]
        public global::G.WebhookMilestoneEditedChangesDueOn? DueOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public global::G.WebhookMilestoneEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMilestoneEditedChanges" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="dueOn"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookMilestoneEditedChanges(
            global::G.WebhookMilestoneEditedChangesDescription? description,
            global::G.WebhookMilestoneEditedChangesDueOn? dueOn,
            global::G.WebhookMilestoneEditedChangesTitle? title)
        {
            this.Description = description;
            this.DueOn = dueOn;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMilestoneEditedChanges" /> class.
        /// </summary>
        public WebhookMilestoneEditedChanges()
        {
        }
    }
}