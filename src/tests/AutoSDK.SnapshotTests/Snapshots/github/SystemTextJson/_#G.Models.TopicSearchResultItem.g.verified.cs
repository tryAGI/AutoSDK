//HintName: G.Models.TopicSearchResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Topic Search Result Item
    /// </summary>
    public sealed partial class TopicSearchResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_description")]
        public string? ShortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("released")]
        public string? Released { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("curated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Curated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_count")]
        public int? RepositoryCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_matches")]
        public global::System.Collections.Generic.IList<global::G.SearchResultTextMatche>? TextMatches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("related")]
        public global::System.Collections.Generic.IList<global::G.TopicSearchResultItemRelatedItem>? Related { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<global::G.TopicSearchResultItemAliase>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="shortDescription"></param>
        /// <param name="description"></param>
        /// <param name="createdBy"></param>
        /// <param name="released"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="featured"></param>
        /// <param name="curated"></param>
        /// <param name="score"></param>
        /// <param name="repositoryCount"></param>
        /// <param name="logoUrl"></param>
        /// <param name="textMatches"></param>
        /// <param name="related"></param>
        /// <param name="aliases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicSearchResultItem(
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool featured,
            bool curated,
            double score,
            string? displayName,
            string? shortDescription,
            string? description,
            string? createdBy,
            string? released,
            int? repositoryCount,
            string? logoUrl,
            global::System.Collections.Generic.IList<global::G.SearchResultTextMatche>? textMatches,
            global::System.Collections.Generic.IList<global::G.TopicSearchResultItemRelatedItem>? related,
            global::System.Collections.Generic.IList<global::G.TopicSearchResultItemAliase>? aliases)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Featured = featured;
            this.Curated = curated;
            this.Score = score;
            this.DisplayName = displayName;
            this.ShortDescription = shortDescription;
            this.Description = description;
            this.CreatedBy = createdBy;
            this.Released = released;
            this.RepositoryCount = repositoryCount;
            this.LogoUrl = logoUrl;
            this.TextMatches = textMatches;
            this.Related = related;
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItem" /> class.
        /// </summary>
        public TopicSearchResultItem()
        {
        }
    }
}