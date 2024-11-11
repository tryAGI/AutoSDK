//HintName: G.Models.WebhookRepositoryEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch")]
        public global::G.WebhookRepositoryEditedChangesDefaultBranch? DefaultBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::G.WebhookRepositoryEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        public global::G.WebhookRepositoryEditedChangesHomepage? Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::G.WebhookRepositoryEditedChangesTopics? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryEditedChanges" /> class.
        /// </summary>
        /// <param name="defaultBranch"></param>
        /// <param name="description"></param>
        /// <param name="homepage"></param>
        /// <param name="topics"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRepositoryEditedChanges(
            global::G.WebhookRepositoryEditedChangesDefaultBranch? defaultBranch,
            global::G.WebhookRepositoryEditedChangesDescription? description,
            global::G.WebhookRepositoryEditedChangesHomepage? homepage,
            global::G.WebhookRepositoryEditedChangesTopics? topics)
        {
            this.DefaultBranch = defaultBranch;
            this.Description = description;
            this.Homepage = homepage;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryEditedChanges" /> class.
        /// </summary>
        public WebhookRepositoryEditedChanges()
        {
        }
    }
}