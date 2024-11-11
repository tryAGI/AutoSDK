//HintName: G.Models.BodyCloneDatasetApiV1DatasetsClonePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCloneDatasetApiV1DatasetsClonePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TargetDatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SourceDatasetId { get; set; } = default!;

        /// <summary>
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("as_of")]
        public object? AsOf { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCloneDatasetApiV1DatasetsClonePost" /> class.
        /// </summary>
        /// <param name="targetDatasetId"></param>
        /// <param name="sourceDatasetId"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </param>
        /// <param name="examples">
        /// Default Value: []
        /// </param>
        public BodyCloneDatasetApiV1DatasetsClonePost(
            global::System.Guid targetDatasetId,
            global::System.Guid sourceDatasetId,
            object? asOf,
            global::System.Collections.Generic.IList<global::System.Guid>? examples)
        {
            this.TargetDatasetId = targetDatasetId;
            this.SourceDatasetId = sourceDatasetId;
            this.AsOf = asOf;
            this.Examples = examples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCloneDatasetApiV1DatasetsClonePost" /> class.
        /// </summary>
        public BodyCloneDatasetApiV1DatasetsClonePost()
        {
        }
    }
}