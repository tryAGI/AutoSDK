//HintName: G.Models.ExampleUpdate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Update class for Example.
    /// </summary>
    public sealed partial class ExampleUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments_operations")]
        public global::G.AttachmentsOperations? AttachmentsOperations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? Split { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleUpdate" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExampleUpdate(
            global::System.Guid? datasetId,
            object? inputs,
            object? outputs,
            global::G.AttachmentsOperations? attachmentsOperations,
            object? metadata,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? split,
            bool? overwrite)
        {
            this.DatasetId = datasetId;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.AttachmentsOperations = attachmentsOperations;
            this.Metadata = metadata;
            this.Split = split;
            this.Overwrite = overwrite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleUpdate" /> class.
        /// </summary>
        public ExampleUpdate()
        {
        }
    }
}