//HintName: G.Models.WorkspaceInvite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceInvite
    {
        /// <summary>
        /// Workspace Slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WorkspaceInviteRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WorkspaceInviteRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceInvite" /> class.
        /// </summary>
        /// <param name="id">
        /// Workspace Slug
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceInvite(
            string id,
            global::G.WorkspaceInviteRole role)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceInvite" /> class.
        /// </summary>
        public WorkspaceInvite()
        {
        }
    }
}