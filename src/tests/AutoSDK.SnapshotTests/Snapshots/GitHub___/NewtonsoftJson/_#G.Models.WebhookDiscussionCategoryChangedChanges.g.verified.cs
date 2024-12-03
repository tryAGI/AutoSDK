//HintName: G.Models.WebhookDiscussionCategoryChangedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDiscussionCategoryChangedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDiscussionCategoryChangedChangesCategory Category { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionCategoryChangedChanges" /> class.
        /// </summary>
        /// <param name="category"></param>
        public WebhookDiscussionCategoryChangedChanges(
            global::G.WebhookDiscussionCategoryChangedChangesCategory category)
        {
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionCategoryChangedChanges" /> class.
        /// </summary>
        public WebhookDiscussionCategoryChangedChanges()
        {
        }
    }
}