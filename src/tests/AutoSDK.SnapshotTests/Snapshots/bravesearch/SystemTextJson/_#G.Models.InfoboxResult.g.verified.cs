//HintName: G.Models.InfoboxResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An infobox / knowledge panel result.
    /// </summary>
    public sealed partial class InfoboxResult
    {
        /// <summary>
        /// Subtype of the infobox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Display position.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Label/title of the infobox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Category of the infobox entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Long description of the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_desc")]
        public string? LongDesc { get; set; }

        /// <summary>
        /// Thumbnail image information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public global::G.Thumbnail? Thumbnail { get; set; }

        /// <summary>
        /// Key-value attributes about the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::G.InfoboxResultAttribute>? Attributes { get; set; }

        /// <summary>
        /// Social profiles associated with the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        public global::System.Collections.Generic.IList<global::G.Profile>? Profiles { get; set; }

        /// <summary>
        /// Official website URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// Ratings from various sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratings")]
        public global::System.Collections.Generic.IList<global::G.InfoboxResultRating>? Ratings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoboxResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Subtype of the infobox.
        /// </param>
        /// <param name="position">
        /// Display position.
        /// </param>
        /// <param name="label">
        /// Label/title of the infobox.
        /// </param>
        /// <param name="category">
        /// Category of the infobox entity.
        /// </param>
        /// <param name="longDesc">
        /// Long description of the entity.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail image information.
        /// </param>
        /// <param name="attributes">
        /// Key-value attributes about the entity.
        /// </param>
        /// <param name="profiles">
        /// Social profiles associated with the entity.
        /// </param>
        /// <param name="websiteUrl">
        /// Official website URL.
        /// </param>
        /// <param name="ratings">
        /// Ratings from various sources.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoboxResult(
            string? type,
            int? position,
            string? label,
            string? category,
            string? longDesc,
            global::G.Thumbnail? thumbnail,
            global::System.Collections.Generic.IList<global::G.InfoboxResultAttribute>? attributes,
            global::System.Collections.Generic.IList<global::G.Profile>? profiles,
            string? websiteUrl,
            global::System.Collections.Generic.IList<global::G.InfoboxResultRating>? ratings)
        {
            this.Type = type;
            this.Position = position;
            this.Label = label;
            this.Category = category;
            this.LongDesc = longDesc;
            this.Thumbnail = thumbnail;
            this.Attributes = attributes;
            this.Profiles = profiles;
            this.WebsiteUrl = websiteUrl;
            this.Ratings = ratings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoboxResult" /> class.
        /// </summary>
        public InfoboxResult()
        {
        }
    }
}