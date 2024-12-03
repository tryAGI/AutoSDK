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
        [global::Newtonsoft.Json.JsonProperty("content_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentId { get; set; } = default!;

        /// <summary>
        /// The piece of content associated with the card<br/>
        /// Example: PullRequest
        /// </summary>
        /// <example>PullRequest</example>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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