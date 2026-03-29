//HintName: G.Models.WorkspaceMetricsSummaryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMetricsSummaryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.Result>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMetricsSummaryResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        public WorkspaceMetricsSummaryResponse(
            global::System.Collections.Generic.IList<global::G.Result>? results)
        {
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMetricsSummaryResponse" /> class.
        /// </summary>
        public WorkspaceMetricsSummaryResponse()
        {
        }
    }
}