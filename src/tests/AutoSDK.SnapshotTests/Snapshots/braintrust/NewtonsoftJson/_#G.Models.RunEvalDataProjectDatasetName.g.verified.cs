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
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_internal_btql")]
        public global::System.Collections.Generic.Dictionary<string, object?>? InternalBtql { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataProjectDatasetName" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="datasetName"></param>
        /// <param name="internalBtql"></param>
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