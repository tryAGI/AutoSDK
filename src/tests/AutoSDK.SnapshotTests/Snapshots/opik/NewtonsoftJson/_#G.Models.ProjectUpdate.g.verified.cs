//HintName: G.Models.ProjectUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpdate
    {
        /// <summary>
        /// 
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
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProjectUpdateVisibilityJsonConverter))]
        public global::G.ProjectUpdateVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="visibility"></param>
        public ProjectUpdate(
            string? name,
            string? description,
            global::G.ProjectUpdateVisibility? visibility)
        {
            this.Name = name;
            this.Description = description;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdate" /> class.
        /// </summary>
        public ProjectUpdate()
        {
        }
    }
}