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
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The title of the project to be created from the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A unique integer value identifying the workspace in which to create the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkspaceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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