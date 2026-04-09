//HintName: G.Models.PutAdminWorkspacesUsersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"role":"member"}
    /// </summary>
    public sealed partial class PutAdminWorkspacesUsersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PutAdminWorkspacesUsersRequestRoleJsonConverter))]
        public global::G.PutAdminWorkspacesUsersRequestRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminWorkspacesUsersRequest" /> class.
        /// </summary>
        /// <param name="role"></param>
        public PutAdminWorkspacesUsersRequest(
            global::G.PutAdminWorkspacesUsersRequestRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminWorkspacesUsersRequest" /> class.
        /// </summary>
        public PutAdminWorkspacesUsersRequest()
        {
        }
    }
}