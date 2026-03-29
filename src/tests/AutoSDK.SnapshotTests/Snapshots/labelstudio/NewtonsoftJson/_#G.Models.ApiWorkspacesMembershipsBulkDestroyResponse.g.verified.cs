//HintName: G.Models.ApiWorkspacesMembershipsBulkDestroyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiWorkspacesMembershipsBulkDestroyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unassignments")]
        public int? Unassignments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiWorkspacesMembershipsBulkDestroyResponse" /> class.
        /// </summary>
        /// <param name="unassignments"></param>
        public ApiWorkspacesMembershipsBulkDestroyResponse(
            int? unassignments)
        {
            this.Unassignments = unassignments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiWorkspacesMembershipsBulkDestroyResponse" /> class.
        /// </summary>
        public ApiWorkspacesMembershipsBulkDestroyResponse()
        {
        }
    }
}