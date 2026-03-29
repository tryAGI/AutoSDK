//HintName: G.Models.SuccessTaskData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SuccessTaskData
    {
        /// <summary>
        /// used for getTask
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessTaskData" /> class.
        /// </summary>
        /// <param name="taskId">
        /// used for getTask
        /// </param>
        public SuccessTaskData(
            string taskId)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessTaskData" /> class.
        /// </summary>
        public SuccessTaskData()
        {
        }
    }
}