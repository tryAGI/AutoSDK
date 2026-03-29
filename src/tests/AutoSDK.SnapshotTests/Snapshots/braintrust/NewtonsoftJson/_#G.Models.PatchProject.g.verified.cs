//HintName: G.Models.PatchProject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchProject
    {
        /// <summary>
        /// Name of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings")]
        public global::G.AllOf<global::G.ProjectSettings, object>? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProject" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description"></param>
        /// <param name="userId"></param>
        /// <param name="settings"></param>
        public PatchProject(
            string? name,
            string? description,
            string? userId,
            global::G.AllOf<global::G.ProjectSettings, object>? settings)
        {
            this.Name = name;
            this.Description = description;
            this.UserId = userId;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProject" /> class.
        /// </summary>
        public PatchProject()
        {
        }
    }
}