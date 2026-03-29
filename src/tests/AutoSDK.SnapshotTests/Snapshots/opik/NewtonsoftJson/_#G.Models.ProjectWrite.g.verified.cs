//HintName: G.Models.ProjectWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        public global::G.ProjectWriteVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWrite" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="visibility"></param>
        /// <param name="description"></param>
        public ProjectWrite(
            string name,
            global::G.ProjectWriteVisibility? visibility,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Visibility = visibility;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWrite" /> class.
        /// </summary>
        public ProjectWrite()
        {
        }
    }
}