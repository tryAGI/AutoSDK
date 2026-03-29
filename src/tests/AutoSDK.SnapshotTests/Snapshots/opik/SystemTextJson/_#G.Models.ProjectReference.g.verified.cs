//HintName: G.Models.ProjectReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project reference with ID and name<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class ProjectReference
    {
        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectReference" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Project ID
        /// </param>
        /// <param name="projectName">
        /// Project name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectReference(
            global::System.Guid projectId,
            string projectName)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectReference" /> class.
        /// </summary>
        public ProjectReference()
        {
        }
    }
}