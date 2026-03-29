//HintName: G.Models.BlueprintRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlueprintRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Project description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Labeling configuration in XML format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label_config")]
        public string? LabelConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_ids")]
        public global::System.Collections.Generic.IList<int>? TaskIds { get; set; }

        /// <summary>
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintRequest" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="createdBy"></param>
        /// <param name="description">
        /// Project description
        /// </param>
        /// <param name="labelConfig">
        /// Labeling configuration in XML format
        /// </param>
        /// <param name="taskIds">
        /// Included only in requests
        /// </param>
        /// <param name="title">
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </param>
        public BlueprintRequest(
            int project,
            int? createdBy,
            string? description,
            string? labelConfig,
            global::System.Collections.Generic.IList<int>? taskIds,
            string? title)
        {
            this.CreatedBy = createdBy;
            this.Description = description;
            this.LabelConfig = labelConfig;
            this.Project = project;
            this.TaskIds = taskIds;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintRequest" /> class.
        /// </summary>
        public BlueprintRequest()
        {
        }
    }
}