//HintName: G.Models.SuggestResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single autocomplete suggestion.
    /// </summary>
    public sealed partial class SuggestResult
    {
        /// <summary>
        /// The suggested search query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Whether the suggestion is a known entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_entity")]
        public bool? IsEntity { get; set; }

        /// <summary>
        /// Title of the entity, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the entity, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the entity image, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("img")]
        public string? Img { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestResult" /> class.
        /// </summary>
        /// <param name="query">
        /// The suggested search query.
        /// </param>
        /// <param name="isEntity">
        /// Whether the suggestion is a known entity.
        /// </param>
        /// <param name="title">
        /// Title of the entity, if applicable.
        /// </param>
        /// <param name="description">
        /// Description of the entity, if applicable.
        /// </param>
        /// <param name="img">
        /// URL of the entity image, if applicable.
        /// </param>
        public SuggestResult(
            string? query,
            bool? isEntity,
            string? title,
            string? description,
            string? img)
        {
            this.Query = query;
            this.IsEntity = isEntity;
            this.Title = title;
            this.Description = description;
            this.Img = img;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestResult" /> class.
        /// </summary>
        public SuggestResult()
        {
        }
    }
}