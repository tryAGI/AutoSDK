//HintName: G.Models.TraceThreadIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceThreadIdentifier
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
        [global::Newtonsoft.Json.JsonProperty("thread_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadIdentifier" /> class.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="truncate"></param>
        public TraceThreadIdentifier(
            string threadId,
            string? projectName,
            global::System.Guid? projectId,
            bool? truncate)
        {
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadIdentifier" /> class.
        /// </summary>
        public TraceThreadIdentifier()
        {
        }
    }
}