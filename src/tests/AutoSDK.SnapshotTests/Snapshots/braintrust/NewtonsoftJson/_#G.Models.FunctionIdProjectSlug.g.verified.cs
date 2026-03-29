//HintName: G.Models.FunctionIdProjectSlug.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project name and slug
    /// </summary>
    public sealed partial class FunctionIdProjectSlug
    {
        /// <summary>
        /// The name of the project containing the function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// The slug of the function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// The version of the function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdProjectSlug" /> class.
        /// </summary>
        /// <param name="projectName">
        /// The name of the project containing the function
        /// </param>
        /// <param name="slug">
        /// The slug of the function
        /// </param>
        /// <param name="version">
        /// The version of the function
        /// </param>
        public FunctionIdProjectSlug(
            string projectName,
            string slug,
            string? version)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdProjectSlug" /> class.
        /// </summary>
        public FunctionIdProjectSlug()
        {
        }
    }
}