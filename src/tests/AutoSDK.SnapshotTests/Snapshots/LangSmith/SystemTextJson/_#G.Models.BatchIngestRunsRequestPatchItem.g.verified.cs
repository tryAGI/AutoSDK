//HintName: G.Models.BatchIngestRunsRequestPatchItem.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchIngestRunsRequestPatchItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dotted_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DottedOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        public global::System.Guid? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, double?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, double?> EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_attachments")]
        public object? InputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_attachments")]
        public object? OutputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchIngestRunsRequestPatchItem" /> class.
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
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BatchIngestRunsRequestPatchItem(
            global::System.Guid traceId,
            string dottedOrder,
            global::G.OneOf<string, double?> endTime,
            global::System.Guid id,
            global::System.Guid? parentRunId,
            string? error,
            object? inputs,
            object? outputs,
            global::System.Collections.Generic.IList<object>? events,
            global::System.Collections.Generic.IList<string>? tags,
            object? extra,
            object? inputAttachments,
            object? outputAttachments)
        {
            this.TraceId = traceId;
            this.DottedOrder = dottedOrder ?? throw new global::System.ArgumentNullException(nameof(dottedOrder));
            this.EndTime = endTime;
            this.Id = id;
            this.ParentRunId = parentRunId;
            this.Error = error;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.Events = events;
            this.Tags = tags;
            this.Extra = extra;
            this.InputAttachments = inputAttachments;
            this.OutputAttachments = outputAttachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchIngestRunsRequestPatchItem" /> class.
        /// </summary>
        public BatchIngestRunsRequestPatchItem()
        {
        }
    }
}