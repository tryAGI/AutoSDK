//HintName: G.Models.ProjectsCreateCardRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsCreateCardRequestVariant2
    {
        /// <summary>
        /// The unique identifier of the content associated with the card<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentId { get; set; }

        /// <summary>
        /// The piece of content associated with the card<br/>
        /// Example: PullRequest
        /// </summary>
        /// <example>PullRequest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateCardRequestVariant2" /> class.
        /// </summary>
        /// <param name="contentId">
        /// The unique identifier of the content associated with the card<br/>
        /// Example: 42
        /// </param>
        /// <param name="contentType">
        /// The piece of content associated with the card<br/>
        /// Example: PullRequest
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectsCreateCardRequestVariant2(
            int contentId,
            string contentType)
        {
            this.ContentId = contentId;
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateCardRequestVariant2" /> class.
        /// </summary>
        public ProjectsCreateCardRequestVariant2()
        {
        }
    }
}