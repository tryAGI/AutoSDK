//HintName: G.Models.ObjTagsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for adding/removing tags (object_id and digest come from path).
    /// </summary>
    public sealed partial class ObjTagsBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjTagsBody" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tags"></param>
        public ObjTagsBody(
            string projectId,
            global::System.Collections.Generic.IList<string> tags)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjTagsBody" /> class.
        /// </summary>
        public ObjTagsBody()
        {
        }
    }
}