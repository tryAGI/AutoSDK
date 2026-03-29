//HintName: G.Models.SendInviteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendInviteRequest
    {
        /// <summary>
        /// Email addresses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Project IDs to grant access to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<int>? Projects { get; set; }

        /// <summary>
        /// Organization role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Role9e7EnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Role9e7Enum Role { get; set; }

        /// <summary>
        /// Workspace IDs to grant access to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        public global::System.Collections.Generic.IList<int>? Workspaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendInviteRequest" /> class.
        /// </summary>
        /// <param name="emails">
        /// Email addresses
        /// </param>
        /// <param name="role">
        /// Organization role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="projects">
        /// Project IDs to grant access to
        /// </param>
        /// <param name="workspaces">
        /// Workspace IDs to grant access to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendInviteRequest(
            global::System.Collections.Generic.IList<string> emails,
            global::G.Role9e7Enum role,
            global::System.Collections.Generic.IList<int>? projects,
            global::System.Collections.Generic.IList<int>? workspaces)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.Projects = projects;
            this.Role = role;
            this.Workspaces = workspaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendInviteRequest" /> class.
        /// </summary>
        public SendInviteRequest()
        {
        }
    }
}