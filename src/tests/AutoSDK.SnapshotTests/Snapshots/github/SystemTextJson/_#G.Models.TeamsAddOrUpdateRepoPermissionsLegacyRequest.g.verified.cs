//HintName: G.Models.TeamsAddOrUpdateRepoPermissionsLegacyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsAddOrUpdateRepoPermissionsLegacyRequest
    {
        /// <summary>
        /// The permission to grant the team on this repository. If no permission is specified, the team's `permission` attribute will be used to determine what permission to grant the team on this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TeamsAddOrUpdateRepoPermissionsLegacyRequestPermissionJsonConverter))]
        public global::G.TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateRepoPermissionsLegacyRequest" /> class.
        /// </summary>
        /// <param name="permission">
        /// The permission to grant the team on this repository. If no permission is specified, the team's `permission` attribute will be used to determine what permission to grant the team on this repository.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TeamsAddOrUpdateRepoPermissionsLegacyRequest(
            global::G.TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission? permission)
        {
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateRepoPermissionsLegacyRequest" /> class.
        /// </summary>
        public TeamsAddOrUpdateRepoPermissionsLegacyRequest()
        {
        }
    }
}