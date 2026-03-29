//HintName: G.Models.WorkflowEntityMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowEntityMetadata
    {
        /// <summary>
        /// The latest version number of the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_version_number")]
        public int? LatestVersionNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEntityMetadata" /> class.
        /// </summary>
        /// <param name="latestVersionNumber">
        /// The latest version number of the workflow.
        /// </param>
        public WorkflowEntityMetadata(
            int? latestVersionNumber)
        {
            this.LatestVersionNumber = latestVersionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEntityMetadata" /> class.
        /// </summary>
        public WorkflowEntityMetadata()
        {
        }
    }
}