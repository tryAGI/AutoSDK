//HintName: G.Models.TemplatesCreateTemplateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesCreateTemplateResponse
    {
        /// <summary>
        /// The exact name of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectSlug { get; set; }

        /// <summary>
        /// The latest version of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The full name of the template, including version and project slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_deployment_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateDeploymentSlug { get; set; }

        /// <summary>
        /// When the template was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateResponse" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesCreateTemplateResponse(
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
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateResponse" /> class.
        /// </summary>
        public TemplatesCreateTemplateResponse()
        {
        }
    }
}