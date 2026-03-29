//HintName: G.Models.AnnotationQueueUpdateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for updating an annotation queue (queue_id comes from path).<br/>
    /// All fields except project_id are optional - only provided fields will be updated.
    /// </summary>
    public sealed partial class AnnotationQueueUpdateBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorer_refs")]
        public global::System.Collections.Generic.IList<string>? ScorerRefs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueUpdateBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="scorerRefs"></param>
        public AnnotationQueueUpdateBody(
            string projectId,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? scorerRefs)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name;
            this.Description = description;
            this.ScorerRefs = scorerRefs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueUpdateBody" /> class.
        /// </summary>
        public AnnotationQueueUpdateBody()
        {
        }
    }
}