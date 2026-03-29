//HintName: G.Models.ListWorkflowsResponseWorkflow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Workflow information
    /// </summary>
    public sealed partial class ListWorkflowsResponseWorkflow
    {
        /// <summary>
        /// Unique workflow name/slug within the user's namespace<br/>
        /// Example: my-image-workflow
        /// </summary>
        /// <example>my-image-workflow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable workflow title<br/>
        /// Example: My Image Generation Workflow
        /// </summary>
        /// <example>My Image Generation Workflow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Display name/username of the owner<br/>
        /// Example: johndoe
        /// </summary>
        /// <example>johndoe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_nickname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserNickname { get; set; }

        /// <summary>
        /// ISO8601 timestamp of workflow creation<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// URL to the workflow thumbnail image<br/>
        /// Example: https://fal.ai/workflows/thumb_abc123.png
        /// </summary>
        /// <example>https://fal.ai/workflows/thumb_abc123.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// Brief description of what the workflow does<br/>
        /// Example: Generate high-quality images using FLUX model
        /// </summary>
        /// <example>Generate high-quality images using FLUX model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Tags associated with the workflow<br/>
        /// Example: [image-generation, ai, flux]
        /// </summary>
        /// <example>[image-generation, ai, flux]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// List of model endpoint IDs used in this workflow<br/>
        /// Example: [fal-ai/flux/dev, fal-ai/face-swap]
        /// </summary>
        /// <example>[fal-ai/flux/dev, fal-ai/face-swap]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EndpointIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowsResponseWorkflow" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique workflow name/slug within the user's namespace<br/>
        /// Example: my-image-workflow
        /// </param>
        /// <param name="title">
        /// Human-readable workflow title<br/>
        /// Example: My Image Generation Workflow
        /// </param>
        /// <param name="userNickname">
        /// Display name/username of the owner<br/>
        /// Example: johndoe
        /// </param>
        /// <param name="createdAt">
        /// ISO8601 timestamp of workflow creation<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow<br/>
        /// Example: [image-generation, ai, flux]
        /// </param>
        /// <param name="endpointIds">
        /// List of model endpoint IDs used in this workflow<br/>
        /// Example: [fal-ai/flux/dev, fal-ai/face-swap]
        /// </param>
        /// <param name="thumbnailUrl">
        /// URL to the workflow thumbnail image<br/>
        /// Example: https://fal.ai/workflows/thumb_abc123.png
        /// </param>
        /// <param name="description">
        /// Brief description of what the workflow does<br/>
        /// Example: Generate high-quality images using FLUX model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorkflowsResponseWorkflow(
            string name,
            string title,
            string userNickname,
            string createdAt,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Collections.Generic.IList<string> endpointIds,
            string? thumbnailUrl,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UserNickname = userNickname ?? throw new global::System.ArgumentNullException(nameof(userNickname));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ThumbnailUrl = thumbnailUrl;
            this.Description = description;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.EndpointIds = endpointIds ?? throw new global::System.ArgumentNullException(nameof(endpointIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowsResponseWorkflow" /> class.
        /// </summary>
        public ListWorkflowsResponseWorkflow()
        {
        }
    }
}