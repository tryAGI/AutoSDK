//HintName: G.Models.InviteProject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteProject
    {
        /// <summary>
        /// Project's public ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Project membership role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InviteProjectRoleJsonConverter))]
        public global::G.InviteProjectRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteProject" /> class.
        /// </summary>
        /// <param name="id">
        /// Project's public ID
        /// </param>
        /// <param name="role">
        /// Project membership role
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InviteProject(
            string? id,
            global::G.InviteProjectRole? role)
        {
            this.Id = id;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteProject" /> class.
        /// </summary>
        public InviteProject()
        {
        }
    }
}