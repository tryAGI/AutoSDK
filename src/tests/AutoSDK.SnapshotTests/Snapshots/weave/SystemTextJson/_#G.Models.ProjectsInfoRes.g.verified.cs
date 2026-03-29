//HintName: G.Models.ProjectsInfoRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsInfoRes
    {
        /// <summary>
        /// External project ID in 'entity/project' format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalProjectId { get; set; }

        /// <summary>
        /// Internal project ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InternalProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsInfoRes" /> class.
        /// </summary>
        /// <param name="externalProjectId">
        /// External project ID in 'entity/project' format.
        /// </param>
        /// <param name="internalProjectId">
        /// Internal project ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsInfoRes(
            string externalProjectId,
            string internalProjectId)
        {
            this.ExternalProjectId = externalProjectId ?? throw new global::System.ArgumentNullException(nameof(externalProjectId));
            this.InternalProjectId = internalProjectId ?? throw new global::System.ArgumentNullException(nameof(internalProjectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsInfoRes" /> class.
        /// </summary>
        public ProjectsInfoRes()
        {
        }
    }
}