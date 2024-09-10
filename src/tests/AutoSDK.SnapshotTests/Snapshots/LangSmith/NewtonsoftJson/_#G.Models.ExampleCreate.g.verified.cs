//HintName: G.Models.ExampleCreate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Create class for Example.
    /// </summary>
    public sealed partial class ExampleCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::G.AnyOf<global::G.ExampleCreateOutputs, object>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_run_id")]
        public global::G.AnyOf<global::System.Guid?, object>? SourceRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.AnyOf<global::G.ExampleCreateMetadata, object>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::G.AnyOf<global::G.ExampleCreateInputs, object>? Inputs { get; set; }

        /// <summary>
        /// Default Value: base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("split")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? Split { get; set; } = "base";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.AnyOf<global::System.Guid?, object>? Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_source_run_io")]
        public bool UseSourceRunIo { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}