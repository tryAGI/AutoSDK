//HintName: G.Models.WorkspaceMetricRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMetricRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime IntervalStart { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_end", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime IntervalEnd { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_before_end")]
        public bool? StartBeforeEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMetricRequest" /> class.
        /// </summary>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="projectIds"></param>
        /// <param name="name"></param>
        /// <param name="startBeforeEnd"></param>
        public WorkspaceMetricRequest(
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            string? name,
            bool? startBeforeEnd)
        {
            this.ProjectIds = projectIds;
            this.Name = name;
            this.IntervalStart = intervalStart;
            this.IntervalEnd = intervalEnd;
            this.StartBeforeEnd = startBeforeEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMetricRequest" /> class.
        /// </summary>
        public WorkspaceMetricRequest()
        {
        }
    }
}