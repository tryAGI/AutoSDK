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
        [global::Newtonsoft.Json.JsonProperty("external_project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalProjectId { get; set; } = default!;

        /// <summary>
        /// Internal project ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("internal_project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InternalProjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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