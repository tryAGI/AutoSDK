//HintName: G.Models.GetToolkitsBySlugResponseMetaCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseMetaCategorie
    {
        /// <summary>
        /// Human-readable category name<br/>
        /// Example: Developer Tools
        /// </summary>
        /// <example>Developer Tools</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// URL-friendly identifier for the category<br/>
        /// Example: developer-tools
        /// </summary>
        /// <example>developer-tools</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseMetaCategorie" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable category name<br/>
        /// Example: Developer Tools
        /// </param>
        /// <param name="slug">
        /// URL-friendly identifier for the category<br/>
        /// Example: developer-tools
        /// </param>
        public GetToolkitsBySlugResponseMetaCategorie(
            string name,
            string slug)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseMetaCategorie" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseMetaCategorie()
        {
        }
    }
}