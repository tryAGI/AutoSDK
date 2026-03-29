//HintName: G.Models.TraceThreadBatchIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceThreadBatchIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_ids")]
        public global::System.Collections.Generic.IList<string>? ThreadIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadBatchIdentifier" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="threadId"></param>
        /// <param name="threadIds"></param>
        public TraceThreadBatchIdentifier(
            string? projectName,
            global::System.Guid? projectId,
            string? threadId,
            global::System.Collections.Generic.IList<string>? threadIds)
        {
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.ThreadId = threadId;
            this.ThreadIds = threadIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadBatchIdentifier" /> class.
        /// </summary>
        public TraceThreadBatchIdentifier()
        {
        }
    }
}