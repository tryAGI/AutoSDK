//HintName: G.Models.PatchWorkflow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for partially updating a workflow.
    /// </summary>
    public sealed partial class PatchWorkflow
    {
        /// <summary>
        /// The version number to base changes on. Defaults to the latest version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_version")]
        public int? BaseVersion { get; set; }

        /// <summary>
        /// A message describing the changes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Node updates keyed by node name. Use null to remove a node.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes")]
        public object? Nodes { get; set; }

        /// <summary>
        /// If provided, replaces the input variables entirely.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_input_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequiredInputVariables { get; set; }

        /// <summary>
        /// If provided, replaces edges entirely.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges")]
        public global::System.Collections.Generic.IList<global::G.Edge>? Edges { get; set; }

        /// <summary>
        /// Labels to attach to the new version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWorkflow" /> class.
        /// </summary>
        /// <param name="baseVersion">
        /// The version number to base changes on. Defaults to the latest version.
        /// </param>
        /// <param name="commitMessage">
        /// A message describing the changes.
        /// </param>
        /// <param name="nodes">
        /// Node updates keyed by node name. Use null to remove a node.
        /// </param>
        /// <param name="requiredInputVariables">
        /// If provided, replaces the input variables entirely.
        /// </param>
        /// <param name="edges">
        /// If provided, replaces edges entirely.
        /// </param>
        /// <param name="releaseLabels">
        /// Labels to attach to the new version.
        /// </param>
        public PatchWorkflow(
            int? baseVersion,
            string? commitMessage,
            object? nodes,
            global::System.Collections.Generic.Dictionary<string, string>? requiredInputVariables,
            global::System.Collections.Generic.IList<global::G.Edge>? edges,
            global::System.Collections.Generic.IList<string>? releaseLabels)
        {
            this.BaseVersion = baseVersion;
            this.CommitMessage = commitMessage;
            this.Nodes = nodes;
            this.RequiredInputVariables = requiredInputVariables;
            this.Edges = edges;
            this.ReleaseLabels = releaseLabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWorkflow" /> class.
        /// </summary>
        public PatchWorkflow()
        {
        }
    }
}