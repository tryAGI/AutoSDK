//HintName: G.Models.OpenDuplicateDraftEntityData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenDuplicateDraftEntityData
    {
        /// <summary>
        /// 直接任务完成的会返回复制后实体ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copied_entity_id")]
        public string? CopiedEntityId { get; set; }

        /// <summary>
        /// 需要异步执行的会返回TaskID，用户轮训taskInfo接口查询
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenDuplicateDraftEntityData" /> class.
        /// </summary>
        /// <param name="copiedEntityId">
        /// 直接任务完成的会返回复制后实体ID
        /// </param>
        /// <param name="taskId">
        /// 需要异步执行的会返回TaskID，用户轮训taskInfo接口查询
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenDuplicateDraftEntityData(
            string? copiedEntityId,
            string? taskId)
        {
            this.CopiedEntityId = copiedEntityId;
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenDuplicateDraftEntityData" /> class.
        /// </summary>
        public OpenDuplicateDraftEntityData()
        {
        }
    }
}