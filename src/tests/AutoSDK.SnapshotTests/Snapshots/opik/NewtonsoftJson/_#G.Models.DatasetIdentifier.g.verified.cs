//HintName: G.Models.DatasetIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetIdentifier" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="projectName"></param>
        public DatasetIdentifier(
            string datasetName,
            string? projectName)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.ProjectName = projectName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetIdentifier" /> class.
        /// </summary>
        public DatasetIdentifier()
        {
        }
    }
}