//HintName: G.Models.ProjectMemberBulkAssignRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectMemberBulkAssignRequest
    {
        /// <summary>
        /// Apply to all project members
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
        /// Member roles
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roles")]
        public global::System.Collections.Generic.IList<global::G.ProjectMemberBulkAssignRolesRequest>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMemberBulkAssignRequest" /> class.
        /// </summary>
        /// <param name="all">
        /// Apply to all project members
        /// </param>
        /// <param name="excluded">
        /// Excluded user IDs
        /// </param>
        /// <param name="included">
        /// Included user IDs
        /// </param>
        /// <param name="roles">
        /// Member roles
        /// </param>
        public ProjectMemberBulkAssignRequest(
            bool all,
            global::System.Collections.Generic.IList<int>? excluded,
            global::System.Collections.Generic.IList<int>? included,
            global::System.Collections.Generic.IList<global::G.ProjectMemberBulkAssignRolesRequest>? roles)
        {
            this.All = all;
            this.Excluded = excluded;
            this.Included = included;
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMemberBulkAssignRequest" /> class.
        /// </summary>
        public ProjectMemberBulkAssignRequest()
        {
        }
    }
}