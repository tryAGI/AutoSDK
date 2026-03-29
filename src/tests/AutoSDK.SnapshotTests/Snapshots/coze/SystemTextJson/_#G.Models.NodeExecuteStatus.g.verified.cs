//HintName: G.Models.NodeExecuteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeExecuteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_index")]
        public int? BatchIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_finish")]
        public bool? IsFinish { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop_index")]
        public int? LoopIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_execute_uuid")]
        public string? NodeExecuteUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_execute_id")]
        public string? SubExecuteId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecuteStatus" /> class.
        /// </summary>
        /// <param name="batchIndex"></param>
        /// <param name="isFinish"></param>
        /// <param name="loopIndex"></param>
        /// <param name="nodeExecuteUuid"></param>
        /// <param name="nodeId"></param>
        /// <param name="subExecuteId"></param>
        /// <param name="updateTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeExecuteStatus(
            int? batchIndex,
            bool? isFinish,
            int? loopIndex,
            string? nodeExecuteUuid,
            string? nodeId,
            string? subExecuteId,
            int? updateTime)
        {
            this.BatchIndex = batchIndex;
            this.IsFinish = isFinish;
            this.LoopIndex = loopIndex;
            this.NodeExecuteUuid = nodeExecuteUuid;
            this.NodeId = nodeId;
            this.SubExecuteId = subExecuteId;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecuteStatus" /> class.
        /// </summary>
        public NodeExecuteStatus()
        {
        }
    }
}