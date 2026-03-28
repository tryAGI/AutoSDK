//HintName: G.Models.ExampleWithRunsCH.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example schema with list of runs.
    /// </summary>
    public sealed partial class ExampleWithRunsCH
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_run_id")]
        public global::System.Guid? SourceRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attachment_urls")]
        public object? AttachmentUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunSchemaComparisonView> Runs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleWithRunsCH" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="runs"></param>
        /// <param name="outputs"></param>
        /// <param name="sourceRunId"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="attachmentUrls"></param>
        public ExampleWithRunsCH(
            global::System.Guid datasetId,
            object inputs,
            global::System.Guid id,
            string name,
            global::System.Collections.Generic.IList<global::G.RunSchemaComparisonView> runs,
            object? outputs,
            global::System.Guid? sourceRunId,
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? modifiedAt,
            object? attachmentUrls)
        {
            this.Outputs = outputs;
            this.DatasetId = datasetId;
            this.SourceRunId = sourceRunId;
            this.Metadata = metadata;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ModifiedAt = modifiedAt;
            this.AttachmentUrls = attachmentUrls;
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleWithRunsCH" /> class.
        /// </summary>
        public ExampleWithRunsCH()
        {
        }
    }
}