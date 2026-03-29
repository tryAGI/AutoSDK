//HintName: G.Models.ApiProjectTemplatesCreateProjectCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectTemplatesCreateProjectCreateRequest
    {
        /// <summary>
        /// A description for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The title of the project to be created from the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// A unique integer value identifying the workspace in which to create the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectTemplatesCreateProjectCreateRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the project to be created from the template.
        /// </param>
        /// <param name="workspaceId">
        /// A unique integer value identifying the workspace in which to create the project.
        /// </param>
        /// <param name="description">
        /// A description for the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectTemplatesCreateProjectCreateRequest(
            string title,
            int workspaceId,
            string? description)
        {
            this.Description = description;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectTemplatesCreateProjectCreateRequest" /> class.
        /// </summary>
        public ApiProjectTemplatesCreateProjectCreateRequest()
        {
        }
    }
}