//HintName: G.Models.KnowledgeGraph.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Knowledge graph panel data, if available.
    /// </summary>
    public sealed partial class KnowledgeGraph
    {
        /// <summary>
        /// Title of the knowledge graph entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Type/category of the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Short description of the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Source of the description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptionSource")]
        public string? DescriptionSource { get; set; }

        /// <summary>
        /// Link to the description source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptionLink")]
        public string? DescriptionLink { get; set; }

        /// <summary>
        /// URL of the entity image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Official website of the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Additional attributes as key-value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeGraph" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the knowledge graph entity.
        /// </param>
        /// <param name="type">
        /// Type/category of the entity.
        /// </param>
        /// <param name="description">
        /// Short description of the entity.
        /// </param>
        /// <param name="descriptionSource">
        /// Source of the description.
        /// </param>
        /// <param name="descriptionLink">
        /// Link to the description source.
        /// </param>
        /// <param name="imageUrl">
        /// URL of the entity image.
        /// </param>
        /// <param name="website">
        /// Official website of the entity.
        /// </param>
        /// <param name="attributes">
        /// Additional attributes as key-value pairs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeGraph(
            string? title,
            string? type,
            string? description,
            string? descriptionSource,
            string? descriptionLink,
            string? imageUrl,
            string? website,
            global::System.Collections.Generic.Dictionary<string, string>? attributes)
        {
            this.Title = title;
            this.Type = type;
            this.Description = description;
            this.DescriptionSource = descriptionSource;
            this.DescriptionLink = descriptionLink;
            this.ImageUrl = imageUrl;
            this.Website = website;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeGraph" /> class.
        /// </summary>
        public KnowledgeGraph()
        {
        }
    }
}