//HintName: G.Models.PutAdminUsersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"role":"admin"}
    /// </summary>
    public sealed partial class PutAdminUsersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.PutAdminUsersRequestRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminUsersRequest" /> class.
        /// </summary>
        /// <param name="role"></param>
        public PutAdminUsersRequest(
            global::G.PutAdminUsersRequestRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminUsersRequest" /> class.
        /// </summary>
        public PutAdminUsersRequest()
        {
        }
    }
}