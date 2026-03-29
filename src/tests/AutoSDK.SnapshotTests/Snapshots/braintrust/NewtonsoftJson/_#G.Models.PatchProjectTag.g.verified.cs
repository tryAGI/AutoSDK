//HintName: G.Models.PatchProjectTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchProjectTag
    {
        /// <summary>
        /// Name of the project tag
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the project tag
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Color of the tag for the UI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectTag" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project tag
        /// </param>
        /// <param name="description">
        /// Textual description of the project tag
        /// </param>
        /// <param name="color">
        /// Color of the tag for the UI
        /// </param>
        public PatchProjectTag(
            string? name,
            string? description,
            string? color)
        {
            this.Name = name;
            this.Description = description;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectTag" /> class.
        /// </summary>
        public PatchProjectTag()
        {
        }
    }
}