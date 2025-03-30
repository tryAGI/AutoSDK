//HintName: G.Models.ExampleValidationResult.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Validation result for Example, combining fields from Create/Base/Update schemas.
    /// </summary>
    public sealed partial class ExampleValidationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_run_id")]
        public global::System.Guid? SourceRunId { get; set; }

        /// <summary>
        /// Default Value: base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("split")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? Split { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_source_run_io")]
        public bool? UseSourceRunIo { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleValidationResult" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="createdAt"></param>
        /// <param name="metadata"></param>
        /// <param name="sourceRunId"></param>
        /// <param name="split">
        /// Default Value: base
        /// </param>
        /// <param name="id"></param>
        /// <param name="useSourceRunIo">
        /// Default Value: false
        /// </param>
        /// <param name="overwrite">
        /// Default Value: false
        /// </param>
        public ExampleValidationResult(
            global::System.Guid? datasetId,
            object? inputs,
            object? outputs,
            global::System.DateTime? createdAt,
            object? metadata,
            global::System.Guid? sourceRunId,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? split,
            global::System.Guid? id,
            bool? useSourceRunIo,
            bool? overwrite)
        {
            this.DatasetId = datasetId;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.CreatedAt = createdAt;
            this.Metadata = metadata;
            this.SourceRunId = sourceRunId;
            this.Split = split;
            this.Id = id;
            this.UseSourceRunIo = useSourceRunIo;
            this.Overwrite = overwrite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleValidationResult" /> class.
        /// </summary>
        public ExampleValidationResult()
        {
        }
    }
}