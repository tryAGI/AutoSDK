//HintName: G.Models.AnnotationQueueBulkDeleteRunsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationQueueBulkDeleteRunsRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_all")]
        public bool? DeleteAll { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExcludeRunIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueBulkDeleteRunsRequest" /> class.
        /// </summary>
        /// <param name="deleteAll">
        /// Default Value: false
        /// </param>
        /// <param name="runIds"></param>
        /// <param name="excludeRunIds"></param>
        public AnnotationQueueBulkDeleteRunsRequest(
            bool? deleteAll,
            global::System.Collections.Generic.IList<global::System.Guid>? runIds,
            global::System.Collections.Generic.IList<global::System.Guid>? excludeRunIds)
        {
            this.DeleteAll = deleteAll;
            this.RunIds = runIds;
            this.ExcludeRunIds = excludeRunIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueBulkDeleteRunsRequest" /> class.
        /// </summary>
        public AnnotationQueueBulkDeleteRunsRequest()
        {
        }
    }
}