//HintName: G.Models.RuleLogSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Run rules log schema.
    /// </summary>
    public sealed partial class RuleLogSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RuleId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_name")]
        public global::G.AnyOf<string, object>? RunName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_type")]
        public global::G.AnyOf<string, object>? RunType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_session_id")]
        public global::G.AnyOf<global::System.Guid?, object>? RunSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_to_annotation_queue")]
        public global::G.AnyOf<global::G.RuleLogActionResponse, object>? AddToAnnotationQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_to_dataset")]
        public global::G.AnyOf<global::G.RuleLogActionResponse, object>? AddToDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluators")]
        public global::G.AnyOf<global::G.RuleLogActionResponse, object>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alerts")]
        public global::G.AnyOf<global::G.RuleLogActionResponse, object>? Alerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhooks")]
        public global::G.AnyOf<global::G.RuleLogActionResponse, object>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}