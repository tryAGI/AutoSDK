//HintName: G.Models.CrossObjectInsertRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrossObjectInsertRequest
    {
        /// <summary>
        /// A mapping from experiment id to a set of log events and feedback items to insert
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment")]
        public global::System.Collections.Generic.Dictionary<string, global::G.CrossObjectInsertRequestExperiment2>? Experiment { get; set; }

        /// <summary>
        /// A mapping from dataset id to a set of log events and feedback items to insert
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset")]
        public global::System.Collections.Generic.Dictionary<string, global::G.CrossObjectInsertRequestDataset2>? Dataset { get; set; }

        /// <summary>
        /// A mapping from project id to a set of log events and feedback items to insert
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_logs")]
        public global::System.Collections.Generic.Dictionary<string, global::G.CrossObjectInsertRequestProjectLogs2>? ProjectLogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertRequest" /> class.
        /// </summary>
        /// <param name="experiment">
        /// A mapping from experiment id to a set of log events and feedback items to insert
        /// </param>
        /// <param name="dataset">
        /// A mapping from dataset id to a set of log events and feedback items to insert
        /// </param>
        /// <param name="projectLogs">
        /// A mapping from project id to a set of log events and feedback items to insert
        /// </param>
        public CrossObjectInsertRequest(
            global::System.Collections.Generic.Dictionary<string, global::G.CrossObjectInsertRequestExperiment2>? experiment,
            global::System.Collections.Generic.Dictionary<string, global::G.CrossObjectInsertRequestDataset2>? dataset,
            global::System.Collections.Generic.Dictionary<string, global::G.CrossObjectInsertRequestProjectLogs2>? projectLogs)
        {
            this.Experiment = experiment;
            this.Dataset = dataset;
            this.ProjectLogs = projectLogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossObjectInsertRequest" /> class.
        /// </summary>
        public CrossObjectInsertRequest()
        {
        }
    }
}