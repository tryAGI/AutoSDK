//HintName: G.Models.ExampleUpdateWithID.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Bulk update class for Example (includes example id).
    /// </summary>
    public sealed partial class ExampleUpdateWithID
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
        [global::Newtonsoft.Json.JsonProperty("attachments_operations")]
        public global::G.AttachmentsOperations? AttachmentsOperations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("split")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? Split { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleUpdateWithID" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="attachmentsOperations"></param>
        /// <param name="metadata"></param>
        /// <param name="split"></param>
        /// <param name="overwrite">
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        public ExampleUpdateWithID(
            global::System.Guid id,
            global::System.Guid? datasetId,
            object? inputs,
            object? outputs,
            global::G.AttachmentsOperations? attachmentsOperations,
            object? metadata,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? split,
            bool? overwrite)
        {
            this.Id = id;
            this.DatasetId = datasetId;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.AttachmentsOperations = attachmentsOperations;
            this.Metadata = metadata;
            this.Split = split;
            this.Overwrite = overwrite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleUpdateWithID" /> class.
        /// </summary>
        public ExampleUpdateWithID()
        {
        }
    }
}