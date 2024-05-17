//HintName: G.Models.RunCreateSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create class for a Run object.
    /// </summary>
    public sealed partial class RunCreateSchema
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
        public RunCreateSchemaInputs? Inputs { get; set; }

        /// <summary>
        /// Enum for run types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_type", Required = global::Newtonsoft.Json.Required.Always)]
        public RunCreateSchemaRunType RunType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra")]
        public RunCreateSchemaExtra? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// <br/>Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_order")]
        public int ExecutionOrder { get; set; } = 1;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serialized")]
        public RunCreateSchemaSerialized? Serialized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public RunCreateSchemaOutputs? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_run_id")]
        public string? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest_id")]
        public string? ManifestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<RunCreateSchemaEvents?>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string?>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_example_id")]
        public string? ReferenceExampleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}