//HintName: G.Models.TaskInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskInfo
    {
        /// <summary>
        /// External task ID provided by the caller.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_task_id")]
        public string? ExternalTaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInfo" /> class.
        /// </summary>
        /// <param name="externalTaskId">
        /// External task ID provided by the caller.
        /// </param>
        public TaskInfo(
            string? externalTaskId)
        {
            this.ExternalTaskId = externalTaskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInfo" /> class.
        /// </summary>
        public TaskInfo()
        {
        }
    }
}