//HintName: G.Models.CreateAdminWorkspacesUsersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"users":[{"id":"419641fb-1458-47d6-94d0-e308159b3ec2","role":"member"},{"id":"419641fb-1458-47d6-94d0-e308159b3ec3","role":"member"}]}
    /// </summary>
    public sealed partial class CreateAdminWorkspacesUsersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users")]
        public global::System.Collections.Generic.IList<global::G.CreateAdminWorkspacesUsersRequestUser>? Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminWorkspacesUsersRequest" /> class.
        /// </summary>
        /// <param name="users"></param>
        public CreateAdminWorkspacesUsersRequest(
            global::System.Collections.Generic.IList<global::G.CreateAdminWorkspacesUsersRequestUser>? users)
        {
            this.Users = users;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminWorkspacesUsersRequest" /> class.
        /// </summary>
        public CreateAdminWorkspacesUsersRequest()
        {
        }
    }
}