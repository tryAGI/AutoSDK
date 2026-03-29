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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL-friendly identifier for the category<br/>
        /// Example: developer-tools
        /// </summary>
        /// <example>developer-tools</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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