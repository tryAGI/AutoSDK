//HintName: G.Models.ExportAnnotationQueueRunsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Export annotation queue runs request schema.
    /// </summary>
    public sealed partial class ExportAnnotationQueueRunsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportAnnotationQueueRunsRequest" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportAnnotationQueueRunsRequest(
            global::System.DateTime? startTime,
            global::System.DateTime? endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportAnnotationQueueRunsRequest" /> class.
        /// </summary>
        public ExportAnnotationQueueRunsRequest()
        {
        }
    }
}