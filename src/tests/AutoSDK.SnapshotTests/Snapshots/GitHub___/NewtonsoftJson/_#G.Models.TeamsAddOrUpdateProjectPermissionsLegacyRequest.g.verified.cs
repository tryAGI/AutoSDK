//HintName: G.Models.TeamsAddOrUpdateProjectPermissionsLegacyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsAddOrUpdateProjectPermissionsLegacyRequest
    {
        /// <summary>
        /// The permission to grant to the team for this project. Default: the team's `permission` attribute will be used to determine what permission to grant the team on this project. Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateProjectPermissionsLegacyRequest" /> class.
        /// </summary>
        /// <param name="permission">
        /// The permission to grant to the team for this project. Default: the team's `permission` attribute will be used to determine what permission to grant the team on this project. Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."
        /// </param>
        public TeamsAddOrUpdateProjectPermissionsLegacyRequest(
            global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission? permission)
        {
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateProjectPermissionsLegacyRequest" /> class.
        /// </summary>
        public TeamsAddOrUpdateProjectPermissionsLegacyRequest()
        {
        }
    }
}