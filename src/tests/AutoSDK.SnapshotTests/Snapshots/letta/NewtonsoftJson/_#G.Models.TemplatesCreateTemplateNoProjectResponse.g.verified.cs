//HintName: G.Models.TemplatesCreateTemplateNoProjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesCreateTemplateNoProjectResponse
    {
        /// <summary>
        /// The exact name of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectSlug { get; set; } = default!;

        /// <summary>
        /// The latest version of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string LatestVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The full name of the template, including version and project slug
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_deployment_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateDeploymentSlug { get; set; } = default!;

        /// <summary>
        /// When the template was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateNoProjectResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// The exact name of the template
        /// </param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="projectSlug"></param>
        /// <param name="latestVersion">
        /// The latest version of the template
        /// </param>
        /// <param name="templateDeploymentSlug">
        /// The full name of the template, including version and project slug
        /// </param>
        /// <param name="updatedAt">
        /// When the template was last updated
        /// </param>
        /// <param name="description"></param>
        public TemplatesCreateTemplateNoProjectResponse(
            string name,
            string id,
            string projectId,
            string projectSlug,
            string latestVersion,
            string templateDeploymentSlug,
            string updatedAt,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectSlug = projectSlug ?? throw new global::System.ArgumentNullException(nameof(projectSlug));
            this.LatestVersion = latestVersion ?? throw new global::System.ArgumentNullException(nameof(latestVersion));
            this.Description = description;
            this.TemplateDeploymentSlug = templateDeploymentSlug ?? throw new global::System.ArgumentNullException(nameof(templateDeploymentSlug));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateNoProjectResponse" /> class.
        /// </summary>
        public TemplatesCreateTemplateNoProjectResponse()
        {
        }
    }
}