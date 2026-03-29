//HintName: G.Models.BatchDeleteByProject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchDeleteByProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> Ids { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteByProject" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="projectId"></param>
        public BatchDeleteByProject(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Guid? projectId)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteByProject" /> class.
        /// </summary>
        public BatchDeleteByProject()
        {
        }
    }
}