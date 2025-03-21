//HintName: G.Models.InviteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteRequest
    {
        /// <summary>
        /// Send an email to this address
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// An array of projects to which membership is granted at the same time the org invite is accepted. If omitted, the user will be invited to the default project for compatibility with legacy behavior.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects")]
        public global::System.Collections.Generic.IList<global::G.InviteRequestProject>? Projects { get; set; }

        /// <summary>
        /// `owner` or `reader`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InviteRequestRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// Send an email to this address
        /// </param>
        /// <param name="projects">
        /// An array of projects to which membership is granted at the same time the org invite is accepted. If omitted, the user will be invited to the default project for compatibility with legacy behavior.
        /// </param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        public InviteRequest(
            string email,
            global::G.InviteRequestRole role,
            global::System.Collections.Generic.IList<global::G.InviteRequestProject>? projects)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequest" /> class.
        /// </summary>
        public InviteRequest()
        {
        }
    }
}