//HintName: G.Models.CreateInvite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"email":"test@john.doe","role":"admin","workspaces":[{"id":"ws-slug","role":"member"}]}
    /// </summary>
    public sealed partial class CreateInvite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaces", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WorkspaceInvite> Workspaces { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InviteRoleJsonConverter))]
        public global::G.InviteRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_api_key_details")]
        public global::G.CreateInviteWorkspaceApiKeyDetails? WorkspaceApiKeyDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvite" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="workspaces"></param>
        /// <param name="role"></param>
        /// <param name="workspaceApiKeyDetails"></param>
        public CreateInvite(
            string email,
            global::System.Collections.Generic.IList<global::G.WorkspaceInvite> workspaces,
            global::G.InviteRole role,
            global::G.CreateInviteWorkspaceApiKeyDetails? workspaceApiKeyDetails)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Workspaces = workspaces ?? throw new global::System.ArgumentNullException(nameof(workspaces));
            this.Role = role;
            this.WorkspaceApiKeyDetails = workspaceApiKeyDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvite" /> class.
        /// </summary>
        public CreateInvite()
        {
        }
    }
}