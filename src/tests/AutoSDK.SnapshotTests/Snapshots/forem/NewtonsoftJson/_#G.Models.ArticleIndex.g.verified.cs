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
        [global::Newtonsoft.Json.JsonProperty("type_of", Required = global::Newtonsoft.Json.Required.Always)]
        public string TypeOf { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cover_image")]
        public string? CoverImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readable_publish_date", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReadablePublishDate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("social_image", Required = global::Newtonsoft.Json.Required.Always)]
        public string SocialImage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_list", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TagList { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tags { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canonical_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CanonicalUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("positive_reactions_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PositiveReactionsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_reactions_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicReactionsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edited_at")]
        public global::System.DateTime? EditedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crossposted_at")]
        public global::System.DateTime? CrosspostedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime PublishedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_comment_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastCommentAt { get; set; } = default!;

        /// <summary>
        /// Crossposting or published date time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime PublishedTimestamp { get; set; } = default!;

        /// <summary>
        /// Reading time, in minutes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reading_time_minutes", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReadingTimeMinutes { get; set; } = default!;

        /// <summary>
        /// The resource creator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SharedUser User { get; set; } = default!;

        /// <summary>
        /// Flare tag of the article
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flare_tag")]
        public global::G.ArticleFlareTag? FlareTag { get; set; }

        /// <summary>
        /// The organization the resource belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.SharedOrganization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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