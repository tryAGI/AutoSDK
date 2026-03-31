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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// The slug of the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The version of the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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