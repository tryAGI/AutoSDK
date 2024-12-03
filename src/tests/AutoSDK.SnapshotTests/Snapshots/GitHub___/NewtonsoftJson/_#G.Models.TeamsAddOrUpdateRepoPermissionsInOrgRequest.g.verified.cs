//HintName: G.Models.TeamsAddOrUpdateRepoPermissionsInOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsAddOrUpdateRepoPermissionsInOrgRequest
    {
        /// <summary>
        /// The permission to grant the team on this repository. We accept the following permissions to be set: `pull`, `triage`, `push`, `maintain`, `admin` and you can also specify a custom repository role name, if the owning organization has defined any. If no permission is specified, the team's `permission` attribute will be used to determine what permission to grant the team on this repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public string? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateRepoPermissionsInOrgRequest" /> class.
        /// </summary>
        /// <param name="permission">
        /// The permission to grant the team on this repository. We accept the following permissions to be set: `pull`, `triage`, `push`, `maintain`, `admin` and you can also specify a custom repository role name, if the owning organization has defined any. If no permission is specified, the team's `permission` attribute will be used to determine what permission to grant the team on this repository.
        /// </param>
        public TeamsAddOrUpdateRepoPermissionsInOrgRequest(
            string? permission)
        {
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateRepoPermissionsInOrgRequest" /> class.
        /// </summary>
        public TeamsAddOrUpdateRepoPermissionsInOrgRequest()
        {
        }
    }
}