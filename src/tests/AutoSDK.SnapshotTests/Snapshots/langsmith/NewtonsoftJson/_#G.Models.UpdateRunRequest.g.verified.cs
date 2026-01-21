//HintName: G.Models.UpdateRunRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRunRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public global::G.OneOf<global::System.Guid?, object>? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dotted_order")]
        public global::G.OneOf<string, object>? DottedOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_run_id")]
        public global::G.OneOf<global::System.Guid?, object>? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::G.OneOf<string, double?, object>? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.OneOf<string, object>? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::G.OneOf<object, object>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::G.OneOf<object, object>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::G.OneOf<global::System.Collections.Generic.IList<object>, object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::G.OneOf<global::System.Collections.Generic.IList<string>, object>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra")]
        public global::G.OneOf<object, object>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_attachments")]
        public global::G.OneOf<object, object>? InputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_attachments")]
        public global::G.OneOf<object, object>? OutputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public global::G.OneOf<global::System.Guid?, object>? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_name")]
        public global::G.OneOf<string, object>? SessionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRunRequest" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="parentRunId"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="extra"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        public UpdateRunRequest(
            global::G.OneOf<global::System.Guid?, object>? traceId,
            global::G.OneOf<string, object>? dottedOrder,
            global::G.OneOf<global::System.Guid?, object>? parentRunId,
            global::G.OneOf<string, double?, object>? endTime,
            global::G.OneOf<string, object>? error,
            global::G.OneOf<object, object>? inputs,
            global::G.OneOf<object, object>? outputs,
            global::G.OneOf<global::System.Collections.Generic.IList<object>, object>? events,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, object>? tags,
            global::G.OneOf<object, object>? extra,
            global::G.OneOf<object, object>? inputAttachments,
            global::G.OneOf<object, object>? outputAttachments,
            global::G.OneOf<global::System.Guid?, object>? sessionId,
            global::G.OneOf<string, object>? sessionName)
        {
            this.TraceId = traceId;
            this.DottedOrder = dottedOrder;
            this.ParentRunId = parentRunId;
            this.EndTime = endTime;
            this.Error = error;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.Events = events;
            this.Tags = tags;
            this.Extra = extra;
            this.InputAttachments = inputAttachments;
            this.OutputAttachments = outputAttachments;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRunRequest" /> class.
        /// </summary>
        public UpdateRunRequest()
        {
        }
    }
}