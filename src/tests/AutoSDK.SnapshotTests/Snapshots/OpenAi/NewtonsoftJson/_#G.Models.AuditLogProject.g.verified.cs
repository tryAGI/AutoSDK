//HintName: G.Models.AuditLogProject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The project that the action was scoped to. Absent for actions not scoped to projects.
    /// </summary>
    public sealed partial class AuditLogProject
    {
        /// <summary>
        /// The project ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The project title.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProject" /> class.
        /// </summary>
        /// <param name="id">
        /// The project ID.
        /// </param>
        /// <param name="name">
        /// The project title.
        /// </param>
        public AuditLogProject(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProject" /> class.
        /// </summary>
        public AuditLogProject()
        {
        }
    }
}