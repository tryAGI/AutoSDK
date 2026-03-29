//HintName: G.Models.CallsFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallsFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op_names")]
        public global::System.Collections.Generic.IList<string>? OpNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_refs")]
        public global::System.Collections.Generic.IList<string>? InputRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_refs")]
        public global::System.Collections.Generic.IList<string>? OutputRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_ids")]
        public global::System.Collections.Generic.IList<string>? ParentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_ids")]
        public global::System.Collections.Generic.IList<string>? TraceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_ids")]
        public global::System.Collections.Generic.IList<string>? CallIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_ids")]
        public global::System.Collections.Generic.IList<string>? ThreadIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_ids")]
        public global::System.Collections.Generic.IList<string>? TurnIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_roots_only")]
        public bool? TraceRootsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_ids")]
        public global::System.Collections.Generic.IList<string>? WbUserIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_run_ids")]
        public global::System.Collections.Generic.IList<string>? WbRunIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsFilter" /> class.
        /// </summary>
        /// <param name="opNames"></param>
        /// <param name="inputRefs"></param>
        /// <param name="outputRefs"></param>
        /// <param name="parentIds"></param>
        /// <param name="traceIds"></param>
        /// <param name="callIds"></param>
        /// <param name="threadIds"></param>
        /// <param name="turnIds"></param>
        /// <param name="traceRootsOnly"></param>
        /// <param name="wbUserIds"></param>
        /// <param name="wbRunIds"></param>
        public CallsFilter(
            global::System.Collections.Generic.IList<string>? opNames,
            global::System.Collections.Generic.IList<string>? inputRefs,
            global::System.Collections.Generic.IList<string>? outputRefs,
            global::System.Collections.Generic.IList<string>? parentIds,
            global::System.Collections.Generic.IList<string>? traceIds,
            global::System.Collections.Generic.IList<string>? callIds,
            global::System.Collections.Generic.IList<string>? threadIds,
            global::System.Collections.Generic.IList<string>? turnIds,
            bool? traceRootsOnly,
            global::System.Collections.Generic.IList<string>? wbUserIds,
            global::System.Collections.Generic.IList<string>? wbRunIds)
        {
            this.OpNames = opNames;
            this.InputRefs = inputRefs;
            this.OutputRefs = outputRefs;
            this.ParentIds = parentIds;
            this.TraceIds = traceIds;
            this.CallIds = callIds;
            this.ThreadIds = threadIds;
            this.TurnIds = turnIds;
            this.TraceRootsOnly = traceRootsOnly;
            this.WbUserIds = wbUserIds;
            this.WbRunIds = wbRunIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsFilter" /> class.
        /// </summary>
        public CallsFilter()
        {
        }
    }
}