//HintName: G.Models.WebhookProjectsV2ProjectEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ProjectEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::G.WebhookProjectsV2ProjectEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public global::G.WebhookProjectsV2ProjectEditedChangesPublic? Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_description")]
        public global::G.WebhookProjectsV2ProjectEditedChangesShortDescription? ShortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public global::G.WebhookProjectsV2ProjectEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ProjectEditedChanges" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="public"></param>
        /// <param name="shortDescription"></param>
        /// <param name="title"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookProjectsV2ProjectEditedChanges(
            global::G.WebhookProjectsV2ProjectEditedChangesDescription? description,
            global::G.WebhookProjectsV2ProjectEditedChangesPublic? @public,
            global::G.WebhookProjectsV2ProjectEditedChangesShortDescription? shortDescription,
            global::G.WebhookProjectsV2ProjectEditedChangesTitle? title)
        {
            this.Description = description;
            this.Public = @public;
            this.ShortDescription = shortDescription;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ProjectEditedChanges" /> class.
        /// </summary>
        public WebhookProjectsV2ProjectEditedChanges()
        {
        }
    }
}