//HintName: G.Models.CreateRunRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRunRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::G.OneOf<global::G.CreateRunRequestInputs, object>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateRunRequestRunType RunType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::G.OneOf<string, double?, object>? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::G.OneOf<string, double?, object>? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra")]
        public global::G.OneOf<global::G.CreateRunRequestExtra, object>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.OneOf<string, object>? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serialized")]
        public global::G.OneOf<global::G.CreateRunRequestSerialized, object>? Serialized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::G.OneOf<global::G.CreateRunRequestOutputs, object>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_run_id")]
        public global::G.OneOf<global::System.Guid?, object>? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::G.OneOf<global::System.Collections.Generic.IList<global::G.CreateRunRequestEventsVariant1Item>, object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::G.OneOf<global::System.Collections.Generic.IList<string>, object>? Tags { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.OneOf<global::System.Guid?, object>? Id { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_example_id")]
        public global::G.OneOf<global::System.Guid?, object>? ReferenceExampleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_attachments")]
        public global::G.OneOf<global::G.CreateRunRequestInputAttachments, object>? InputAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_attachments")]
        public global::G.OneOf<global::G.CreateRunRequestOutputAttachments, object>? OutputAttachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}