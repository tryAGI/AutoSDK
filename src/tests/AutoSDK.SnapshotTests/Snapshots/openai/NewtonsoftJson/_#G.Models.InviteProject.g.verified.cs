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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Project membership role
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.InviteProjectRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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