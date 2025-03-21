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
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// An array of projects to which membership is granted at the same time the org invite is accepted. If omitted, the user will be invited to the default project for compatibility with legacy behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::G.InviteRequestProject>? Projects { get; set; }

        /// <summary>
        /// `owner` or `reader`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InviteRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InviteRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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