//HintName: G.Models.AnnotationQueueCreateReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a new annotation queue.
    /// </summary>
    public sealed partial class AnnotationQueueCreateReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorer_refs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ScorerRefs { get; set; } = default!;

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueCreateReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="scorerRefs"></param>
        /// <param name="description"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        public AnnotationQueueCreateReq(
            string projectId,
            string name,
            global::System.Collections.Generic.IList<string> scorerRefs,
            string? description,
            string? wbUserId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ScorerRefs = scorerRefs ?? throw new global::System.ArgumentNullException(nameof(scorerRefs));
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueCreateReq" /> class.
        /// </summary>
        public AnnotationQueueCreateReq()
        {
        }
    }
}