//HintName: G.Models.RunEvalDataProjectDatasetName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project and dataset name
    /// </summary>
    public sealed partial class RunEvalDataProjectDatasetName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_internal_btql")]
        public global::System.Collections.Generic.Dictionary<string, object?>? InternalBtql { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataProjectDatasetName" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="datasetName"></param>
        /// <param name="internalBtql"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunEvalDataProjectDatasetName(
            string projectName,
            string datasetName,
            global::System.Collections.Generic.Dictionary<string, object?>? internalBtql)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.InternalBtql = internalBtql;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataProjectDatasetName" /> class.
        /// </summary>
        public RunEvalDataProjectDatasetName()
        {
        }
    }
}