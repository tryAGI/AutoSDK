//HintName: G.Models.ThreadsQueryFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsQueryFilter
    {
        /// <summary>
        /// Only include threads with start_time after this timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_datetime")]
        public global::System.DateTime? AfterDatetime { get; set; }

        /// <summary>
        /// Only include threads with last_updated before this timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_datetime")]
        public global::System.DateTime? BeforeDatetime { get; set; }

        /// <summary>
        /// Only include threads with thread_ids in this list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_ids")]
        public global::System.Collections.Generic.IList<string>? ThreadIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryFilter" /> class.
        /// </summary>
        /// <param name="afterDatetime">
        /// Only include threads with start_time after this timestamp
        /// </param>
        /// <param name="beforeDatetime">
        /// Only include threads with last_updated before this timestamp
        /// </param>
        /// <param name="threadIds">
        /// Only include threads with thread_ids in this list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQueryFilter(
            global::System.DateTime? afterDatetime,
            global::System.DateTime? beforeDatetime,
            global::System.Collections.Generic.IList<string>? threadIds)
        {
            this.AfterDatetime = afterDatetime;
            this.BeforeDatetime = beforeDatetime;
            this.ThreadIds = threadIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryFilter" /> class.
        /// </summary>
        public ThreadsQueryFilter()
        {
        }
    }
}