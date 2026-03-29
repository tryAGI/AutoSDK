//HintName: G.Models.DeleteTraceThreads.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTraceThreads
    {
        /// <summary>
        /// If null, project_id must be provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// If null, project_name must be provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ThreadIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTraceThreads" /> class.
        /// </summary>
        /// <param name="threadIds"></param>
        /// <param name="projectName">
        /// If null, project_id must be provided
        /// </param>
        /// <param name="projectId">
        /// If null, project_name must be provided
        /// </param>
        public DeleteTraceThreads(
            global::System.Collections.Generic.IList<string> threadIds,
            string? projectName,
            global::System.Guid? projectId)
        {
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.ThreadIds = threadIds ?? throw new global::System.ArgumentNullException(nameof(threadIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTraceThreads" /> class.
        /// </summary>
        public DeleteTraceThreads()
        {
        }
    }
}