//HintName: G.Models.PublicExampleWithRuns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for an example in a publicly-shared dataset with list of runs.
    /// </summary>
    public sealed partial class PublicExampleWithRuns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_run_id")]
        public global::System.Guid? SourceRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment_urls")]
        public object? AttachmentUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RunPublicDatasetSchema> Runs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicExampleWithRuns" /> class.
        /// </summary>
        /// <param name="outputs"></param>
        /// <param name="datasetId"></param>
        /// <param name="sourceRunId"></param>
        /// <param name="metadata"></param>
        /// <param name="inputs"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="attachmentUrls"></param>
        /// <param name="runs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicExampleWithRuns(
            global::System.Guid datasetId,
            object inputs,
            global::System.Guid id,
            string name,
            global::System.Collections.Generic.IList<global::G.RunPublicDatasetSchema> runs,
            object? outputs,
            global::System.Guid? sourceRunId,
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? modifiedAt,
            object? attachmentUrls)
        {
            this.DatasetId = datasetId;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
            this.Outputs = outputs;
            this.SourceRunId = sourceRunId;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.AttachmentUrls = attachmentUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicExampleWithRuns" /> class.
        /// </summary>
        public PublicExampleWithRuns()
        {
        }
    }
}