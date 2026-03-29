//HintName: G.Models.PatchEnvironment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchEnvironment
    {
        /// <summary>
        /// Name of the environment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A url-friendly, unique identifier for the environment within an organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Textual description of the environment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEnvironment" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="slug">
        /// A url-friendly, unique identifier for the environment within an organization
        /// </param>
        /// <param name="description">
        /// Textual description of the environment
        /// </param>
        public PatchEnvironment(
            string? name,
            string? slug,
            string? description)
        {
            this.Name = name;
            this.Slug = slug;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEnvironment" /> class.
        /// </summary>
        public PatchEnvironment()
        {
        }
    }
}