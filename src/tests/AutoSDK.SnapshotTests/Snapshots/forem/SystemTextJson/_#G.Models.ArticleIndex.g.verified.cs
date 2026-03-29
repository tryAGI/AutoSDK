//HintName: G.Models.ArticleIndex.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of an article or post returned in a list
    /// </summary>
    public sealed partial class ArticleIndex
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image")]
        public string? CoverImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readable_publish_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReadablePublishDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SocialImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_list")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TagList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CanonicalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_reactions_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PositiveReactionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_reactions_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicReactionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edited_at")]
        public global::System.DateTime? EditedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossposted_at")]
        public global::System.DateTime? CrosspostedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_comment_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastCommentAt { get; set; }

        /// <summary>
        /// Crossposting or published date time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedTimestamp { get; set; }

        /// <summary>
        /// Reading time, in minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reading_time_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReadingTimeMinutes { get; set; }

        /// <summary>
        /// The resource creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SharedUser User { get; set; }

        /// <summary>
        /// Flare tag of the article
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flare_tag")]
        public global::G.ArticleFlareTag? FlareTag { get; set; }

        /// <summary>
        /// The organization the resource belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.SharedOrganization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleIndex" /> class.
        /// </summary>
        /// <param name="typeOf"></param>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="readablePublishDate"></param>
        /// <param name="socialImage"></param>
        /// <param name="tagList"></param>
        /// <param name="tags"></param>
        /// <param name="slug"></param>
        /// <param name="path"></param>
        /// <param name="url"></param>
        /// <param name="canonicalUrl"></param>
        /// <param name="positiveReactionsCount"></param>
        /// <param name="publicReactionsCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="publishedAt"></param>
        /// <param name="lastCommentAt"></param>
        /// <param name="publishedTimestamp">
        /// Crossposting or published date time
        /// </param>
        /// <param name="readingTimeMinutes">
        /// Reading time, in minutes
        /// </param>
        /// <param name="user">
        /// The resource creator
        /// </param>
        /// <param name="coverImage"></param>
        /// <param name="editedAt"></param>
        /// <param name="crosspostedAt"></param>
        /// <param name="flareTag">
        /// Flare tag of the article
        /// </param>
        /// <param name="organization">
        /// The organization the resource belongs to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArticleIndex(
            string typeOf,
            int id,
            string title,
            string description,
            string readablePublishDate,
            string socialImage,
            global::System.Collections.Generic.IList<string> tagList,
            string tags,
            string slug,
            string path,
            string url,
            string canonicalUrl,
            int positiveReactionsCount,
            int publicReactionsCount,
            global::System.DateTime createdAt,
            global::System.DateTime publishedAt,
            global::System.DateTime lastCommentAt,
            global::System.DateTime publishedTimestamp,
            int readingTimeMinutes,
            global::G.SharedUser user,
            string? coverImage,
            global::System.DateTime? editedAt,
            global::System.DateTime? crosspostedAt,
            global::G.ArticleFlareTag? flareTag,
            global::G.SharedOrganization? organization)
        {
            this.TypeOf = typeOf ?? throw new global::System.ArgumentNullException(nameof(typeOf));
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CoverImage = coverImage;
            this.ReadablePublishDate = readablePublishDate ?? throw new global::System.ArgumentNullException(nameof(readablePublishDate));
            this.SocialImage = socialImage ?? throw new global::System.ArgumentNullException(nameof(socialImage));
            this.TagList = tagList ?? throw new global::System.ArgumentNullException(nameof(tagList));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CanonicalUrl = canonicalUrl ?? throw new global::System.ArgumentNullException(nameof(canonicalUrl));
            this.PositiveReactionsCount = positiveReactionsCount;
            this.PublicReactionsCount = publicReactionsCount;
            this.CreatedAt = createdAt;
            this.EditedAt = editedAt;
            this.CrosspostedAt = crosspostedAt;
            this.PublishedAt = publishedAt;
            this.LastCommentAt = lastCommentAt;
            this.PublishedTimestamp = publishedTimestamp;
            this.ReadingTimeMinutes = readingTimeMinutes;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.FlareTag = flareTag;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleIndex" /> class.
        /// </summary>
        public ArticleIndex()
        {
        }
    }
}