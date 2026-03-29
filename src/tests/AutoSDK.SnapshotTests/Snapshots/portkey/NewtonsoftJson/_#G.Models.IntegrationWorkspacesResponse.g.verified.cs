//HintName: G.Models.IntegrationWorkspacesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationWorkspacesResponse
    {
        /// <summary>
        /// Total number of workspaces
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaces")]
        public global::System.Collections.Generic.IList<global::G.IntegrationWorkspace>? Workspaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationWorkspacesResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of workspaces
        /// </param>
        /// <param name="workspaces"></param>
        public IntegrationWorkspacesResponse(
            int? total,
            global::System.Collections.Generic.IList<global::G.IntegrationWorkspace>? workspaces)
        {
            this.Total = total;
            this.Workspaces = workspaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationWorkspacesResponse" /> class.
        /// </summary>
        public IntegrationWorkspacesResponse()
        {
        }
    }
}