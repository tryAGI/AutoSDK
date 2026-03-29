//HintName: G.Models.WorkspaceMemberBulkAssignRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMemberBulkAssignRequest
    {
        /// <summary>
        /// Apply to all workspace members
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("all", Required = global::Newtonsoft.Json.Required.Always)]
        public bool All { get; set; } = default!;

        /// <summary>
        /// Excluded user IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded")]
        public global::System.Collections.Generic.IList<int>? Excluded { get; set; }

        /// <summary>
        /// Included user IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("included")]
        public global::System.Collections.Generic.IList<int>? Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberBulkAssignRequest" /> class.
        /// </summary>
        /// <param name="all">
        /// Apply to all workspace members
        /// </param>
        /// <param name="excluded">
        /// Excluded user IDs
        /// </param>
        /// <param name="included">
        /// Included user IDs
        /// </param>
        public WorkspaceMemberBulkAssignRequest(
            bool all,
            global::System.Collections.Generic.IList<int>? excluded,
            global::System.Collections.Generic.IList<int>? included)
        {
            this.All = all;
            this.Excluded = excluded;
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMemberBulkAssignRequest" /> class.
        /// </summary>
        public WorkspaceMemberBulkAssignRequest()
        {
        }
    }
}