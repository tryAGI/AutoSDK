//HintName: G.Models.TeamRoleAssignmentPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamRoleAssignmentPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Pull { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triage", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Triage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("push", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Push { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintain", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Maintain { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("admin", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Admin { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRoleAssignmentPermissions" /> class.
        /// </summary>
        /// <param name="pull"></param>
        /// <param name="triage"></param>
        /// <param name="push"></param>
        /// <param name="maintain"></param>
        /// <param name="admin"></param>
        public TeamRoleAssignmentPermissions(
            bool pull,
            bool triage,
            bool push,
            bool maintain,
            bool admin)
        {
            this.Pull = pull;
            this.Triage = triage;
            this.Push = push;
            this.Maintain = maintain;
            this.Admin = admin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRoleAssignmentPermissions" /> class.
        /// </summary>
        public TeamRoleAssignmentPermissions()
        {
        }
    }
}